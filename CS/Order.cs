using CC.CustomerAPIData.Order;
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
using System.Windows.Forms;

namespace CS
{
    public partial class Order : Form
    {

        private const string apiURL = "https://api.cottonclassics.com/api/Order";

        public Order()
        {
            InitializeComponent();
        }




        private void JSONButton_Click(object sender, EventArgs e)
        {
            try
            {
                var request = GenerateRequest();
                var json = request.GetJSON(Formatting.Indented);

                JsonPreview form = new JsonPreview(json);

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Generation the request Data trough the help
                // of the CC.CustomerAPIData assembly
                var orderRequest = GenerateRequest();

                // Setting up the Credidentials for the Server
                CredentialCache credidentials = new CredentialCache()
            {
                {
                    new Uri(apiURL),
                    "Basic",
                    new NetworkCredential(UsernameText.Text, PasswordText.Text)
                }
            };

                // Converting the computed JSON to a Byte array.
                byte[] requestStream = Encoding.UTF8.GetBytes(orderRequest.GetJSON(Formatting.None));

                // Setting up the Web Request
                var webRequest = System.Net.WebRequest.CreateHttp(apiURL);
                {
                    var withBlock = webRequest;
                    withBlock.Method = "POST";

                    withBlock.ContentType = "application/json";
                    withBlock.ContentLength = requestStream.Length;
                    withBlock.UserAgent = "Order Test App";
                    withBlock.ServicePoint.Expect100Continue = false;
                    withBlock.Credentials = credidentials;
                }

                // Sending Data from the Request Stream
                var httpStream = webRequest.GetRequestStream();
                httpStream.Write(requestStream, 0, requestStream.Length);
                httpStream.Close();

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
                        var result = JsonConvert.DeserializeObject(responseString, typeof(OrderResponse));

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

        private OrderRequest GenerateRequest()
        {
            OrderRequest request = new OrderRequest();

            {
                var withBlock = request;
                // Account
                withBlock.Mandator = short.Parse((string)MandatorComboBox.SelectedItem);
                withBlock.CustomerID = AccountNoText.Text;

                // Purchaser Information
                if (GenderComboBox.SelectedItem != null)
                    withBlock.OrderedByGender = (CC.CustomerAPIData.SharedConstants.Genders)GenderComboBox.SelectedIndex;

                withBlock.OrderedByFirstname = FirstNameText.Text;
                withBlock.OrderedByLastname = LastNameText.Text;
                withBlock.ConsultationPhone = PhoneText.Text;
                withBlock.ConsultationMail = MailText.Text;

                // Delivery Information
                withBlock.DeliverySalutation = SaultationText.Text;
                withBlock.DeliveryAddressLine1 = Address1Text.Text;
                withBlock.DeliveryAddressLine2 = Address2Text.Text;
                withBlock.DeliveryAddressSupplementary = SupplementaryText.Text;
                withBlock.DeliveryStreet = StreetText.Text;
                withBlock.DeliveryPostcode = ZipText.Text;
                withBlock.DeliveryCity = CityText.Text;
                withBlock.DeliveryCountry = CountryText.Text;

                // Additional Information
                withBlock.Commission = ComissionText.Text;
                withBlock.YourReference = ReferenceText.Text;
                withBlock.Comment = CommentText.Text;
            }

            // Process SKU Listbox
            var o = ArticlesTextBox.Lines;

            for (var i = 0; i <= o.Length-1; i++)
            {
                var l = o[i].Split(';');

                request.AddPosition(l[0], Int32.Parse(l[1]));
            }

            return request;
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
