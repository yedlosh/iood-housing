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
    public interface ICustomerEditView : IViewForm
    {
        //event Action NameValidating;

        string NameText { get; set; }
        string AddressText { get; set; }
        string CityText { get; set; }
        string PostcodeText { get; set; }
        string EmailText { get; set; }
        string PhoneText { get; set; }

        event Action SaveEvent;
        event Action CancelEvent;
    }

    public partial class CustomerEditView : Form, ICustomerEditView
    {

        public event Action SaveEvent;
        public event Action CancelEvent;

        public CustomerEditView()
        {
            InitializeComponent();
            //this.txt_name.Tag = false;
            //this.txt_name.Validating += new CancelEventHandler(textBoxEmpty_Validating);

        }

        void IViewForm.Close()
        {
            this.Close();
        }

        void IViewForm.Show()
        {
            this.Show();
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (SaveEvent != null)
            {
                SaveEvent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (CancelEvent != null)
            {
                CancelEvent();
            }
        }


        public string NameText
        {
            get
            {
                return txt_name.Text;
            }
            set
            {
                txt_name.Text = value;
            }
        }

        public string AddressText
        {
            get
            {
                return txt_address.Text;
            }
            set
            {
                txt_address.Text = value;
            }
        }

        public string CityText
        {
            get
            {
                return txt_city.Text;
            }
            set
            {
                txt_city.Text = value;
            }
        }

        public string PostcodeText
        {
            get
            {
                return txt_postcode.Text;
            }
            set
            {
                txt_postcode.Text = value;
            }
        }

        public string EmailText
        {
            get
            {
                return txt_email.Text;
            }
            set
            {
                txt_email.Text = value;
            }
        }

        public string PhoneText
        {
            get
            {
                return txt_phone.Text;
            }
            set
            {
                txt_phone.Text = value;
            }
        }
    }
}
