namespace IOOD_Housing
{
    partial class DashboardView
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.housesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchHousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_queueDash = new System.Windows.Forms.DataGridView();
            this.lbl_factoryStatus = new System.Windows.Forms.Label();
            this.lbl_out_factoryStatus = new System.Windows.Forms.Label();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.lbl_orders_scheduled = new System.Windows.Forms.Label();
            this.lbl_orders_until = new System.Windows.Forms.Label();
            this.lbl_orders_scheduled_out = new System.Windows.Forms.Label();
            this.lbl_orders_until_out = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_queueDash)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.housesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.searchCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // searchCustomersToolStripMenuItem
            // 
            this.searchCustomersToolStripMenuItem.Name = "searchCustomersToolStripMenuItem";
            this.searchCustomersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.searchCustomersToolStripMenuItem.Text = "Search Customers";
            this.searchCustomersToolStripMenuItem.Click += new System.EventHandler(this.searchCustomersToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // searchOrdersToolStripMenuItem
            // 
            this.searchOrdersToolStripMenuItem.Name = "searchOrdersToolStripMenuItem";
            this.searchOrdersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchOrdersToolStripMenuItem.Text = "Search Orders";
            this.searchOrdersToolStripMenuItem.Click += new System.EventHandler(this.searchOrdersToolStripMenuItem_Click);
            // 
            // housesToolStripMenuItem
            // 
            this.housesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newHouseToolStripMenuItem,
            this.searchHousesToolStripMenuItem});
            this.housesToolStripMenuItem.Name = "housesToolStripMenuItem";
            this.housesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.housesToolStripMenuItem.Text = "Houses";
            // 
            // newHouseToolStripMenuItem
            // 
            this.newHouseToolStripMenuItem.Name = "newHouseToolStripMenuItem";
            this.newHouseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newHouseToolStripMenuItem.Text = "New House";
            this.newHouseToolStripMenuItem.Click += new System.EventHandler(this.newHouseToolStripMenuItem_Click);
            // 
            // searchHousesToolStripMenuItem
            // 
            this.searchHousesToolStripMenuItem.Name = "searchHousesToolStripMenuItem";
            this.searchHousesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchHousesToolStripMenuItem.Text = "Search Houses";
            this.searchHousesToolStripMenuItem.Click += new System.EventHandler(this.searchHousesToolStripMenuItem_Click);
            // 
            // dgv_queueDash
            // 
            this.dgv_queueDash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_queueDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_queueDash.Location = new System.Drawing.Point(13, 28);
            this.dgv_queueDash.Name = "dgv_queueDash";
            this.dgv_queueDash.Size = new System.Drawing.Size(457, 303);
            this.dgv_queueDash.TabIndex = 1;
            // 
            // lbl_factoryStatus
            // 
            this.lbl_factoryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_factoryStatus.AutoSize = true;
            this.lbl_factoryStatus.Location = new System.Drawing.Point(13, 341);
            this.lbl_factoryStatus.Name = "lbl_factoryStatus";
            this.lbl_factoryStatus.Size = new System.Drawing.Size(75, 13);
            this.lbl_factoryStatus.TabIndex = 2;
            this.lbl_factoryStatus.Text = "Factory Status";
            // 
            // lbl_out_factoryStatus
            // 
            this.lbl_out_factoryStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_out_factoryStatus.AutoSize = true;
            this.lbl_out_factoryStatus.Location = new System.Drawing.Point(13, 358);
            this.lbl_out_factoryStatus.Name = "lbl_out_factoryStatus";
            this.lbl_out_factoryStatus.Size = new System.Drawing.Size(103, 13);
            this.lbl_out_factoryStatus.TabIndex = 3;
            this.lbl_out_factoryStatus.Text = "This is factory status";
            // 
            // lbl_orders
            // 
            this.lbl_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Location = new System.Drawing.Point(379, 341);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(38, 13);
            this.lbl_orders.TabIndex = 4;
            this.lbl_orders.Text = "Orders";
            // 
            // lbl_orders_scheduled
            // 
            this.lbl_orders_scheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_orders_scheduled.AutoSize = true;
            this.lbl_orders_scheduled.Location = new System.Drawing.Point(337, 358);
            this.lbl_orders_scheduled.Name = "lbl_orders_scheduled";
            this.lbl_orders_scheduled.Size = new System.Drawing.Size(61, 13);
            this.lbl_orders_scheduled.TabIndex = 5;
            this.lbl_orders_scheduled.Text = "Scheduled:";
            // 
            // lbl_orders_until
            // 
            this.lbl_orders_until.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_orders_until.AutoSize = true;
            this.lbl_orders_until.Location = new System.Drawing.Point(367, 371);
            this.lbl_orders_until.Name = "lbl_orders_until";
            this.lbl_orders_until.Size = new System.Drawing.Size(31, 13);
            this.lbl_orders_until.TabIndex = 6;
            this.lbl_orders_until.Text = "Until:";
            // 
            // lbl_orders_scheduled_out
            // 
            this.lbl_orders_scheduled_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_orders_scheduled_out.AutoSize = true;
            this.lbl_orders_scheduled_out.Location = new System.Drawing.Point(405, 358);
            this.lbl_orders_scheduled_out.Name = "lbl_orders_scheduled_out";
            this.lbl_orders_scheduled_out.Size = new System.Drawing.Size(13, 13);
            this.lbl_orders_scheduled_out.TabIndex = 7;
            this.lbl_orders_scheduled_out.Text = "0";
            // 
            // lbl_orders_until_out
            // 
            this.lbl_orders_until_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_orders_until_out.AutoSize = true;
            this.lbl_orders_until_out.Location = new System.Drawing.Point(405, 371);
            this.lbl_orders_until_out.Name = "lbl_orders_until_out";
            this.lbl_orders_until_out.Size = new System.Drawing.Size(65, 13);
            this.lbl_orders_until_out.TabIndex = 8;
            this.lbl_orders_until_out.Text = "31/12/2015";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 396);
            this.Controls.Add(this.lbl_orders_until_out);
            this.Controls.Add(this.lbl_orders_scheduled_out);
            this.Controls.Add(this.lbl_orders_until);
            this.Controls.Add(this.lbl_orders_scheduled);
            this.Controls.Add(this.lbl_orders);
            this.Controls.Add(this.lbl_out_factoryStatus);
            this.Controls.Add(this.lbl_factoryStatus);
            this.Controls.Add(this.dgv_queueDash);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardView";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_queueDash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem housesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchHousesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_queueDash;
        private System.Windows.Forms.Label lbl_factoryStatus;
        private System.Windows.Forms.Label lbl_out_factoryStatus;
        private System.Windows.Forms.Label lbl_orders;
        private System.Windows.Forms.Label lbl_orders_scheduled;
        private System.Windows.Forms.Label lbl_orders_until;
        private System.Windows.Forms.Label lbl_orders_scheduled_out;
        private System.Windows.Forms.Label lbl_orders_until_out;
    }
}

