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

        event Action NewOrderEvent;
    }

    public partial class CustomerDetailView : Form, ICustomerDetailView
    {


        public event Action NewOrderEvent;

        public CustomerDetailView()
        {
            InitializeComponent();
        }

        void IViewForm.Close()
        {
            this.Close();
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
    }
}
