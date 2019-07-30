namespace Invoicer.Frontend
{
    partial class CompaniesForm
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
            this.nameCompaniesTextBox = new System.Windows.Forms.TextBox();
            this.nipTextBox = new System.Windows.Forms.TextBox();
            this.steetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.flatNumberTextBox = new System.Windows.Forms.TextBox();
            this.addCompaniesBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.companiesListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flat Number";
            // 
            // nameCompaniesTextBox
            // 
            this.nameCompaniesTextBox.Location = new System.Drawing.Point(140, 51);
            this.nameCompaniesTextBox.Name = "nameCompaniesTextBox";
            this.nameCompaniesTextBox.Size = new System.Drawing.Size(158, 22);
            this.nameCompaniesTextBox.TabIndex = 6;
            // 
            // nipTextBox
            // 
            this.nipTextBox.Location = new System.Drawing.Point(140, 81);
            this.nipTextBox.Name = "nipTextBox";
            this.nipTextBox.Size = new System.Drawing.Size(158, 22);
            this.nipTextBox.TabIndex = 7;
            // 
            // steetTextBox
            // 
            this.steetTextBox.Location = new System.Drawing.Point(140, 109);
            this.steetTextBox.Name = "steetTextBox";
            this.steetTextBox.Size = new System.Drawing.Size(158, 22);
            this.steetTextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(140, 196);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(158, 22);
            this.cityTextBox.TabIndex = 11;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(140, 164);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(158, 22);
            this.zipCodeTextBox.TabIndex = 10;
            // 
            // flatNumberTextBox
            // 
            this.flatNumberTextBox.Location = new System.Drawing.Point(140, 136);
            this.flatNumberTextBox.Name = "flatNumberTextBox";
            this.flatNumberTextBox.Size = new System.Drawing.Size(158, 22);
            this.flatNumberTextBox.TabIndex = 9;
            // 
            // addCompaniesBtn
            // 
            this.addCompaniesBtn.Location = new System.Drawing.Point(223, 224);
            this.addCompaniesBtn.Name = "addCompaniesBtn";
            this.addCompaniesBtn.Size = new System.Drawing.Size(75, 23);
            this.addCompaniesBtn.TabIndex = 12;
            this.addCompaniesBtn.Text = "Add";
            this.addCompaniesBtn.UseVisualStyleBackColor = true;
            this.addCompaniesBtn.Click += new System.EventHandler(this.addCompaniesBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(713, 247);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // companiesListBox
            // 
            this.companiesListBox.FormattingEnabled = true;
            this.companiesListBox.ItemHeight = 16;
            this.companiesListBox.Location = new System.Drawing.Point(304, 51);
            this.companiesListBox.Name = "companiesListBox";
            this.companiesListBox.Size = new System.Drawing.Size(484, 180);
            this.companiesListBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Companies List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Add companies";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(632, 247);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 17;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // CompaniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 282);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.companiesListBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addCompaniesBtn);
            this.Controls.Add(this.flatNumberTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.steetTextBox);
            this.Controls.Add(this.nipTextBox);
            this.Controls.Add(this.nameCompaniesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompaniesForm";
            this.Text = "CompaniesForm";
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
        private System.Windows.Forms.TextBox nameCompaniesTextBox;
        private System.Windows.Forms.TextBox nipTextBox;
        private System.Windows.Forms.TextBox steetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox flatNumberTextBox;
        private System.Windows.Forms.Button addCompaniesBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox companiesListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button removeBtn;
    }
}