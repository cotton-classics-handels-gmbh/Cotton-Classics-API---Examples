Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports CC.CustomerAPIData.Order

Public Class Order

    Private Const apiURL As String = "https://api.cottonclassics.com/api/Order"

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click

        Try
            'Generation the request Data trough the help
            'of the CC.CustomerAPIData assembly
            Dim orderRequest = GenerateRequest()

            'Setting up the Credidentials for the Server
            Dim credidentials As New CredentialCache From {
                {New Uri(apiURL), "Basic", New NetworkCredential(UsernameText.Text,
                                                                 PasswordText.Text)}
            }

            'Converting the computed JSON to a Byte array.
            Dim requestStream As Byte() = System.Text.Encoding.UTF8.GetBytes(orderRequest.GetJSON(Formatting.None))

            'Setting up the Web Request
            Dim webRequest = Net.WebRequest.CreateHttp(apiURL)
            With webRequest
                .Method = "POST"

                .ContentType = "application/json"
                .ContentLength = requestStream.Length
                .UserAgent = "Order Test App"
                .ServicePoint.Expect100Continue = False
                .Credentials = credidentials
            End With

            'Sending Data from the Request Stream
            Dim httpStream = webRequest.GetRequestStream()
            httpStream.Write(requestStream, 0, requestStream.Length)
            httpStream.Close()

            'Requesting the Response from the Server
            Using httpResponse As HttpWebResponse = webRequest.GetResponse
                'We read the received Response with the help of  an memory stream
                'to a string
                Dim responseStream = httpResponse.GetResponseStream
                Dim reader As New StreamReader(responseStream)
                Dim responseString = reader.ReadToEnd

                'If the Status equals 200 - and the content type is JSON
                'we should have correct response data at hand
                If httpResponse.ContentType = "application/json" And
                    httpResponse.StatusCode = HttpStatusCode.OK Then

                    'If you want to use our helper assembly you may now try to desialize it
                    'using newtonsoft JSON:
                    Dim result = JsonConvert.DeserializeObject(responseString, GetType(OrderResponse))

                    '.. but for this example we will just display the JSON Raw Data in another Form
                    Dim form As New JsonPreview(responseString)
                    form.Show()
                Else
                    'If somethings fishy we throw an rather generic exception..
                    Throw New Exception(String.Format("Invalid Data, Content: {0}, StatusCode: {1}",
                                                      httpResponse.ContentType, httpResponse.StatusCode))
                End If
            End Using

        Catch exWeb As WebException
            'in case we are receiving an web exception with an
            'application/json content we can expect an detailed
            'errormessage from the webserver
            If exWeb.Response IsNot Nothing AndAlso
                exWeb.Response.ContentType = "application/json" Then

                Dim stream = exWeb.Response.GetResponseStream
                Dim reader As New StreamReader(stream)
                Dim responseData = reader.ReadToEnd

                'Again: You may use our helper assembly against
                'the returned data
                Dim result = JsonConvert.DeserializeObject(responseData, GetType(CC.CustomerAPIData.ErrorResponse))

                '.. or just use the String
                Dim form As New JsonPreview(responseData)
                form.Show()
            Else
                'All regular Webexceptions will be displayed in
                'an MessageBox
                MsgBox(exWeb.Message)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub JSONButton_Click(sender As Object, e As EventArgs) Handles JSONButton.Click

        Try
            Dim request = GenerateRequest()
            Dim json = request.GetJSON(Formatting.Indented)

            Dim form As New JsonPreview(json)

            form.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function GenerateRequest() As OrderRequest

        Dim request As New OrderRequest

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

    Private Sub Order_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub
End Class
