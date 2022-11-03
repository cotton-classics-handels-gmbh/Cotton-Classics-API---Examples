using CC.CustomerAPIData.Shipments;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CS
{
    public partial class Shipments : Form
    {
        private const string apiUrl = "https://api.cottonclassics.com/api/Shipments";

        public Shipments()
        {
            InitializeComponent();
        }

        private void SendQuery_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        // Setting up the Credidentials for the Server
                        System.Net.CredentialCache credidentials = new System.Net.CredentialCache()
            {
                {
                    new Uri(apiUrl),
                    "Basic",
                    new NetworkCredential(UsernameText.Text, PasswordText.Text)
                }
            };

                        // Setting up the Web Request
                        UriBuilder builder = new UriBuilder(apiUrl);

                        // Appending required Parameters
                        var query = HttpUtility.ParseQueryString(builder.Query);
                        query.Add("Mandator", (string)MandatorComboBox.SelectedItem);
                        query.Add("CustomerID", (string)CustomerId.Text);
                        query.Add("QueryDate", ShipmentDate.Value.ToString("MM-dd-yyyy"));

                        // Adding the Query Parameters to the URI Object
                        builder.Query = query.ToString();

                        // Creating the Request-Object
                        var webRequest = WebRequest.CreateHttp(builder.Uri);
                        {
                            var withBlock = webRequest;
                            withBlock.Method = "GET";

                            withBlock.Accept = "*/*";
                            withBlock.UserAgent = "Order Test App";
                            withBlock.ServicePoint.Expect100Continue = false;
                            withBlock.Credentials = credidentials;
                        }


                        // Requesting the Response from the Server
                        using (HttpWebResponse httpResponse = (HttpWebResponse)webRequest.GetResponse())
                        {
                            // We read the received Response with the help of  an memory stream
                            // to a string
                            var responseStream = httpResponse.GetResponseStream();
                            StreamReader reader = new StreamReader(responseStream);
                            var responseString = reader.ReadToEnd();


                            // If the Status equals 200 - and the content type is JSON
                            // we should have correct response data at hand
                            if (httpResponse.ContentType == "application/json" & httpResponse.StatusCode == HttpStatusCode.OK)
                            {

                                // If you want to use our helper assembly you may now try to desialize it
                                // using newtonsoft JSON:
                                var result = JsonConvert.DeserializeObject(responseString, typeof(ShipmentResponse));

                                // .. but for this example we will just display the JSON Raw Data in another Form
                                JsonPreview form = new JsonPreview(responseString);
                                form.Show();
                            }
                            else
                                // If somethings fishy we throw an rather generic exception..
                                throw new Exception(string.Format("Invalid Data, Content: {0}, StatusCode: {1}", httpResponse.ContentType, httpResponse.StatusCode));
                        }
                    }
                    catch (WebException exWeb)
                    {
                        // in case we are receiving an web exception with an
                        // application/json content we can expect an detailed
                        // errormessage from the webserver
                        if (exWeb.Response != null && exWeb.Response.ContentType == "application/json")
                        {
                            var stream = exWeb.Response.GetResponseStream();
                            StreamReader reader = new StreamReader(stream);
                            var responseData = reader.ReadToEnd();

                            // Again: You may use our helper assembly against
                            // the returned data
                            var result = JsonConvert.DeserializeObject(responseData, typeof(CC.CustomerAPIData.ErrorResponse));

                            // .. or just use the String
                            JsonPreview form = new JsonPreview(responseData);
                            form.Show();
                        }
                        else
                            // All regular Webexceptions will be displayed in
                            // an MessageBox
                            MessageBox.Show(exWeb.Message);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Shipments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
