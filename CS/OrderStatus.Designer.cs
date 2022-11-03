
namespace CS
{
    partial class OrderStatus
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
            this.SendQuery = new System.Windows.Forms.Button();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.ProcessIdLabel = new System.Windows.Forms.Label();
            this.ProcessIDText = new System.Windows.Forms.TextBox();
            this.LabelMandator = new System.Windows.Forms.Label();
            this.MandatorComboBox = new System.Windows.Forms.ComboBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.MaskedTextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendQuery
            // 
            this.SendQuery.Location = new System.Drawing.Point(147, 197);
            this.SendQuery.Name = "SendQuery";
            this.SendQuery.Size = new System.Drawing.Size(75, 23);
            this.SendQuery.TabIndex = 71;
            this.SendQuery.Text = "Send Query";
            this.SendQuery.UseVisualStyleBackColor = true;
            this.SendQuery.Click += new System.EventHandler(this.SendQuery_Click);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(210, 132);
            this.Label26.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(12, 15);
            this.Label26.TabIndex = 79;
            this.Label26.Text = "*";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(210, 106);
            this.Label25.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(12, 15);
            this.Label25.TabIndex = 78;
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
            this.Label11.TabIndex = 77;
            this.Label11.Text = "Account";
            // 
            // ProcessIdLabel
            // 
            this.ProcessIdLabel.AutoSize = true;
            this.ProcessIdLabel.Location = new System.Drawing.Point(31, 163);
            this.ProcessIdLabel.Name = "ProcessIdLabel";
            this.ProcessIdLabel.Size = new System.Drawing.Size(66, 15);
            this.ProcessIdLabel.TabIndex = 76;
            this.ProcessIdLabel.Text = "Process ID";
            // 
            // ProcessIDText
            // 
            this.ProcessIDText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CS.Properties.Settings.Default, "ProcessID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProcessIDText.Location = new System.Drawing.Point(107, 160);
            this.ProcessIDText.Name = "ProcessIDText";
            this.ProcessIDText.Size = new System.Drawing.Size(100, 20);
            this.ProcessIDText.TabIndex = 70;
            this.ProcessIDText.Text = global::CS.Properties.Settings.Default.ProcessID;
            // 
            // LabelMandator
            // 
            this.LabelMandator.AutoSize = true;
            this.LabelMandator.Location = new System.Drawing.Point(32, 110);
            this.LabelMandator.Name = "LabelMandator";
            this.LabelMandator.Size = new System.Drawing.Size(60, 15);
            this.LabelMandator.TabIndex = 74;
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
            this.MandatorComboBox.Location = new System.Drawing.Point(107, 107);
            this.MandatorComboBox.Name = "MandatorComboBox";
            this.MandatorComboBox.Size = new System.Drawing.Size(100, 21);
            this.MandatorComboBox.TabIndex = 68;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(210, 55);
            this.Label24.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(12, 15);
            this.Label24.TabIndex = 72;
            this.Label24.Text = "*";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(210, 29);
            this.Label23.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(12, 15);
            this.Label23.TabIndex = 71;
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
            this.Label10.TabIndex = 70;
            this.Label10.Text = "Credentials";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(32, 58);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 15);
            this.PasswordLabel.TabIndex = 69;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(32, 32);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(65, 15);
            this.UsernameLabel.TabIndex = 68;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(107, 55);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 67;
            // 
            // UsernameText
            // 
            this.UsernameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CS.Properties.Settings.Default, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsernameText.Location = new System.Drawing.Point(107, 29);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(100, 20);
            this.UsernameText.TabIndex = 66;
            this.UsernameText.Text = global::CS.Properties.Settings.Default.Username;
            // 
            // CustomerId
            // 
            this.CustomerId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CS.Properties.Settings.Default, "AccountNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CustomerId.Location = new System.Drawing.Point(107, 134);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(100, 20);
            this.CustomerId.TabIndex = 69;
            this.CustomerId.Text = global::CS.Properties.Settings.Default.AccountNo;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(32, 137);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(75, 15);
            this.CustomerIDLabel.TabIndex = 82;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 83;
            this.label3.Text = "*";
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.SendQuery);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.ProcessIdLabel);
            this.Controls.Add(this.ProcessIDText);
            this.Controls.Add(this.LabelMandator);
            this.Controls.Add(this.MandatorComboBox);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UsernameText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderStatus";
            this.Text = "OrderStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderStatus_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button SendQuery;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label ProcessIdLabel;
        internal System.Windows.Forms.TextBox ProcessIDText;
        internal System.Windows.Forms.Label LabelMandator;
        internal System.Windows.Forms.ComboBox MandatorComboBox;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.MaskedTextBox PasswordText;
        internal System.Windows.Forms.TextBox UsernameText;
        internal System.Windows.Forms.TextBox CustomerId;
        internal System.Windows.Forms.Label CustomerIDLabel;
        internal System.Windows.Forms.Label label3;
    }
}