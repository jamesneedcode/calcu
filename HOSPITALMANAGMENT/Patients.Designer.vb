﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.brnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtfirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmiddlename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnationality = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.dateselect = New System.Windows.Forms.DateTimePicker()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbbloodtype = New System.Windows.Forms.ComboBox()
        Me.txtbloodpresure = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsymptoms = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.lbAGE = New System.Windows.Forms.Label()
        Me.cbCIVIL = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'brnCancel
        '
        Me.brnCancel.BackColor = System.Drawing.Color.LightCyan
        Me.brnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnCancel.Location = New System.Drawing.Point(504, 305)
        Me.brnCancel.Name = "brnCancel"
        Me.brnCancel.Size = New System.Drawing.Size(86, 49)
        Me.brnCancel.TabIndex = 11
        Me.brnCancel.Text = "CANCEL"
        Me.brnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightCyan
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(413, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 49)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtfirstName
        '
        Me.txtfirstName.BackColor = System.Drawing.Color.LightCyan
        Me.txtfirstName.Location = New System.Drawing.Point(178, 87)
        Me.txtfirstName.Name = "txtfirstName"
        Me.txtfirstName.Size = New System.Drawing.Size(177, 20)
        Me.txtfirstName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "First Name"
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.Color.LightCyan
        Me.txtlastname.Location = New System.Drawing.Point(34, 87)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(138, 20)
        Me.txtlastname.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Last Name"
        '
        'txtmiddlename
        '
        Me.txtmiddlename.BackColor = System.Drawing.Color.LightCyan
        Me.txtmiddlename.Location = New System.Drawing.Point(363, 87)
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(152, 20)
        Me.txtmiddlename.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(364, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Middle Name"
        '
        'txtnationality
        '
        Me.txtnationality.BackColor = System.Drawing.Color.LightCyan
        Me.txtnationality.Location = New System.Drawing.Point(447, 187)
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(143, 20)
        Me.txtnationality.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(444, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nationality"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(410, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(318, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Gender"
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.LightCyan
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.gender.Location = New System.Drawing.Point(309, 132)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(76, 21)
        Me.gender.TabIndex = 22
        '
        'dateselect
        '
        Me.dateselect.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame
        Me.dateselect.CalendarTitleBackColor = System.Drawing.Color.LightCyan
        Me.dateselect.Location = New System.Drawing.Point(396, 133)
        Me.dateselect.Name = "dateselect"
        Me.dateselect.Size = New System.Drawing.Size(194, 20)
        Me.dateselect.TabIndex = 23
        '
        'txtheight
        '
        Me.txtheight.BackColor = System.Drawing.Color.LightCyan
        Me.txtheight.Location = New System.Drawing.Point(128, 187)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(85, 20)
        Me.txtheight.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(125, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 14)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Height(cm)"
        '
        'txtweight
        '
        Me.txtweight.BackColor = System.Drawing.Color.LightCyan
        Me.txtweight.Location = New System.Drawing.Point(37, 187)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(84, 20)
        Me.txtweight.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 14)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Weight(kg)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(335, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 14)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Blood Pressure"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(231, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 14)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Blood Type"
        '
        'txtphonenumber
        '
        Me.txtphonenumber.BackColor = System.Drawing.Color.LightCyan
        Me.txtphonenumber.Location = New System.Drawing.Point(215, 234)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(152, 20)
        Me.txtphonenumber.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(214, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 14)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Phone Number"
        '
        'cbbloodtype
        '
        Me.cbbloodtype.BackColor = System.Drawing.Color.LightCyan
        Me.cbbloodtype.FormattingEnabled = True
        Me.cbbloodtype.Items.AddRange(New Object() {"A", "B", "AB", "O"})
        Me.cbbloodtype.Location = New System.Drawing.Point(223, 186)
        Me.cbbloodtype.Name = "cbbloodtype"
        Me.cbbloodtype.Size = New System.Drawing.Size(96, 21)
        Me.cbbloodtype.TabIndex = 34
        '
        'txtbloodpresure
        '
        Me.txtbloodpresure.BackColor = System.Drawing.Color.LightCyan
        Me.txtbloodpresure.Location = New System.Drawing.Point(338, 187)
        Me.txtbloodpresure.Name = "txtbloodpresure"
        Me.txtbloodpresure.Size = New System.Drawing.Size(85, 20)
        Me.txtbloodpresure.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 14)
        Me.Label4.TabIndex = 35
        '
        'txtsymptoms
        '
        Me.txtsymptoms.BackColor = System.Drawing.Color.LightCyan
        Me.txtsymptoms.Location = New System.Drawing.Point(41, 233)
        Me.txtsymptoms.Name = "txtsymptoms"
        Me.txtsymptoms.Size = New System.Drawing.Size(152, 20)
        Me.txtsymptoms.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 14)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Current Symptoms"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.LightCyan
        Me.txtid.Location = New System.Drawing.Point(34, 315)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(87, 20)
        Me.txtid.TabIndex = 39
        Me.txtid.Visible = False
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(34, 301)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(56, 14)
        Me.lbID.TabIndex = 38
        Me.lbID.Text = "Patient ID"
        Me.lbID.Visible = False
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.LightCyan
        Me.txtaddress.Location = New System.Drawing.Point(34, 133)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(175, 20)
        Me.txtaddress.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 14)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Address"
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.LightCyan
        Me.txtage.Location = New System.Drawing.Point(524, 87)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(66, 20)
        Me.txtage.TabIndex = 43
        '
        'lbAGE
        '
        Me.lbAGE.AutoSize = True
        Me.lbAGE.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAGE.Location = New System.Drawing.Point(524, 73)
        Me.lbAGE.Name = "lbAGE"
        Me.lbAGE.Size = New System.Drawing.Size(25, 14)
        Me.lbAGE.TabIndex = 42
        Me.lbAGE.Text = "Age"
        '
        'cbCIVIL
        '
        Me.cbCIVIL.BackColor = System.Drawing.Color.LightCyan
        Me.cbCIVIL.FormattingEnabled = True
        Me.cbCIVIL.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Cohability"})
        Me.cbCIVIL.Location = New System.Drawing.Point(219, 132)
        Me.cbCIVIL.Name = "cbCIVIL"
        Me.cbCIVIL.Size = New System.Drawing.Size(78, 21)
        Me.cbCIVIL.TabIndex = 45
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(219, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 14)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Civil Status"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(251, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 31)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Patient"
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(637, 385)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cbCIVIL)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.lbAGE)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.txtsymptoms)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbbloodtype)
        Me.Controls.Add(Me.txtphonenumber)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtbloodpresure)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtheight)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtweight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dateselect)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.txtnationality)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmiddlename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.brnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtfirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents brnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtfirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnationality As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gender As ComboBox
    Friend WithEvents dateselect As DateTimePicker
    Friend WithEvents txtheight As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtweight As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbbloodtype As ComboBox
    Friend WithEvents txtbloodpresure As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsymptoms As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents lbID As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents lbAGE As Label
    Friend WithEvents cbCIVIL As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
End Class
