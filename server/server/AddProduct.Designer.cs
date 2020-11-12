namespace server
{
    partial class AddProduct
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
            this.lstproduct = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstproduct
            // 
            this.lstproduct.FormattingEnabled = true;
            this.lstproduct.ItemHeight = 31;
            this.lstproduct.Location = new System.Drawing.Point(12, 12);
            this.lstproduct.Name = "lstproduct";
            this.lstproduct.Size = new System.Drawing.Size(492, 686);
            this.lstproduct.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 743);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 86);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 874);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstproduct);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstproduct;
        private System.Windows.Forms.Button btnAdd;
    }
}