namespace Invoicer.Frontend
{
    partial class CreatInvoiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.receiverListBox = new System.Windows.Forms.ListBox();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.creatBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nrInvoiceTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.addedListBox = new System.Windows.Forms.ListBox();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receiver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nr Invoice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of issue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Products";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(643, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Added";
            // 
            // receiverListBox
            // 
            this.receiverListBox.FormattingEnabled = true;
            this.receiverListBox.ItemHeight = 16;
            this.receiverListBox.Location = new System.Drawing.Point(339, 61);
            this.receiverListBox.Name = "receiverListBox";
            this.receiverListBox.Size = new System.Drawing.Size(218, 100);
            this.receiverListBox.TabIndex = 9;
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 16;
            this.productListBox.Location = new System.Drawing.Point(80, 299);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(236, 100);
            this.productListBox.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(496, 300);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(84, 22);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // creatBtn
            // 
            this.creatBtn.Location = new System.Drawing.Point(805, 470);
            this.creatBtn.Name = "creatBtn";
            this.creatBtn.Size = new System.Drawing.Size(75, 23);
            this.creatBtn.TabIndex = 13;
            this.creatBtn.Text = "Creat";
            this.creatBtn.UseVisualStyleBackColor = true;
            this.creatBtn.Click += new System.EventHandler(this.creatBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(886, 470);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(761, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // nrInvoiceTextBox
            // 
            this.nrInvoiceTextBox.Location = new System.Drawing.Point(761, 61);
            this.nrInvoiceTextBox.Name = "nrInvoiceTextBox";
            this.nrInvoiceTextBox.Size = new System.Drawing.Size(200, 22);
            this.nrInvoiceTextBox.TabIndex = 16;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(406, 299);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(84, 22);
            this.amountTextBox.TabIndex = 18;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(761, 89);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(200, 22);
            this.dateTextBox.TabIndex = 19;
            // 
            // addedListBox
            // 
            this.addedListBox.FormattingEnabled = true;
            this.addedListBox.ItemHeight = 16;
            this.addedListBox.Location = new System.Drawing.Point(646, 300);
            this.addedListBox.Name = "addedListBox";
            this.addedListBox.Size = new System.Drawing.Size(315, 100);
            this.addedListBox.TabIndex = 20;
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 16;
            this.vendorListBox.Location = new System.Drawing.Point(80, 61);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(236, 100);
            this.vendorListBox.TabIndex = 21;
            // 
            // CreatInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 553);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.addedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiverListBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nrInvoiceTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.creatBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CreatInvoiceForm";
            this.Text = "CreatInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox receiverListBox;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button creatBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox nrInvoiceTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.ListBox addedListBox;
        private System.Windows.Forms.ListBox vendorListBox;
    }
}