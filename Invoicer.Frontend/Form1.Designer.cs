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
            this.ProductButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.listProductButton = new System.Windows.Forms.Button();
            this.addCompaniesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(45, 28);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(179, 55);
            this.ProductButton.TabIndex = 0;
            this.ProductButton.Text = "Dodaj Produkt";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(45, 323);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(179, 69);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Wyjdz";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listProductButton
            // 
            this.listProductButton.Location = new System.Drawing.Point(45, 89);
            this.listProductButton.Name = "listProductButton";
            this.listProductButton.Size = new System.Drawing.Size(179, 60);
            this.listProductButton.TabIndex = 2;
            this.listProductButton.Text = "Lista Produktow";
            this.listProductButton.UseVisualStyleBackColor = true;
            this.listProductButton.Click += new System.EventHandler(this.listProductButton_Click);
            // 
            // addCompaniesButton
            // 
            this.addCompaniesButton.Location = new System.Drawing.Point(45, 155);
            this.addCompaniesButton.Name = "addCompaniesButton";
            this.addCompaniesButton.Size = new System.Drawing.Size(179, 64);
            this.addCompaniesButton.TabIndex = 3;
            this.addCompaniesButton.Text = "Dodaj Firme";
            this.addCompaniesButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 416);
            this.Controls.Add(this.addCompaniesButton);
            this.Controls.Add(this.listProductButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.ProductButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button listProductButton;
        private System.Windows.Forms.Button addCompaniesButton;
    }
}

