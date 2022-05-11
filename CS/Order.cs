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

        private const string apiURL = "https://localhost:44339/api/Order";

        public Order()
        {
            InitializeComponent();
        }

        private void JSONButton_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private OrderRequest GenerateRequest()
        {
            OrderRequest request = new OrderRequest();

            {
                var withBlock = request;
                // Account
                withBlock.Mandator = (short)MandatorComboBox.SelectedItem;
                withBlock.CustomerID = AccountNoText.Text;

                // Purchaser Information
                if (GenderComboBox.SelectedItem != null)
                    withBlock.OrderedByGender = (CC.CustomerAPIData.SharedConstants.Genders)GenderComboBox.SelectedItem;

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

            for (var i = 0; i <= o.Length; i++)
            {
                var l = o[i].Split(';');

                request.AddPosition(l[0], Int32.Parse(l[1]));
            }

            return request;
        }


    }
}
