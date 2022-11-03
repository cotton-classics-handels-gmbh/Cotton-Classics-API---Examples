<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.ButtonOrder = New System.Windows.Forms.Button()
        Me.ButtonStatus = New System.Windows.Forms.Button()
        Me.ButtonStocks = New System.Windows.Forms.Button()
        Me.ShipmentsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonOrder
        '
        Me.ButtonOrder.Location = New System.Drawing.Point(12, 12)
        Me.ButtonOrder.Name = "ButtonOrder"
        Me.ButtonOrder.Size = New System.Drawing.Size(126, 23)
        Me.ButtonOrder.TabIndex = 0
        Me.ButtonOrder.Text = "Place an Order"
        Me.ButtonOrder.UseVisualStyleBackColor = True
        '
        'ButtonStatus
        '
        Me.ButtonStatus.Location = New System.Drawing.Point(12, 41)
        Me.ButtonStatus.Name = "ButtonStatus"
        Me.ButtonStatus.Size = New System.Drawing.Size(126, 23)
        Me.ButtonStatus.TabIndex = 1
        Me.ButtonStatus.Text = "Request Order Status"
        Me.ButtonStatus.UseVisualStyleBackColor = True
        '
        'ButtonStocks
        '
        Me.ButtonStocks.Location = New System.Drawing.Point(12, 70)
        Me.ButtonStocks.Name = "ButtonStocks"
        Me.ButtonStocks.Size = New System.Drawing.Size(126, 23)
        Me.ButtonStocks.TabIndex = 2
        Me.ButtonStocks.Text = "Get Stocks"
        Me.ButtonStocks.UseVisualStyleBackColor = True
        '
        'ShipmentsButton
        '
        Me.ShipmentsButton.Location = New System.Drawing.Point(12, 99)
        Me.ShipmentsButton.Name = "ShipmentsButton"
        Me.ShipmentsButton.Size = New System.Drawing.Size(126, 23)
        Me.ShipmentsButton.TabIndex = 3
        Me.ShipmentsButton.Text = "Get Shipments"
        Me.ShipmentsButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(157, 138)
        Me.Controls.Add(Me.ShipmentsButton)
        Me.Controls.Add(Me.ButtonStocks)
        Me.Controls.Add(Me.ButtonStatus)
        Me.Controls.Add(Me.ButtonOrder)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonOrder As Button
    Friend WithEvents ButtonStatus As Button
    Friend WithEvents ButtonStocks As Button
    Friend WithEvents ShipmentsButton As Button
End Class
