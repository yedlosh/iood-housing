namespace IOOD_Housing.Forms
{
    partial class CustomerEditView
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_postcode = new System.Windows.Forms.Label();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(65, 10);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(207, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(14, 39);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(65, 36);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(207, 20);
            this.txt_address.TabIndex = 3;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(65, 62);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(207, 20);
            this.txt_city.TabIndex = 4;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(14, 65);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(24, 13);
            this.lbl_city.TabIndex = 5;
            this.lbl_city.Text = "City";
            // 
            // lbl_postcode
            // 
            this.lbl_postcode.AutoSize = true;
            this.lbl_postcode.Location = new System.Drawing.Point(13, 94);
            this.lbl_postcode.Name = "lbl_postcode";
            this.lbl_postcode.Size = new System.Drawing.Size(52, 13);
            this.lbl_postcode.TabIndex = 6;
            this.lbl_postcode.Text = "Postcode";
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(65, 91);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(100, 20);
            this.txt_postcode.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(65, 118);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(207, 20);
            this.txt_email.TabIndex = 8;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(13, 121);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(65, 145);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 10;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(14, 148);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_phone.TabIndex = 11;
            this.lbl_phone.Text = "Phone";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(17, 198);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(197, 198);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // CustomerEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 231);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_postcode);
            this.Controls.Add(this.lbl_postcode);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "CustomerEditView";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_postcode;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}