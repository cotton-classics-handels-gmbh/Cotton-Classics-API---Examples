namespace CS
{
    partial class Shipments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelCustomerId = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.SendQuery = new System.Windows.Forms.Button();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.LabelProcessId = new System.Windows.Forms.Label();
            this.LabelMandator = new System.Windows.Forms.Label();
            this.MandatorComboBox = new System.Windows.Forms.ComboBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.MaskedTextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShipmentDate
            // 
            this.ShipmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ShipmentDate.Location = new System.Drawing.Point(127, 163);
            this.ShipmentDate.Name = "ShipmentDate";
            this.ShipmentDate.Size = new System.Drawing.Size(100, 20);
            this.ShipmentDate.TabIndex = 105;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(230, 163);
            this.Label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(12, 15);
            this.Label1.TabIndex = 104;
            this.Label1.Text = "*";
            // 
            // LabelCustomerId
            // 
            this.LabelCustomerId.AutoSize = true;
            this.LabelCustomerId.Location = new System.Drawing.Point(32, 137);
            this.LabelCustomerId.Name = "LabelCustomerId";
            this.LabelCustomerId.Size = new System.Drawing.Size(75, 15);
            this.LabelCustomerId.TabIndex = 103;
            this.LabelCustomerId.Text = "Customer ID";
            // 
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(127, 134);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(100, 20);
            this.CustomerId.TabIndex = 92;
            // 
            // SendQuery
            // 
            this.SendQuery.Location = new System.Drawing.Point(167, 204);
            this.SendQuery.Name = "SendQuery";
            this.SendQuery.Size = new System.Drawing.Size(75, 23);
            this.SendQuery.TabIndex = 97;
            this.SendQuery.Text = "Send Query";
            this.SendQuery.UseVisualStyleBackColor = true;
            this.SendQuery.Click += new System.EventHandler(this.SendQuery_Click);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(230, 134);
            this.Label26.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(12, 15);
            this.Label26.TabIndex = 102;
            this.Label26.Text = "*";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(230, 107);
            this.Label25.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(12, 15);
            this.Label25.TabIndex = 101;
            this.Label25.Text = "*";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(12, 87);
            this.Label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(77, 20);
            this.Label11.TabIndex = 100;
            this.Label11.Text = "Account";
            // 
            // LabelProcessId
            // 
            this.LabelProcessId.AutoSize = true;
            this.LabelProcessId.Location = new System.Drawing.Point(32, 163);
            this.LabelProcessId.Name = "LabelProcessId";
            this.LabelProcessId.Size = new System.Drawing.Size(89, 15);
            this.LabelProcessId.TabIndex = 99;
            this.LabelProcessId.Text = "Shipment Date";
            // 
            // LabelMandator
            // 
            this.LabelMandator.AutoSize = true;
            this.LabelMandator.Location = new System.Drawing.Point(32, 110);
            this.LabelMandator.Name = "LabelMandator";
            this.LabelMandator.Size = new System.Drawing.Size(60, 15);
            this.LabelMandator.TabIndex = 98;
            this.LabelMandator.Text = "Mandator";
            // 
            // MandatorComboBox
            // 
            this.MandatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MandatorComboBox.FormattingEnabled = true;
            this.MandatorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.MandatorComboBox.Location = new System.Drawing.Point(127, 107);
            this.MandatorComboBox.Name = "MandatorComboBox";
            this.MandatorComboBox.Size = new System.Drawing.Size(100, 21);
            this.MandatorComboBox.TabIndex = 91;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(210, 55);
            this.Label24.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(12, 15);
            this.Label24.TabIndex = 96;
            this.Label24.Text = "*";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(210, 29);
            this.Label23.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(12, 15);
            this.Label23.TabIndex = 95;
            this.Label23.Text = "*";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(12, 9);
            this.Label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(105, 20);
            this.Label10.TabIndex = 94;
            this.Label10.Text = "Credentials";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(32, 58);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 15);
            this.PasswordLabel.TabIndex = 93;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(32, 32);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(65, 15);
            this.UsernameLabel.TabIndex = 90;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(107, 55);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 89;
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(107, 29);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(100, 20);
            this.UsernameText.TabIndex = 88;
            // 
            // Shipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 240);
            this.Controls.Add(this.ShipmentDate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelCustomerId);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.SendQuery);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.LabelProcessId);
            this.Controls.Add(this.LabelMandator);
            this.Controls.Add(this.MandatorComboBox);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.Name = "Shipments";
            this.Text = "Shipments";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shipments_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker ShipmentDate;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabelCustomerId;
        internal System.Windows.Forms.TextBox CustomerId;
        internal System.Windows.Forms.Button SendQuery;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label LabelProcessId;
        internal System.Windows.Forms.Label LabelMandator;
        internal System.Windows.Forms.ComboBox MandatorComboBox;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.MaskedTextBox PasswordText;
        internal System.Windows.Forms.TextBox UsernameText;
    }
}