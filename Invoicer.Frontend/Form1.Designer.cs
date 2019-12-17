namespace Invoicer.Frontend
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.listProductButton = new System.Windows.Forms.Button();
            this.companiesButton = new System.Windows.Forms.Button();
            this.creatInvoiceBtn = new System.Windows.Forms.Button();
            this.invoicesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(45, 323);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(179, 69);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listProductButton
            // 
            this.listProductButton.Location = new System.Drawing.Point(45, 12);
            this.listProductButton.Name = "listProductButton";
            this.listProductButton.Size = new System.Drawing.Size(179, 60);
            this.listProductButton.TabIndex = 2;
            this.listProductButton.Text = "Product";
            this.listProductButton.UseVisualStyleBackColor = true;
            this.listProductButton.Click += new System.EventHandler(this.listProductButton_Click);
            // 
            // companiesButton
            // 
            this.companiesButton.Location = new System.Drawing.Point(45, 78);
            this.companiesButton.Name = "companiesButton";
            this.companiesButton.Size = new System.Drawing.Size(179, 64);
            this.companiesButton.TabIndex = 3;
            this.companiesButton.Text = "Companies";
            this.companiesButton.UseVisualStyleBackColor = true;
            this.companiesButton.Click += new System.EventHandler(this.companiesButton_Click);
            // 
            // creatInvoiceBtn
            // 
            this.creatInvoiceBtn.Location = new System.Drawing.Point(45, 149);
            this.creatInvoiceBtn.Name = "creatInvoiceBtn";
            this.creatInvoiceBtn.Size = new System.Drawing.Size(179, 69);
            this.creatInvoiceBtn.TabIndex = 4;
            this.creatInvoiceBtn.Text = "Creat Invoice";
            this.creatInvoiceBtn.UseVisualStyleBackColor = true;
            this.creatInvoiceBtn.Click += new System.EventHandler(this.creatInvoiceBtn_Click);
            // 
            // invoicesBtn
            // 
            this.invoicesBtn.Location = new System.Drawing.Point(45, 224);
            this.invoicesBtn.Name = "invoicesBtn";
            this.invoicesBtn.Size = new System.Drawing.Size(179, 72);
            this.invoicesBtn.TabIndex = 5;
            this.invoicesBtn.Text = "Invoices";
            this.invoicesBtn.UseVisualStyleBackColor = true;
            this.invoicesBtn.Click += new System.EventHandler(this.invoicesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 416);
            this.Controls.Add(this.invoicesBtn);
            this.Controls.Add(this.creatInvoiceBtn);
            this.Controls.Add(this.companiesButton);
            this.Controls.Add(this.listProductButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button listProductButton;
        private System.Windows.Forms.Button companiesButton;
        private System.Windows.Forms.Button creatInvoiceBtn;
        private System.Windows.Forms.Button invoicesBtn;
    }
}

