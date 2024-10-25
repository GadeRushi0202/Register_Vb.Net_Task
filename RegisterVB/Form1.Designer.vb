<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtFisrtName = New TextBox()
        txtMiddleName = New TextBox()
        txtLastName = New TextBox()
        txtPinCode = New TextBox()
        cmdGender = New ComboBox()
        cmdState = New ComboBox()
        txtAddress = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Id = New TextBox()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        Button3 = New Button()
        Label9 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 193)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 23)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 254)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 23)
        Label2.TabIndex = 1
        Label2.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 310)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 23)
        Label3.TabIndex = 2
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(63, 371)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 23)
        Label4.TabIndex = 3
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(62, 420)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 23)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(51, 477)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 23)
        Label6.TabIndex = 5
        Label6.Text = "Pin Code"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(62, 534)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 23)
        Label7.TabIndex = 6
        Label7.Text = "State"
        ' 
        ' txtFisrtName
        ' 
        txtFisrtName.Location = New Point(239, 193)
        txtFisrtName.Margin = New Padding(4, 3, 4, 3)
        txtFisrtName.Name = "txtFisrtName"
        txtFisrtName.Size = New Size(292, 30)
        txtFisrtName.TabIndex = 7
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(239, 251)
        txtMiddleName.Margin = New Padding(4, 3, 4, 3)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(292, 30)
        txtMiddleName.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(239, 303)
        txtLastName.Margin = New Padding(4, 3, 4, 3)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(292, 30)
        txtLastName.TabIndex = 9
        ' 
        ' txtPinCode
        ' 
        txtPinCode.Location = New Point(239, 477)
        txtPinCode.Margin = New Padding(4, 3, 4, 3)
        txtPinCode.Name = "txtPinCode"
        txtPinCode.Size = New Size(292, 30)
        txtPinCode.TabIndex = 10
        ' 
        ' cmdGender
        ' 
        cmdGender.FormattingEnabled = True
        cmdGender.Items.AddRange(New Object() {"  --Select--", "Male", "Female", "Other"})
        cmdGender.Location = New Point(239, 363)
        cmdGender.Margin = New Padding(4, 3, 4, 3)
        cmdGender.Name = "cmdGender"
        cmdGender.Size = New Size(292, 31)
        cmdGender.TabIndex = 11
        ' 
        ' cmdState
        ' 
        cmdState.FormattingEnabled = True
        cmdState.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Maharashtra", "Madhya Pradesh", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Tripura", "Telangana", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Andaman & Nicobar (UT)", "Chandigarh (UT)", "Dadra & Nagar Haveli and Daman & Diu (UT)", "Delhi [National Capital Territory (NCT)]", "Jammu & Kashmir (UT)", "Ladakh (UT)", "Lakshadweep (UT)", "Puducherry (UT)"})
        cmdState.Location = New Point(239, 534)
        cmdState.Margin = New Padding(4, 3, 4, 3)
        cmdState.Name = "cmdState"
        cmdState.Size = New Size(292, 31)
        cmdState.TabIndex = 12
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(239, 420)
        txtAddress.Margin = New Padding(4, 3, 4, 3)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(292, 30)
        txtAddress.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Location = New Point(51, 612)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 61)
        Button1.TabIndex = 14
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Button2.Location = New Point(293, 612)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(195, 57)
        Button2.TabIndex = 15
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Id
        ' 
        Id.Location = New Point(239, 127)
        Id.Margin = New Padding(4, 3, 4, 3)
        Id.Name = "Id"
        Id.Size = New Size(292, 30)
        Id.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(90, 134)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(27, 23)
        Label8.TabIndex = 17
        Label8.Text = "Id"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(562, 162)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(861, 543)
        DataGridView1.TabIndex = 18
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Location = New Point(170, 679)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(195, 59)
        Button3.TabIndex = 19
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Label9.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(107, 43)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(286, 38)
        Label9.TabIndex = 20
        Label9.Text = "Registration Form"
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(1703, 827)
        Controls.Add(Label9)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(Id)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtAddress)
        Controls.Add(cmdState)
        Controls.Add(cmdGender)
        Controls.Add(txtPinCode)
        Controls.Add(txtLastName)
        Controls.Add(txtMiddleName)
        Controls.Add(txtFisrtName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFisrtName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPinCode As TextBox
    Friend WithEvents cmdGender As ComboBox
    Friend WithEvents cmdState As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
End Class
