<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelDatabase = New System.Windows.Forms.Label()
        Me.ButtonRekap = New System.Windows.Forms.Button()
        Me.DGVRekapQuery1 = New System.Windows.Forms.DataGridView()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.LabelKodeCafe = New System.Windows.Forms.Label()
        Me.ComboBoxKodeCafe = New System.Windows.Forms.ComboBox()
        Me.DGVRekapQuery2 = New System.Windows.Forms.DataGridView()
        Me.LabelNamaCafe = New System.Windows.Forms.Label()
        Me.TextBoxNamaCafe = New System.Windows.Forms.TextBox()
        Me.LabelJumlahQuery1 = New System.Windows.Forms.Label()
        Me.LabelJumlahQuery2 = New System.Windows.Forms.Label()
        Me.LabelHeader1 = New System.Windows.Forms.Label()
        Me.LabelHeader2 = New System.Windows.Forms.Label()
        CType(Me.DGVRekapQuery1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRekapQuery2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(12, 9)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(95, 13)
        Me.LabelStatus.TabIndex = 0
        Me.LabelStatus.Text = "Status Database  :"
        '
        'LabelDatabase
        '
        Me.LabelDatabase.AutoSize = True
        Me.LabelDatabase.Location = New System.Drawing.Point(113, 9)
        Me.LabelDatabase.Name = "LabelDatabase"
        Me.LabelDatabase.Size = New System.Drawing.Size(10, 13)
        Me.LabelDatabase.TabIndex = 1
        Me.LabelDatabase.Text = "."
        '
        'ButtonRekap
        '
        Me.ButtonRekap.Location = New System.Drawing.Point(340, 29)
        Me.ButtonRekap.Name = "ButtonRekap"
        Me.ButtonRekap.Size = New System.Drawing.Size(75, 55)
        Me.ButtonRekap.TabIndex = 2
        Me.ButtonRekap.Text = "Rekap"
        Me.ButtonRekap.UseVisualStyleBackColor = True
        '
        'DGVRekapQuery1
        '
        Me.DGVRekapQuery1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRekapQuery1.Location = New System.Drawing.Point(15, 147)
        Me.DGVRekapQuery1.Name = "DGVRekapQuery1"
        Me.DGVRekapQuery1.Size = New System.Drawing.Size(773, 169)
        Me.DGVRekapQuery1.TabIndex = 3
        '
        'ButtonConvert
        '
        Me.ButtonConvert.Location = New System.Drawing.Point(12, 470)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConvert.TabIndex = 4
        Me.ButtonConvert.Text = "Convert"
        Me.ButtonConvert.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 87)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(116, 470)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'LabelTanggal
        '
        Me.LabelTanggal.AutoSize = True
        Me.LabelTanggal.Location = New System.Drawing.Point(12, 93)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(46, 13)
        Me.LabelTanggal.TabIndex = 7
        Me.LabelTanggal.Text = "Tanggal"
        '
        'LabelKodeCafe
        '
        Me.LabelKodeCafe.AutoSize = True
        Me.LabelKodeCafe.Location = New System.Drawing.Point(12, 31)
        Me.LabelKodeCafe.Name = "LabelKodeCafe"
        Me.LabelKodeCafe.Size = New System.Drawing.Size(57, 13)
        Me.LabelKodeCafe.TabIndex = 8
        Me.LabelKodeCafe.Text = "Kode Kafe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ComboBoxKodeCafe
        '
        Me.ComboBoxKodeCafe.FormattingEnabled = True
        Me.ComboBoxKodeCafe.Items.AddRange(New Object() {"PP333", "PP334"})
        Me.ComboBoxKodeCafe.Location = New System.Drawing.Point(116, 31)
        Me.ComboBoxKodeCafe.Name = "ComboBoxKodeCafe"
        Me.ComboBoxKodeCafe.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxKodeCafe.TabIndex = 9
        '
        'DGVRekapQuery2
        '
        Me.DGVRekapQuery2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRekapQuery2.Location = New System.Drawing.Point(15, 322)
        Me.DGVRekapQuery2.Name = "DGVRekapQuery2"
        Me.DGVRekapQuery2.Size = New System.Drawing.Size(773, 127)
        Me.DGVRekapQuery2.TabIndex = 10
        '
        'LabelNamaCafe
        '
        Me.LabelNamaCafe.AutoSize = True
        Me.LabelNamaCafe.Location = New System.Drawing.Point(12, 61)
        Me.LabelNamaCafe.Name = "LabelNamaCafe"
        Me.LabelNamaCafe.Size = New System.Drawing.Size(60, 13)
        Me.LabelNamaCafe.TabIndex = 11
        Me.LabelNamaCafe.Text = "Nama Kafe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBoxNamaCafe
        '
        Me.TextBoxNamaCafe.Location = New System.Drawing.Point(116, 58)
        Me.TextBoxNamaCafe.Name = "TextBoxNamaCafe"
        Me.TextBoxNamaCafe.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxNamaCafe.TabIndex = 12
        '
        'LabelJumlahQuery1
        '
        Me.LabelJumlahQuery1.AutoSize = True
        Me.LabelJumlahQuery1.Location = New System.Drawing.Point(794, 241)
        Me.LabelJumlahQuery1.Name = "LabelJumlahQuery1"
        Me.LabelJumlahQuery1.Size = New System.Drawing.Size(10, 13)
        Me.LabelJumlahQuery1.TabIndex = 13
        Me.LabelJumlahQuery1.Text = "."
        '
        'LabelJumlahQuery2
        '
        Me.LabelJumlahQuery2.AutoSize = True
        Me.LabelJumlahQuery2.Location = New System.Drawing.Point(794, 369)
        Me.LabelJumlahQuery2.Name = "LabelJumlahQuery2"
        Me.LabelJumlahQuery2.Size = New System.Drawing.Size(10, 13)
        Me.LabelJumlahQuery2.TabIndex = 14
        Me.LabelJumlahQuery2.Text = "."
        '
        'LabelHeader1
        '
        Me.LabelHeader1.AutoSize = True
        Me.LabelHeader1.Location = New System.Drawing.Point(794, 216)
        Me.LabelHeader1.Name = "LabelHeader1"
        Me.LabelHeader1.Size = New System.Drawing.Size(10, 13)
        Me.LabelHeader1.TabIndex = 15
        Me.LabelHeader1.Text = "."
        '
        'LabelHeader2
        '
        Me.LabelHeader2.AutoSize = True
        Me.LabelHeader2.Location = New System.Drawing.Point(794, 343)
        Me.LabelHeader2.Name = "LabelHeader2"
        Me.LabelHeader2.Size = New System.Drawing.Size(10, 13)
        Me.LabelHeader2.TabIndex = 16
        Me.LabelHeader2.Text = "."
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 505)
        Me.Controls.Add(Me.LabelHeader2)
        Me.Controls.Add(Me.LabelHeader1)
        Me.Controls.Add(Me.LabelJumlahQuery2)
        Me.Controls.Add(Me.LabelJumlahQuery1)
        Me.Controls.Add(Me.TextBoxNamaCafe)
        Me.Controls.Add(Me.LabelNamaCafe)
        Me.Controls.Add(Me.DGVRekapQuery2)
        Me.Controls.Add(Me.ComboBoxKodeCafe)
        Me.Controls.Add(Me.LabelKodeCafe)
        Me.Controls.Add(Me.LabelTanggal)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ButtonConvert)
        Me.Controls.Add(Me.DGVRekapQuery1)
        Me.Controls.Add(Me.ButtonRekap)
        Me.Controls.Add(Me.LabelDatabase)
        Me.Controls.Add(Me.LabelStatus)
        Me.Name = "FormHome"
        Me.Text = "FormHome"
        CType(Me.DGVRekapQuery1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRekapQuery2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelStatus As Label
    Public WithEvents LabelDatabase As Label
    Friend WithEvents ButtonRekap As Button
    Friend WithEvents DGVRekapQuery1 As DataGridView
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ButtonExit As Button
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents LabelKodeCafe As Label
    Friend WithEvents ComboBoxKodeCafe As ComboBox
    Friend WithEvents DGVRekapQuery2 As DataGridView
    Friend WithEvents LabelNamaCafe As Label
    Public WithEvents TextBoxNamaCafe As TextBox
    Friend WithEvents LabelJumlahQuery2 As Label
    Public WithEvents LabelJumlahQuery1 As Label
    Public WithEvents LabelHeader1 As Label
    Public WithEvents LabelHeader2 As Label
End Class
