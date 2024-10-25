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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 1
        Label2.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 2
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 3
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 20)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(53, 287)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 20)
        Label6.TabIndex = 5
        Label6.Text = "Pin Code"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 338)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 20)
        Label7.TabIndex = 6
        Label7.Text = "State"
        ' 
        ' txtFisrtName
        ' 
        txtFisrtName.Location = New Point(198, 28)
        txtFisrtName.Name = "txtFisrtName"
        txtFisrtName.Size = New Size(166, 27)
        txtFisrtName.TabIndex = 7
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(198, 76)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(166, 27)
        txtMiddleName.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(198, 136)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(166, 27)
        txtLastName.TabIndex = 9
        ' 
        ' txtPinCode
        ' 
        txtPinCode.Location = New Point(198, 280)
        txtPinCode.Name = "txtPinCode"
        txtPinCode.Size = New Size(166, 27)
        txtPinCode.TabIndex = 10
        ' 
        ' cmdGender
        ' 
        cmdGender.FormattingEnabled = True
        cmdGender.Items.AddRange(New Object() {"  --Select--", "Male", "Female", "Other"})
        cmdGender.Location = New Point(198, 187)
        cmdGender.Name = "cmdGender"
        cmdGender.Size = New Size(166, 28)
        cmdGender.TabIndex = 11
        ' 
        ' cmdState
        ' 
        cmdState.FormattingEnabled = True
        cmdState.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Maharashtra", "Madhya Pradesh", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Tripura", "Telangana", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Andaman & Nicobar (UT)", "Chandigarh (UT)", "Dadra & Nagar Haveli and Daman & Diu (UT)", "Delhi [National Capital Territory (NCT)]", "Jammu & Kashmir (UT)", "Ladakh (UT)", "Lakshadweep (UT)", "Puducherry (UT)"})
        cmdState.Location = New Point(198, 338)
        cmdState.Name = "cmdState"
        cmdState.Size = New Size(166, 28)
        cmdState.TabIndex = 12
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(198, 234)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(166, 27)
        txtAddress.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(70, 399)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 29)
        Button1.TabIndex = 14
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(238, 399)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 35)
        Button2.TabIndex = 15
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Id
        ' 
        Id.Location = New Point(594, 47)
        Id.Name = "Id"
        Id.Size = New Size(125, 27)
        Id.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(478, 54)
        Label8.Name = "Label8"
        Label8.Size = New Size(22, 20)
        Label8.TabIndex = 17
        Label8.Text = "Id"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(502, 158)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(552, 472)
        DataGridView1.TabIndex = 18
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(145, 466)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 35)
        Button3.TabIndex = 19
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1135, 719)
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
End Class
