namespace IOOD_Housing.Forms
{
    partial class ListSearchView
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
            this.txt_searchBox = new System.Windows.Forms.TextBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_out_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_searchBox
            // 
            this.txt_searchBox.Location = new System.Drawing.Point(13, 13);
            this.txt_searchBox.Name = "txt_searchBox";
            this.txt_searchBox.Size = new System.Drawing.Size(322, 20);
            this.txt_searchBox.TabIndex = 0;
            this.txt_searchBox.Text = "Search";
            this.txt_searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(12, 49);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.Size = new System.Drawing.Size(721, 302);
            this.dgv_list.TabIndex = 1;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(13, 363);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_out_total
            // 
            this.lbl_out_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_out_total.AutoSize = true;
            this.lbl_out_total.Location = new System.Drawing.Point(43, 363);
            this.lbl_out_total.Name = "lbl_out_total";
            this.lbl_out_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_out_total.TabIndex = 3;
            this.lbl_out_total.Text = "0";
            // 
            // ListSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 388);
            this.Controls.Add(this.lbl_out_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.txt_searchBox);
            this.Name = "ListSearchView";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchBox;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_out_total;
    }
}