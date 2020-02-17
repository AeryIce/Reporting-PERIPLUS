<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.LabelPeriplus = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBoxUserName = New System.Windows.Forms.TextBox()
		Me.TextBoxPassword = New System.Windows.Forms.TextBox()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.LabelStatusDB = New System.Windows.Forms.Label()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'LabelPeriplus
		'
		Me.LabelPeriplus.AutoSize = True
		Me.LabelPeriplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.LabelPeriplus.Font = New System.Drawing.Font("Century725 Cn BT", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelPeriplus.Location = New System.Drawing.Point(111, 10)
		Me.LabelPeriplus.Name = "LabelPeriplus"
		Me.LabelPeriplus.Size = New System.Drawing.Size(151, 39)
		Me.LabelPeriplus.TabIndex = 1
		Me.LabelPeriplus.Text = "PERIPLUS"
		Me.LabelPeriplus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Century725 Cn BT", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(11, 49)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(352, 18)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Jakarta - Bandung - Semarang - Yogyakarta - Surabaya - Bali"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBoxUserName
		'
		Me.TextBoxUserName.BackColor = System.Drawing.Color.Lavender
		Me.TextBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxUserName.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxUserName.Location = New System.Drawing.Point(109, 70)
		Me.TextBoxUserName.Name = "TextBoxUserName"
		Me.TextBoxUserName.Size = New System.Drawing.Size(191, 31)
		Me.TextBoxUserName.TabIndex = 3
		Me.TextBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TextBoxPassword
		'
		Me.TextBoxPassword.BackColor = System.Drawing.Color.Lavender
		Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxPassword.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxPassword.Location = New System.Drawing.Point(109, 115)
		Me.TextBoxPassword.Name = "TextBoxPassword"
		Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxPassword.Size = New System.Drawing.Size(191, 31)
		Me.TextBoxPassword.TabIndex = 5
		Me.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'ButtonCancel
		'
		Me.ButtonCancel.BackColor = System.Drawing.Color.Transparent
		Me.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ButtonCancel.FlatAppearance.BorderSize = 0
		Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonCancel.Image = Global.Reporting_Cafe.My.Resources.Resources.close_window_32px
		Me.ButtonCancel.Location = New System.Drawing.Point(208, 152)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(92, 37)
		Me.ButtonCancel.TabIndex = 8
		Me.ButtonCancel.UseVisualStyleBackColor = False
		'
		'ButtonLogin
		'
		Me.ButtonLogin.BackColor = System.Drawing.Color.Transparent
		Me.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ButtonLogin.FlatAppearance.BorderSize = 0
		Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonLogin.Image = Global.Reporting_Cafe.My.Resources.Resources.telegram_app_32px
		Me.ButtonLogin.Location = New System.Drawing.Point(109, 152)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(93, 37)
		Me.ButtonLogin.TabIndex = 7
		Me.ButtonLogin.UseVisualStyleBackColor = False
		'
		'PictureBox2
		'
		Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox2.Image = Global.Reporting_Cafe.My.Resources.Resources.password_32px
		Me.PictureBox2.Location = New System.Drawing.Point(70, 110)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(33, 36)
		Me.PictureBox2.TabIndex = 6
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Image = Global.Reporting_Cafe.My.Resources.Resources.user_32px
		Me.PictureBox1.Location = New System.Drawing.Point(70, 70)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(34, 31)
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
		Me.Panel1.Controls.Add(Me.LabelPeriplus)
		Me.Panel1.Controls.Add(Me.ButtonCancel)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.ButtonLogin)
		Me.Panel1.Controls.Add(Me.TextBoxUserName)
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Controls.Add(Me.TextBoxPassword)
		Me.Panel1.Location = New System.Drawing.Point(4, 170)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(391, 214)
		Me.Panel1.TabIndex = 9
		'
		'LabelStatusDB
		'
		Me.LabelStatusDB.AutoSize = True
		Me.LabelStatusDB.Font = New System.Drawing.Font("Courier New", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
				Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusDB.Location = New System.Drawing.Point(290, 518)
		Me.LabelStatusDB.Name = "LabelStatusDB"
		Me.LabelStatusDB.Size = New System.Drawing.Size(14, 14)
		Me.LabelStatusDB.TabIndex = 10
		Me.LabelStatusDB.Text = "."
		'
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CornflowerBlue
		Me.ClientSize = New System.Drawing.Size(400, 541)
		Me.Controls.Add(Me.LabelStatusDB)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormLogin"
		Me.Opacity = 0.85R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormLogin"
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelPeriplus As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBoxUserName As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TextBoxPassword As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents Panel1 As Panel
	Public WithEvents LabelStatusDB As Label
End Class
