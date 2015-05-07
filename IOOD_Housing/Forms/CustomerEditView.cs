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
        string NameText { get; set; }
        string AddressText { get; set; }
        string CityText { get; set; }
        string PostcodeText { get; set; }
        string EmailText { get; set; }
        string PhoneText { get; set; }

        void SetFieldError(CustomerEditView.TextField field, bool error);

        event Action<CustomerEditView.TextField> FieldChanged;

        event Action SaveEvent;
        event Action CancelEvent;
        event Action FormClosedEvent;
    }

    public partial class CustomerEditView : Form, ICustomerEditView
    {
        public event Action SaveEvent;
        public event Action CancelEvent;
        public event Action FormClosedEvent;

        public event Action<CustomerEditView.TextField> FieldChanged;

        public enum TextField { 
            Name,
            Address,
            City,
            Postcode,
            Email,
            Phone
        }

        private Dictionary<TextField, TextBox> fieldDict;

        public CustomerEditView()
        {
            InitializeComponent();

            fieldDict = new Dictionary<TextField, TextBox>()
            {
                {TextField.Name, txt_name},
                {TextField.Address, txt_address},
                {TextField.City, txt_city},
                {TextField.Postcode, txt_postcode},
                {TextField.Email, txt_email},
                {TextField.Phone, txt_phone}
            };
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

        public void SetFieldError(CustomerEditView.TextField field, bool error)
        {
            TextBox fieldBox;
            if (fieldDict.TryGetValue(field, out fieldBox))
            {
                if (error)
                {
                    fieldBox.BackColor = Color.PeachPuff;
                }
                else
                {
                    fieldBox.BackColor = Color.White;
                }
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (FieldChanged != null)
            {
                FieldChanged(TextField.Name);
            }
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            if (FieldChanged != null)
            {
                FieldChanged(TextField.Address);
            }
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            if (FieldChanged != null)
            {
                FieldChanged(TextField.City);
            }
        }

        private void txt_postcode_TextChanged(object sender, EventArgs e)
        {
            if (FieldChanged != null)
            {
                FieldChanged(TextField.Postcode);
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (FieldChanged != null)
            {
                FieldChanged(TextField.Email);
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (FieldChanged != null)
            {
                FieldChanged(TextField.Phone);
            }
        }

        private void CustomerEditView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedEvent != null)
            {
                FormClosedEvent();
            }
        }
    }
}
