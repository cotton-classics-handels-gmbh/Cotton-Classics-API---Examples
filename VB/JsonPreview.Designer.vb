<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JsonPreview
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
        Me.ResultText = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultText
        '
        Me.ResultText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultText.Location = New System.Drawing.Point(12, 12)
        Me.ResultText.Multiline = True
        Me.ResultText.Name = "ResultText"
        Me.ResultText.ReadOnly = True
        Me.ResultText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ResultText.Size = New System.Drawing.Size(776, 401)
        Me.ResultText.TabIndex = 0
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(713, 419)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'JsonPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ResultText)
        Me.MinimizeBox = False
        Me.Name = "JsonPreview"
        Me.Text = "Json Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResultText As TextBox
    Friend WithEvents ButtonClose As Button
End Class
