using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IOOD_Housing
{
    public interface IDashboardView : IViewForm 
    {
        event Action<DashboardView.MenuItems> MenuStripEvent;
        void setDataGrid(DataSet data);

        string OrdersCountLabel { get; set; }
        string OrdersEndDateLabel { get; set; }
    }

    public partial class DashboardView : Form, IDashboardView
    {
        public event Action<DashboardView.MenuItems> MenuStripEvent;

        public enum MenuItems 
        { 
            Exit,
            NewCustomer,
            SearchCustomers,
            SearchOrders,
            NewHouse,
            SearchHouses
        }

        public DashboardView()
        {
            InitializeComponent();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }

        void IViewForm.Close()
        {
            this.Close();
        }

        void IViewForm.Hide()
        {
            this.Hide();
        }

        void IViewForm.Show()
        {
            this.Show();
        }

        public void setDataGrid(DataSet data)
        {
            dgv_queueDash.DataSource = data.Tables[0];

            dgv_queueDash.AllowUserToDeleteRows = false;
            dgv_queueDash.AllowUserToAddRows = false;

            for (int x = 0; x < dgv_queueDash.ColumnCount; x++)
            {
                dgv_queueDash.Columns[x].ReadOnly = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuStripEvent != null) 
            {
                MenuStripEvent(MenuItems.Exit);
            }
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuStripEvent != null)
            {
                MenuStripEvent(MenuItems.NewCustomer);
            }
        }

        private void searchCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuStripEvent != null)
            {
                MenuStripEvent(MenuItems.SearchCustomers);
            }
        }

        private void searchOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuStripEvent != null)
            {
                MenuStripEvent(MenuItems.SearchOrders);
            }
        }

        private void newHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuStripEvent != null)
            {
                MenuStripEvent(MenuItems.NewHouse);
            }
        }

        private void searchHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MenuStripEvent != null)
            {
                MenuStripEvent(MenuItems.SearchHouses);
            }
        }


        public string OrdersCountLabel
        {
            get
            {
                return lbl_orders_scheduled_out.Text;
            }
            set
            {
                lbl_orders_scheduled_out.Text = value;
            }
        }

        public string OrdersEndDateLabel
        {
            get
            {
                return lbl_orders_until_out.Text;
            }
            set
            {
                lbl_orders_until_out.Text = value;
            }
        }
    }
}
