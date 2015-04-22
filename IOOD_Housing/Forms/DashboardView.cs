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

        void IViewForm.Show()
        {
            this.Show();
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
    }
}
