﻿namespace IOOD_Housing.Forms
{
    partial class OrderDetailView
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
            this.lbl_client_id_out = new System.Windows.Forms.Label();
            this.lbl_client_name_out = new System.Windows.Forms.Label();
            this.lbl_client_id = new System.Windows.Forms.Label();
            this.lbl_client_name = new System.Windows.Forms.Label();
            this.grp_housestats = new System.Windows.Forms.GroupBox();
            this.lbl_house_area = new System.Windows.Forms.Label();
            this.lbl_house_receptions = new System.Windows.Forms.Label();
            this.lbl_house_bathrooms = new System.Windows.Forms.Label();
            this.lbl_house_bedrooms = new System.Windows.Forms.Label();
            this.lbl_house_type = new System.Windows.Forms.Label();
            this.grp_components = new System.Windows.Forms.GroupBox();
            this.lbl_components_time = new System.Windows.Forms.Label();
            this.lbl_components_price = new System.Windows.Forms.Label();
            this.lbl_components_name = new System.Windows.Forms.Label();
            this.lbl_total_time = new System.Windows.Forms.Label();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_delivery_out = new System.Windows.Forms.Label();
            this.lbl_delivery = new System.Windows.Forms.Label();
            this.grp_housestats.SuspendLayout();
            this.grp_components.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_client_id_out
            // 
            this.lbl_client_id_out.AutoSize = true;
            this.lbl_client_id_out.Location = new System.Drawing.Point(86, 26);
            this.lbl_client_id_out.Name = "lbl_client_id_out";
            this.lbl_client_id_out.Size = new System.Drawing.Size(28, 13);
            this.lbl_client_id_out.TabIndex = 14;
            this.lbl_client_id_out.Text = "XYZ";
            // 
            // lbl_client_name_out
            // 
            this.lbl_client_name_out.AutoSize = true;
            this.lbl_client_name_out.Location = new System.Drawing.Point(86, 9);
            this.lbl_client_name_out.Name = "lbl_client_name_out";
            this.lbl_client_name_out.Size = new System.Drawing.Size(53, 13);
            this.lbl_client_name_out.TabIndex = 13;
            this.lbl_client_name_out.Text = "John Doe";
            // 
            // lbl_client_id
            // 
            this.lbl_client_id.AutoSize = true;
            this.lbl_client_id.Location = new System.Drawing.Point(12, 26);
            this.lbl_client_id.Name = "lbl_client_id";
            this.lbl_client_id.Size = new System.Drawing.Size(50, 13);
            this.lbl_client_id.TabIndex = 12;
            this.lbl_client_id.Text = "Client ID:";
            // 
            // lbl_client_name
            // 
            this.lbl_client_name.AutoSize = true;
            this.lbl_client_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_client_name.Name = "lbl_client_name";
            this.lbl_client_name.Size = new System.Drawing.Size(67, 13);
            this.lbl_client_name.TabIndex = 11;
            this.lbl_client_name.Text = "Client Name:";
            // 
            // grp_housestats
            // 
            this.grp_housestats.Controls.Add(this.lbl_house_type);
            this.grp_housestats.Controls.Add(this.lbl_house_area);
            this.grp_housestats.Controls.Add(this.lbl_house_receptions);
            this.grp_housestats.Controls.Add(this.lbl_house_bathrooms);
            this.grp_housestats.Controls.Add(this.lbl_house_bedrooms);
            this.grp_housestats.Location = new System.Drawing.Point(12, 53);
            this.grp_housestats.Name = "grp_housestats";
            this.grp_housestats.Size = new System.Drawing.Size(281, 99);
            this.grp_housestats.TabIndex = 15;
            this.grp_housestats.TabStop = false;
            this.grp_housestats.Text = "House";
            // 
            // lbl_house_area
            // 
            this.lbl_house_area.AutoSize = true;
            this.lbl_house_area.Location = new System.Drawing.Point(214, 66);
            this.lbl_house_area.Name = "lbl_house_area";
            this.lbl_house_area.Size = new System.Drawing.Size(32, 13);
            this.lbl_house_area.TabIndex = 3;
            this.lbl_house_area.Text = "Area:";
            // 
            // lbl_house_receptions
            // 
            this.lbl_house_receptions.AutoSize = true;
            this.lbl_house_receptions.Location = new System.Drawing.Point(182, 44);
            this.lbl_house_receptions.Name = "lbl_house_receptions";
            this.lbl_house_receptions.Size = new System.Drawing.Size(64, 13);
            this.lbl_house_receptions.TabIndex = 2;
            this.lbl_house_receptions.Text = "Receptions:";
            // 
            // lbl_house_bathrooms
            // 
            this.lbl_house_bathrooms.AutoSize = true;
            this.lbl_house_bathrooms.Location = new System.Drawing.Point(7, 66);
            this.lbl_house_bathrooms.Name = "lbl_house_bathrooms";
            this.lbl_house_bathrooms.Size = new System.Drawing.Size(60, 13);
            this.lbl_house_bathrooms.TabIndex = 1;
            this.lbl_house_bathrooms.Text = "Bathrooms:";
            // 
            // lbl_house_bedrooms
            // 
            this.lbl_house_bedrooms.AutoSize = true;
            this.lbl_house_bedrooms.Location = new System.Drawing.Point(10, 44);
            this.lbl_house_bedrooms.Name = "lbl_house_bedrooms";
            this.lbl_house_bedrooms.Size = new System.Drawing.Size(57, 13);
            this.lbl_house_bedrooms.TabIndex = 0;
            this.lbl_house_bedrooms.Text = "Bedrooms:";
            // 
            // lbl_house_type
            // 
            this.lbl_house_type.AutoSize = true;
            this.lbl_house_type.Location = new System.Drawing.Point(26, 21);
            this.lbl_house_type.Name = "lbl_house_type";
            this.lbl_house_type.Size = new System.Drawing.Size(41, 13);
            this.lbl_house_type.TabIndex = 16;
            this.lbl_house_type.Text = "House:";
            // 
            // grp_components
            // 
            this.grp_components.Controls.Add(this.lbl_components_time);
            this.grp_components.Controls.Add(this.lbl_components_price);
            this.grp_components.Controls.Add(this.lbl_components_name);
            this.grp_components.Controls.Add(this.lbl_total_time);
            this.grp_components.Controls.Add(this.lbl_total_price);
            this.grp_components.Controls.Add(this.tableLayoutPanel1);
            this.grp_components.Controls.Add(this.lbl_total);
            this.grp_components.Location = new System.Drawing.Point(15, 158);
            this.grp_components.Name = "grp_components";
            this.grp_components.Size = new System.Drawing.Size(278, 228);
            this.grp_components.TabIndex = 16;
            this.grp_components.TabStop = false;
            this.grp_components.Text = "Components";
            // 
            // lbl_components_time
            // 
            this.lbl_components_time.AutoSize = true;
            this.lbl_components_time.Location = new System.Drawing.Point(213, 20);
            this.lbl_components_time.Name = "lbl_components_time";
            this.lbl_components_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_components_time.TabIndex = 6;
            this.lbl_components_time.Text = "Time";
            // 
            // lbl_components_price
            // 
            this.lbl_components_price.AutoSize = true;
            this.lbl_components_price.Location = new System.Drawing.Point(156, 20);
            this.lbl_components_price.Name = "lbl_components_price";
            this.lbl_components_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_components_price.TabIndex = 5;
            this.lbl_components_price.Text = "Price";
            // 
            // lbl_components_name
            // 
            this.lbl_components_name.AutoSize = true;
            this.lbl_components_name.Location = new System.Drawing.Point(14, 20);
            this.lbl_components_name.Name = "lbl_components_name";
            this.lbl_components_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_components_name.TabIndex = 4;
            this.lbl_components_name.Text = "Name";
            // 
            // lbl_total_time
            // 
            this.lbl_total_time.AutoSize = true;
            this.lbl_total_time.Location = new System.Drawing.Point(224, 207);
            this.lbl_total_time.Name = "lbl_total_time";
            this.lbl_total_time.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_time.TabIndex = 3;
            this.lbl_total_time.Text = "70";
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Location = new System.Drawing.Point(156, 207);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(43, 13);
            this.lbl_total_price.TabIndex = 2;
            this.lbl_total_price.Text = "200000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.40359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 159);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(105, 207);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(45, 13);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "TOTAL:";
            // 
            // lbl_delivery_out
            // 
            this.lbl_delivery_out.AutoSize = true;
            this.lbl_delivery_out.Location = new System.Drawing.Point(109, 401);
            this.lbl_delivery_out.Name = "lbl_delivery_out";
            this.lbl_delivery_out.Size = new System.Drawing.Size(59, 13);
            this.lbl_delivery_out.TabIndex = 18;
            this.lbl_delivery_out.Text = "26/6/2015";
            // 
            // lbl_delivery
            // 
            this.lbl_delivery.AutoSize = true;
            this.lbl_delivery.Location = new System.Drawing.Point(12, 401);
            this.lbl_delivery.Name = "lbl_delivery";
            this.lbl_delivery.Size = new System.Drawing.Size(91, 13);
            this.lbl_delivery.TabIndex = 17;
            this.lbl_delivery.Text = "Delivery Estimate:";
            // 
            // OrderDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 469);
            this.Controls.Add(this.lbl_delivery_out);
            this.Controls.Add(this.lbl_delivery);
            this.Controls.Add(this.grp_components);
            this.Controls.Add(this.grp_housestats);
            this.Controls.Add(this.lbl_client_id_out);
            this.Controls.Add(this.lbl_client_name_out);
            this.Controls.Add(this.lbl_client_id);
            this.Controls.Add(this.lbl_client_name);
            this.Name = "OrderDetailView";
            this.Text = "OrderDetailView";
            this.grp_housestats.ResumeLayout(false);
            this.grp_housestats.PerformLayout();
            this.grp_components.ResumeLayout(false);
            this.grp_components.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_client_id_out;
        private System.Windows.Forms.Label lbl_client_name_out;
        private System.Windows.Forms.Label lbl_client_id;
        private System.Windows.Forms.Label lbl_client_name;
        private System.Windows.Forms.GroupBox grp_housestats;
        private System.Windows.Forms.Label lbl_house_area;
        private System.Windows.Forms.Label lbl_house_receptions;
        private System.Windows.Forms.Label lbl_house_bathrooms;
        private System.Windows.Forms.Label lbl_house_bedrooms;
        private System.Windows.Forms.Label lbl_house_type;
        private System.Windows.Forms.GroupBox grp_components;
        private System.Windows.Forms.Label lbl_components_time;
        private System.Windows.Forms.Label lbl_components_price;
        private System.Windows.Forms.Label lbl_components_name;
        private System.Windows.Forms.Label lbl_total_time;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_delivery_out;
        private System.Windows.Forms.Label lbl_delivery;
    }
}