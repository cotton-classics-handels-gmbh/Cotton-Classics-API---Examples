<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shipments
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCustomerId = New System.Windows.Forms.Label()
        Me.CustomerId = New System.Windows.Forms.TextBox()
        Me.SendQuery = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelProcessId = New System.Windows.Forms.Label()
        Me.LabelMandator = New System.Windows.Forms.Label()
        Me.MandatorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.MaskedTextBox()
        Me.UsernameText = New System.Windows.Forms.TextBox()
        Me.ShipmentDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 163)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 15)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "*"
        '
        'LabelCustomerId
        '
        Me.LabelCustomerId.AutoSize = True
        Me.LabelCustomerId.Location = New System.Drawing.Point(32, 137)
        Me.LabelCustomerId.Name = "LabelCustomerId"
        Me.LabelCustomerId.Size = New System.Drawing.Size(75, 15)
        Me.LabelCustomerId.TabIndex = 85
        Me.LabelCustomerId.Text = "Customer ID"
        '
        'CustomerId
        '
        Me.CustomerId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.VB.My.MySettings.Default, "AccountNo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CustomerId.Location = New System.Drawing.Point(127, 134)
        Me.CustomerId.Name = "CustomerId"
        Me.CustomerId.Size = New System.Drawing.Size(100, 20)
        Me.CustomerId.TabIndex = 73
        Me.CustomerId.Text = Global.VB.My.MySettings.Default.AccountNo
        '
        'SendQuery
        '
        Me.SendQuery.Location = New System.Drawing.Point(167, 204)
        Me.SendQuery.Name = "SendQuery"
        Me.SendQuery.Size = New System.Drawing.Size(75, 23)
        Me.SendQuery.TabIndex = 79
        Me.SendQuery.Text = "Send Query"
        Me.SendQuery.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(230, 134)
        Me.Label26.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(12, 15)
        Me.Label26.TabIndex = 84
        Me.Label26.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(230, 107)
        Me.Label25.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(12, 15)
        Me.Label25.TabIndex = 83
        Me.Label25.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 87)
        Me.Label11.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Account"
        '
        'LabelProcessId
        '
        Me.LabelProcessId.AutoSize = True
        Me.LabelProcessId.Location = New System.Drawing.Point(32, 163)
        Me.LabelProcessId.Name = "LabelProcessId"
        Me.LabelProcessId.Size = New System.Drawing.Size(89, 15)
        Me.LabelProcessId.TabIndex = 81
        Me.LabelProcessId.Text = "Shipment Date"
        '
        'LabelMandator
        '
        Me.LabelMandator.AutoSize = True
        Me.LabelMandator.Location = New System.Drawing.Point(32, 110)
        Me.LabelMandator.Name = "LabelMandator"
        Me.LabelMandator.Size = New System.Drawing.Size(60, 15)
        Me.LabelMandator.TabIndex = 80
        Me.LabelMandator.Text = "Mandator"
        '
        'MandatorComboBox
        '
        Me.MandatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MandatorComboBox.FormattingEnabled = True
        Me.MandatorComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.MandatorComboBox.Location = New System.Drawing.Point(127, 107)
        Me.MandatorComboBox.Name = "MandatorComboBox"
        Me.MandatorComboBox.Size = New System.Drawing.Size(100, 21)
        Me.MandatorComboBox.TabIndex = 72
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(210, 55)
        Me.Label24.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(12, 15)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(210, 29)
        Me.Label23.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(12, 15)
        Me.Label23.TabIndex = 76
        Me.Label23.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Credentials"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(32, 58)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(61, 15)
        Me.PasswordLabel.TabIndex = 74
        Me.PasswordLabel.Text = "Password"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(32, 32)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(65, 15)
        Me.UsernameLabel.TabIndex = 71
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(107, 55)
        Me.PasswordText.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(100, 20)
        Me.PasswordText.TabIndex = 70
        '
        'UsernameText
        '
        Me.UsernameText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.VB.My.MySettings.Default, "Username", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.UsernameText.Location = New System.Drawing.Point(107, 29)
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.Size = New System.Drawing.Size(100, 20)
        Me.UsernameText.TabIndex = 69
        Me.UsernameText.Text = Global.VB.My.MySettings.Default.Username
        '
        'ShipmentDate
        '
        Me.ShipmentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ShipmentDate.Location = New System.Drawing.Point(127, 163)
        Me.ShipmentDate.Name = "ShipmentDate"
        Me.ShipmentDate.Size = New System.Drawing.Size(100, 20)
        Me.ShipmentDate.TabIndex = 87
        '
        'Shipments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 239)
        Me.Controls.Add(Me.ShipmentDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCustomerId)
        Me.Controls.Add(Me.CustomerId)
        Me.Controls.Add(Me.SendQuery)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabelProcessId)
        Me.Controls.Add(Me.LabelMandator)
        Me.Controls.Add(Me.MandatorComboBox)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UsernameText)
        Me.Name = "Shipments"
        Me.Text = "Shipments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelCustomerId As Label
    Friend WithEvents CustomerId As TextBox
    Friend WithEvents SendQuery As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelProcessId As Label
    Friend WithEvents LabelMandator As Label
    Friend WithEvents MandatorComboBox As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordText As MaskedTextBox
    Friend WithEvents UsernameText As TextBox
    Friend WithEvents ShipmentDate As DateTimePicker
End Class
