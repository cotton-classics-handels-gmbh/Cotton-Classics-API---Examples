
namespace CS
{
    partial class Main
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
            this.ButtonStatus = new System.Windows.Forms.Button();
            this.ButtonOrder = new System.Windows.Forms.Button();
            this.StocksButton = new System.Windows.Forms.Button();
            this.ShipmentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStatus
            // 
            this.ButtonStatus.Location = new System.Drawing.Point(12, 41);
            this.ButtonStatus.Name = "ButtonStatus";
            this.ButtonStatus.Size = new System.Drawing.Size(126, 23);
            this.ButtonStatus.TabIndex = 3;
            this.ButtonStatus.Text = "Request Order Status";
            this.ButtonStatus.UseVisualStyleBackColor = true;
            this.ButtonStatus.Click += new System.EventHandler(this.ButtonStatus_Click);
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.Location = new System.Drawing.Point(12, 12);
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.Size = new System.Drawing.Size(126, 23);
            this.ButtonOrder.TabIndex = 2;
            this.ButtonOrder.Text = "Place an Order";
            this.ButtonOrder.UseVisualStyleBackColor = true;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // StocksButton
            // 
            this.StocksButton.Location = new System.Drawing.Point(12, 70);
            this.StocksButton.Name = "StocksButton";
            this.StocksButton.Size = new System.Drawing.Size(126, 23);
            this.StocksButton.TabIndex = 4;
            this.StocksButton.Text = "Get Stocks";
            this.StocksButton.UseVisualStyleBackColor = true;
            this.StocksButton.Click += new System.EventHandler(this.StocksButton_Click);
            // 
            // ShipmentsButton
            // 
            this.ShipmentsButton.Location = new System.Drawing.Point(12, 99);
            this.ShipmentsButton.Name = "ShipmentsButton";
            this.ShipmentsButton.Size = new System.Drawing.Size(126, 23);
            this.ShipmentsButton.TabIndex = 5;
            this.ShipmentsButton.Text = "Get Shipments";
            this.ShipmentsButton.UseVisualStyleBackColor = true;
            this.ShipmentsButton.Click += new System.EventHandler(this.ShipmentsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 146);
            this.Controls.Add(this.ShipmentsButton);
            this.Controls.Add(this.StocksButton);
            this.Controls.Add(this.ButtonStatus);
            this.Controls.Add(this.ButtonOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button ButtonStatus;
        internal System.Windows.Forms.Button ButtonOrder;
        internal System.Windows.Forms.Button StocksButton;
        internal System.Windows.Forms.Button ShipmentsButton;
    }
}

