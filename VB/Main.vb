Public Class Main
    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        Dim form As New Order
        form.Show()
    End Sub

    Private Sub ButtonStatus_Click(sender As Object, e As EventArgs) Handles ButtonStatus.Click
        Dim form As New OrderStatus
        form.Show()
    End Sub

    Private Sub ButtonStocks_Click(sender As Object, e As EventArgs) Handles ButtonStocks.Click
        Dim form As New Stock
        form.Show()
    End Sub

    Private Sub ShipmentsButton_Click(sender As Object, e As EventArgs) Handles ShipmentsButton.Click
        Dim form As New Shipments
        form.Show()

    End Sub
End Class