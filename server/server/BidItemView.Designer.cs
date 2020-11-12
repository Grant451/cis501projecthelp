namespace server
{
    partial class ServerForm
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lstclients = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 31;
            this.lstItems.Location = new System.Drawing.Point(12, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(371, 717);
            this.lstItems.TabIndex = 0;
            // 
            // lstclients
            // 
            this.lstclients.FormattingEnabled = true;
            this.lstclients.ItemHeight = 31;
            this.lstclients.Location = new System.Drawing.Point(389, 12);
            this.lstclients.Name = "lstclients";
            this.lstclients.Size = new System.Drawing.Size(371, 717);
            this.lstclients.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 759);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 99);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 925);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstclients);
            this.Controls.Add(this.lstItems);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.ListBox lstclients;
        private System.Windows.Forms.Button button1;
    }
}

