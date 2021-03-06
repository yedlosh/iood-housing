﻿namespace IOOD_Housing.Forms
{
    partial class HouseEditView
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grp_housestats = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_house_area = new System.Windows.Forms.Label();
            this.lbl_house_receptions = new System.Windows.Forms.Label();
            this.lbl_house_bathrooms = new System.Windows.Forms.Label();
            this.lbl_house_bedrooms = new System.Windows.Forms.Label();
            this.grp_components = new System.Windows.Forms.GroupBox();
            this.lbl_components_time = new System.Windows.Forms.Label();
            this.lbl_components_price = new System.Windows.Forms.Label();
            this.lbl_components_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grp_housestats.SuspendLayout();
            this.grp_components.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 1;
            // 
            // grp_housestats
            // 
            this.grp_housestats.Controls.Add(this.comboBox4);
            this.grp_housestats.Controls.Add(this.comboBox3);
            this.grp_housestats.Controls.Add(this.comboBox2);
            this.grp_housestats.Controls.Add(this.comboBox1);
            this.grp_housestats.Controls.Add(this.lbl_house_area);
            this.grp_housestats.Controls.Add(this.lbl_house_receptions);
            this.grp_housestats.Controls.Add(this.lbl_house_bathrooms);
            this.grp_housestats.Controls.Add(this.lbl_house_bedrooms);
            this.grp_housestats.Location = new System.Drawing.Point(12, 36);
            this.grp_housestats.Name = "grp_housestats";
            this.grp_housestats.Size = new System.Drawing.Size(271, 79);
            this.grp_housestats.TabIndex = 5;
            this.grp_housestats.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(205, 45);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(60, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(205, 17);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(71, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lbl_house_area
            // 
            this.lbl_house_area.AutoSize = true;
            this.lbl_house_area.Location = new System.Drawing.Point(169, 48);
            this.lbl_house_area.Name = "lbl_house_area";
            this.lbl_house_area.Size = new System.Drawing.Size(32, 13);
            this.lbl_house_area.TabIndex = 3;
            this.lbl_house_area.Text = "Area:";
            // 
            // lbl_house_receptions
            // 
            this.lbl_house_receptions.AutoSize = true;
            this.lbl_house_receptions.Location = new System.Drawing.Point(137, 20);
            this.lbl_house_receptions.Name = "lbl_house_receptions";
            this.lbl_house_receptions.Size = new System.Drawing.Size(64, 13);
            this.lbl_house_receptions.TabIndex = 2;
            this.lbl_house_receptions.Text = "Receptions:";
            // 
            // lbl_house_bathrooms
            // 
            this.lbl_house_bathrooms.AutoSize = true;
            this.lbl_house_bathrooms.Location = new System.Drawing.Point(7, 48);
            this.lbl_house_bathrooms.Name = "lbl_house_bathrooms";
            this.lbl_house_bathrooms.Size = new System.Drawing.Size(60, 13);
            this.lbl_house_bathrooms.TabIndex = 1;
            this.lbl_house_bathrooms.Text = "Bathrooms:";
            // 
            // lbl_house_bedrooms
            // 
            this.lbl_house_bedrooms.AutoSize = true;
            this.lbl_house_bedrooms.Location = new System.Drawing.Point(7, 20);
            this.lbl_house_bedrooms.Name = "lbl_house_bedrooms";
            this.lbl_house_bedrooms.Size = new System.Drawing.Size(57, 13);
            this.lbl_house_bedrooms.TabIndex = 0;
            this.lbl_house_bedrooms.Text = "Bedrooms:";
            // 
            // grp_components
            // 
            this.grp_components.Controls.Add(this.lbl_components_time);
            this.grp_components.Controls.Add(this.lbl_components_price);
            this.grp_components.Controls.Add(this.lbl_components_name);
            this.grp_components.Controls.Add(this.tableLayoutPanel1);
            this.grp_components.Location = new System.Drawing.Point(12, 121);
            this.grp_components.Name = "grp_components";
            this.grp_components.Size = new System.Drawing.Size(271, 237);
            this.grp_components.TabIndex = 6;
            this.grp_components.TabStop = false;
            this.grp_components.Text = "Components";
            // 
            // lbl_components_time
            // 
            this.lbl_components_time.AutoSize = true;
            this.lbl_components_time.Location = new System.Drawing.Point(205, 19);
            this.lbl_components_time.Name = "lbl_components_time";
            this.lbl_components_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_components_time.TabIndex = 6;
            this.lbl_components_time.Text = "Time";
            // 
            // lbl_components_price
            // 
            this.lbl_components_price.AutoSize = true;
            this.lbl_components_price.Location = new System.Drawing.Point(159, 19);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.40359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 159);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(208, 376);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 376);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // HouseEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 411);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grp_components);
            this.Controls.Add(this.grp_housestats);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "HouseEditView";
            this.Text = "House Edit";
            this.grp_housestats.ResumeLayout(false);
            this.grp_housestats.PerformLayout();
            this.grp_components.ResumeLayout(false);
            this.grp_components.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grp_housestats;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_house_area;
        private System.Windows.Forms.Label lbl_house_receptions;
        private System.Windows.Forms.Label lbl_house_bathrooms;
        private System.Windows.Forms.Label lbl_house_bedrooms;
        private System.Windows.Forms.GroupBox grp_components;
        private System.Windows.Forms.Label lbl_components_time;
        private System.Windows.Forms.Label lbl_components_price;
        private System.Windows.Forms.Label lbl_components_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}