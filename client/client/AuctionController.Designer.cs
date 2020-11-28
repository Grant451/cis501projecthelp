namespace client
{
    partial class AuctionController
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
            this.txtdemosend = new System.Windows.Forms.Button();
            this.txtdemomessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtdemosend
            // 
            this.txtdemosend.Location = new System.Drawing.Point(345, 264);
            this.txtdemosend.Name = "txtdemosend";
            this.txtdemosend.Size = new System.Drawing.Size(321, 94);
            this.txtdemosend.TabIndex = 0;
            this.txtdemosend.Text = "demo send message";
            this.txtdemosend.UseVisualStyleBackColor = true;
            this.txtdemosend.Click += new System.EventHandler(this.txtdemosend_Click);
            // 
            // txtdemomessage
            // 
            this.txtdemomessage.Location = new System.Drawing.Point(335, 132);
            this.txtdemomessage.Name = "txtdemomessage";
            this.txtdemomessage.Size = new System.Drawing.Size(346, 38);
            this.txtdemomessage.TabIndex = 1;
            // 
            // AuctionController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdemomessage);
            this.Controls.Add(this.txtdemosend);
            this.Name = "AuctionController";
            this.Text = "AuctionController";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtdemosend;
        private System.Windows.Forms.TextBox txtdemomessage;
    }
}

