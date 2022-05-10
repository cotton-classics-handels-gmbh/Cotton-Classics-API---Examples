Imports System.IO
Imports System.Web

Public Class OrderStatus

    Private Const apiUrl As String = "https://api.cottonclassics.com/api/Order"

    Private Sub SendQuery_Click(sender As Object, e As EventArgs) Handles SendQuery.Click

        Try
            'Setting up the Credidentials for the Server
            Dim credidentials As New Net.CredentialCache From {
                    {New Uri(apiUrl), "Basic", New Net.NetworkCredential(UsernameText.Text,
                                                                                     PasswordText.Text)}
                }

            'Setting up the Web Request
            Dim builder As New UriBuilder(apiUrl)

            'Appending Parameters
            Dim query = HttpUtility.ParseQueryString(builder.Query)
            query.Add("Mandator", MandatorComboBox.SelectedItem)
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

            Dim response = webRequest.GetResponse()


            If response.ContentType = "application/json" Then
                'We read the Response to an memory stream..
                Dim stream = response.GetResponseStream

                Dim reader As New StreamReader(stream)
                Dim responseData = reader.ReadToEnd

                '.. and display the results in another form
                Dim form As New JsonPreview(responseData)
                form.Show()
            Else
                response.Close()
                Throw New Exception("Unexpected Response Content: " & response.ContentType)
            End If

            response.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class