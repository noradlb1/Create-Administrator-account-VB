Namespace GetAdmin
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.button3 = New System.Windows.Forms.Button()
            Me.label5 = New System.Windows.Forms.Label()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button5 = New System.Windows.Forms.Button()
            Me.button6 = New System.Windows.Forms.Button()
            Me.button7 = New System.Windows.Forms.Button()
            Me.button8 = New System.Windows.Forms.Button()
            Me.pictureBox4 = New System.Windows.Forms.PictureBox()
            Me.pictureBox3 = New System.Windows.Forms.PictureBox()
            Me.pictureBox5 = New System.Windows.Forms.PictureBox()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.button9 = New System.Windows.Forms.Button()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Blue
            Me.label1.Location = New System.Drawing.Point(9, 20)
            Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(326, 29)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Create a new Admin Account:"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button1
            '
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.Location = New System.Drawing.Point(243, 176)
            Me.button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(92, 34)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Create"
            Me.button1.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.Location = New System.Drawing.Point(9, 176)
            Me.button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(186, 34)
            Me.button2.TabIndex = 2
            Me.button2.Text = "Exit and Cleanup"
            Me.button2.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(10, 79)
            Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(102, 24)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Username:"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label3.Location = New System.Drawing.Point(10, 125)
            Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(97, 24)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Password:"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'textBox1
            '
            Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox1.Location = New System.Drawing.Point(112, 79)
            Me.textBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(224, 28)
            Me.textBox1.TabIndex = 5
            '
            'textBox2
            '
            Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox2.Location = New System.Drawing.Point(112, 123)
            Me.textBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(224, 28)
            Me.textBox2.TabIndex = 5
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.Blue
            Me.label4.Location = New System.Drawing.Point(356, 20)
            Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(230, 29)
            Me.label4.TabIndex = 1
            Me.label4.Text = "Remove an account:"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(360, 101)
            Me.comboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(211, 30)
            Me.comboBox1.TabIndex = 6
            '
            'button3
            '
            Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.Location = New System.Drawing.Point(464, 148)
            Me.button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(106, 34)
            Me.button3.TabIndex = 2
            Me.button3.Text = "Remove"
            Me.button3.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label5.Location = New System.Drawing.Point(10, 223)
            Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(63, 24)
            Me.label5.TabIndex = 3
            Me.label5.Text = "Open:"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button4
            '
            Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button4.Location = New System.Drawing.Point(100, 226)
            Me.button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(146, 27)
            Me.button4.TabIndex = 8
            Me.button4.Text = "Command Prompt"
            Me.button4.UseVisualStyleBackColor = True
            '
            'button5
            '
            Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button5.Location = New System.Drawing.Point(280, 225)
            Me.button5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(146, 27)
            Me.button5.TabIndex = 8
            Me.button5.Text = "Registry Editor"
            Me.button5.UseVisualStyleBackColor = True
            '
            'button6
            '
            Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button6.Location = New System.Drawing.Point(100, 258)
            Me.button6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button6.Name = "button6"
            Me.button6.Size = New System.Drawing.Size(146, 27)
            Me.button6.TabIndex = 8
            Me.button6.Text = "Task Manager"
            Me.button6.UseVisualStyleBackColor = True
            '
            'button7
            '
            Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button7.Location = New System.Drawing.Point(280, 257)
            Me.button7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button7.Name = "button7"
            Me.button7.Size = New System.Drawing.Size(294, 27)
            Me.button7.TabIndex = 8
            Me.button7.Text = "Advanced User Accounts Control Panel"
            Me.button7.UseVisualStyleBackColor = True
            '
            'button8
            '
            Me.button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button8.Location = New System.Drawing.Point(458, 224)
            Me.button8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button8.Name = "button8"
            Me.button8.Size = New System.Drawing.Size(112, 27)
            Me.button8.TabIndex = 8
            Me.button8.Text = "Explorer"
            Me.button8.UseVisualStyleBackColor = True
            '
            'pictureBox4
            '
            Me.pictureBox4.Image = Global.My.Resources.Resources.netplwiz
            Me.pictureBox4.Location = New System.Drawing.Point(252, 257)
            Me.pictureBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.Size = New System.Drawing.Size(27, 27)
            Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox4.TabIndex = 7
            Me.pictureBox4.TabStop = False
            '
            'pictureBox3
            '
            Me.pictureBox3.Image = Global.My.Resources.Resources.taskmgr
            Me.pictureBox3.Location = New System.Drawing.Point(72, 258)
            Me.pictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(27, 27)
            Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox3.TabIndex = 7
            Me.pictureBox3.TabStop = False
            '
            'pictureBox5
            '
            Me.pictureBox5.Image = Global.My.Resources.Resources.explorer
            Me.pictureBox5.Location = New System.Drawing.Point(430, 225)
            Me.pictureBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.pictureBox5.Name = "pictureBox5"
            Me.pictureBox5.Size = New System.Drawing.Size(27, 27)
            Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox5.TabIndex = 7
            Me.pictureBox5.TabStop = False
            '
            'pictureBox2
            '
            Me.pictureBox2.Image = Global.My.Resources.Resources.regedit
            Me.pictureBox2.Location = New System.Drawing.Point(252, 226)
            Me.pictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(27, 27)
            Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox2.TabIndex = 7
            Me.pictureBox2.TabStop = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = Global.My.Resources.Resources.cmd
            Me.pictureBox1.Location = New System.Drawing.Point(72, 226)
            Me.pictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(27, 27)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 7
            Me.pictureBox1.TabStop = False
            '
            'button9
            '
            Me.button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button9.Location = New System.Drawing.Point(416, 51)
            Me.button9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.button9.Name = "button9"
            Me.button9.Size = New System.Drawing.Size(154, 33)
            Me.button9.TabIndex = 9
            Me.button9.Text = "Refresh Users"
            Me.button9.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ClientSize = New System.Drawing.Size(583, 293)
            Me.Controls.Add(Me.button9)
            Me.Controls.Add(Me.button7)
            Me.Controls.Add(Me.button6)
            Me.Controls.Add(Me.pictureBox4)
            Me.Controls.Add(Me.pictureBox3)
            Me.Controls.Add(Me.button8)
            Me.Controls.Add(Me.button5)
            Me.Controls.Add(Me.pictureBox5)
            Me.Controls.Add(Me.pictureBox2)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Create Administrator account"
            Me.TopMost = True
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private label1 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents button3 As System.Windows.Forms.Button
		Private label5 As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents button4 As System.Windows.Forms.Button
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents button5 As System.Windows.Forms.Button
		Private pictureBox3 As System.Windows.Forms.PictureBox
		Private WithEvents button6 As System.Windows.Forms.Button
		Private pictureBox4 As System.Windows.Forms.PictureBox
		Private WithEvents button7 As System.Windows.Forms.Button
		Private pictureBox5 As System.Windows.Forms.PictureBox
		Private WithEvents button8 As System.Windows.Forms.Button
		Private WithEvents button9 As System.Windows.Forms.Button
	End Class
End Namespace

