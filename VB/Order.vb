Public Class Order
    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click

        Try
            'Generation the request Data trough the help
            'of the CC.CustomerAPIData assembly
            Dim requestObject = GenerateRequest()

            'Converting the computed JSON to a Byte
            'array.
            Dim requestStream As Byte() = System.Text.Encoding.UTF8.GetBytes(requestObject.GetJSON)


            'Setting up the Credidentials for the Server
            Dim credidentials As New Net.CredentialCache From {
                {New Uri(My.Settings.ApiUrl), "Basic", New Net.NetworkCredential(UsernameText.Text,
                                                                                 PasswordText.Text)}
            }

            'Setting up the Web Request
            Dim webRequest = Net.WebRequest.CreateHttp(My.Settings.ApiUrl)
            With webRequest
                .Method = "POST"
                .Accept = "*/*"
                .Headers.Add("Accept-Language", "de-DE")
                .ContentType = "application/json"
                .ContentLength = requestStream.Length
                .Headers.Add("Accept-Encoding", "gzip, deflate")
                .Headers.Add("Pragma", "no-cache")
                .UserAgent = "Order Test App"
                .ServicePoint.Expect100Continue = False
                .Credentials = credidentials
            End With

            'Sending Data from the Request Stream
            Dim httpStream = webRequest.GetRequestStream()
            httpStream.Write(requestStream, 0, requestStream.Length)
            httpStream.Close()

            'Parsing the Response
            Dim response = webRequest.GetResponse

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub JSONButton_Click(sender As Object, e As EventArgs) Handles JSONButton.Click

        Try
            Dim request = GenerateRequest()
            Dim json = request.GetJSON

            Dim form As New JsonPreview(json)

            form.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function GenerateRequest() As CC.CustomerAPIData.Order.OrderRequest


        Dim request As New CC.CustomerAPIData.Order.OrderRequest

        With request
            'Account
            .Mandator = MandatorComboBox.SelectedItem
            .CustomerID = AccountNoText.Text

            'Purchaser Information
            If GenderComboBox.SelectedItem IsNot Nothing Then
                .OrderedByGender = Split(GenderComboBox.SelectedItem, "-")(0)
            End If

            .OrderedByFirstname = FirstNameText.Text
            .OrderedByLastname = LastNameText.Text
            .ConsultationPhone = PhoneText.Text
            .ConsultationMail = MailText.Text

            'Delivery Information
            .DeliverySalutation = SaultationText.Text
            .DeliveryAddressLine1 = Address1Text.Text
            .DeliveryAddressLine2 = Address2Text.Text
            .DeliveryAddressSupplementary = SupplementaryText.Text
            .DeliveryStreet = StreetText.Text
            .DeliveryPostcode = ZipText.Text
            .DeliveryCity = CityText.Text
            .DeliveryCountry = CountryText.Text

            'Additional Information
            .Commission = ComissionText.Text
            .YourReference = ReferenceText.Text
            .Comment = CommentText.Text
        End With

        'Process SKU Listbox
        Dim o = ArticlesTextBox.Lines

        For i = 0 To UBound(o)
            Dim l = o(i).Split(";")

            request.AddPosition(l(0), l(1))
        Next

        Return request

    End Function


End Class
