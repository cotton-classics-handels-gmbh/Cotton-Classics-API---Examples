Imports System.IO
Imports System.Net
Imports System.Web
Imports Newtonsoft.Json

Public Class OrderStatus

    Private Const apiUrl As String = "https://api.cottonclassics.com/api/Order"

    Private Sub SendQuery_Click(sender As Object, e As EventArgs) Handles SendQuery.Click

        Try
            'Setting up the Credidentials for the Server
            Dim credidentials As New Net.CredentialCache From {
                    {New Uri(apiUrl), "Basic", New NetworkCredential(UsernameText.Text,
                                                                     PasswordText.Text)}
                }

            'Setting up the Web Request
            Dim builder As New UriBuilder(apiUrl)

            'Appending required Parameters
            Dim query = HttpUtility.ParseQueryString(builder.Query)
            query.Add("Mandator", MandatorComboBox.SelectedItem)
            query.Add("CustomerID", CustomerId.Text)
            query.Add("ProcessID", ProcessIDText.Text)

            'Adding the Query Parameters to the URI Object
            builder.Query = query.ToString

            'Creating the Request-Object
            Dim webRequest = Net.WebRequest.CreateHttp(builder.Uri)
            With webRequest
                .Method = "GET"

                .Accept = "*/*"
                .UserAgent = "Order Test App"
                .ServicePoint.Expect100Continue = False
                .Credentials = credidentials
            End With


            'Requesting the Response from the Server
            Using httpResponse As HttpWebResponse = webRequest.GetResponse()
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
                    Dim result = JsonConvert.DeserializeObject(responseString, GetType(OrderStatus))

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

    Private Sub OrderStatus_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
    End Sub
End Class