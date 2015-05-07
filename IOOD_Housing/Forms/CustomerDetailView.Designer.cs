namespace IOOD_Housing.Forms
{
    partial class CustomerDetailView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_id_out = new System.Windows.Forms.Label();
            this.lbl_email_out = new System.Windows.Forms.Label();
            this.lbl_phone_out = new System.Windows.Forms.Label();
            this.lbl_address_out = new System.Windows.Forms.Label();
            this.lbl_name_out = new System.Windows.Forms.Label();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(30, 41);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(16, 54);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(10, 67);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 4;
            this.lbl_phone.Text = "Phone:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(178, 28);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(48, 13);
            this.lbl_address.TabIndex = 5;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_id_out
            // 
            this.lbl_id_out.AutoSize = true;
            this.lbl_id_out.Location = new System.Drawing.Point(58, 41);
            this.lbl_id_out.Name = "lbl_id_out";
            this.lbl_id_out.Size = new System.Drawing.Size(15, 13);
            this.lbl_id_out.TabIndex = 7;
            this.lbl_id_out.Text = "id";
            // 
            // lbl_email_out
            // 
            this.lbl_email_out.AutoSize = true;
            this.lbl_email_out.Location = new System.Drawing.Point(58, 54);
            this.lbl_email_out.Name = "lbl_email_out";
            this.lbl_email_out.Size = new System.Drawing.Size(31, 13);
            this.lbl_email_out.TabIndex = 8;
            this.lbl_email_out.Text = "email";
            // 
            // lbl_phone_out
            // 
            this.lbl_phone_out.AutoSize = true;
            this.lbl_phone_out.Location = new System.Drawing.Point(58, 67);
            this.lbl_phone_out.Name = "lbl_phone_out";
            this.lbl_phone_out.Size = new System.Drawing.Size(37, 13);
            this.lbl_phone_out.TabIndex = 9;
            this.lbl_phone_out.Text = "phone";
            // 
            // lbl_address_out
            // 
            this.lbl_address_out.AutoSize = true;
            this.lbl_address_out.Location = new System.Drawing.Point(233, 28);
            this.lbl_address_out.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbl_address_out.Name = "lbl_address_out";
            this.lbl_address_out.Size = new System.Drawing.Size(44, 13);
            this.lbl_address_out.TabIndex = 10;
            this.lbl_address_out.Text = "address";
            // 
            // lbl_name_out
            // 
            this.lbl_name_out.AutoSize = true;
            this.lbl_name_out.Location = new System.Drawing.Point(58, 28);
            this.lbl_name_out.Name = "lbl_name_out";
            this.lbl_name_out.Size = new System.Drawing.Size(33, 13);
            this.lbl_name_out.TabIndex = 11;
            this.lbl_name_out.Text = "name";
            // 
            // dgv_orders
            // 
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Location = new System.Drawing.Point(12, 109);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.Size = new System.Drawing.Size(326, 156);
            this.dgv_orders.TabIndex = 12;
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Location = new System.Drawing.Point(12, 90);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(38, 13);
            this.lbl_orders.TabIndex = 13;
            this.lbl_orders.Text = "Orders";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(139, 273);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 14;
            this.btn_order.Text = "New Order";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // CustomerDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 308);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.lbl_orders);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.lbl_name_out);
            this.Controls.Add(this.lbl_address_out);
            this.Controls.Add(this.lbl_phone_out);
            this.Controls.Add(this.lbl_email_out);
            this.Controls.Add(this.lbl_id_out);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerDetailView";
            this.Text = "CustomerDetailView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_id_out;
        private System.Windows.Forms.Label lbl_email_out;
        private System.Windows.Forms.Label lbl_phone_out;
        private System.Windows.Forms.Label lbl_address_out;
        private System.Windows.Forms.Label lbl_name_out;
        private System.Windows.Forms.DataGridView dgv_orders;
        private System.Windows.Forms.Label lbl_orders;
        private System.Windows.Forms.Button btn_order;
    }
}