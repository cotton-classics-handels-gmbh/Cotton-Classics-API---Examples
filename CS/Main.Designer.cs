
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 118);
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
    }
}

