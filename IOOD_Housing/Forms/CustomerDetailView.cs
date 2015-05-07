using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IOOD_Housing.Forms
{
    public interface ICustomerDetailView : IViewForm
    {
        string NameLabel { get; set; }
        string IdLabel { get; set; }
        string EmailLabel { get; set; }
        string PhoneLabel { get; set; }
        string AddressLabel { get; set; }

        void setOrderGrid(Object data);

        event Action NewOrderEvent;
        event Action EditUserEvent;
    }

    public partial class CustomerDetailView : Form, ICustomerDetailView
    {


        public event Action NewOrderEvent;
        public event Action EditUserEvent;

        public CustomerDetailView()
        {
            InitializeComponent();
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

        public string NameLabel
        {
            get
            {
                return lbl_name_out.Text;
            }
            set
            {
                lbl_name_out.Text = value;
            }
        }

        public string IdLabel
        {
            get
            {
                return lbl_id_out.Text;
            }
            set
            {
                lbl_id_out.Text = value;
            }
        }

        public string EmailLabel
        {
            get
            {
                return lbl_email_out.Text;
            }
            set
            {
                lbl_email_out.Text = value;
            }
        }

        public string PhoneLabel
        {
            get
            {
                return lbl_phone_out.Text;
            }
            set
            {
                lbl_phone_out.Text = value;
            }
        }

        public string AddressLabel
        {
            get
            {
                return lbl_address_out.Text;
            }
            set
            {
                lbl_address_out.Text = value;
            }
        }


        public void setOrderGrid(Object data)
        {
            dgv_orders.DataSource = data;

            dgv_orders.AllowUserToDeleteRows = false;
            dgv_orders.AllowUserToAddRows = false;

            for (int x = 0; x < dgv_orders.ColumnCount; x++)
            {
                dgv_orders.Columns[x].ReadOnly = true;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditUserEvent != null)
            {
                EditUserEvent();
            }
        }
    }
}
