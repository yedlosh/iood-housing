﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using IOOD_Housing.Forms;
using System.Windows.Forms;


namespace IOOD_Housing.Presenters
{
    class CustomerEditPresenter : Presenter
    {

        OleDbConnection dbCon;
        OleDbDataAdapter da;
        private ICustomerEditView customerEditView;

        public CustomerEditPresenter(ICustomerEditView view, Customer customer = null) 
        {
            customerEditView = view;

            customerEditView.SaveEvent += saveButtonEvent;
            customerEditView.CancelEvent += cancelButtonEvent;

            if (customer != null) {
                customerEditView.NameText = customer.Name;
                customerEditView.AddressText = customer.Address;
                customerEditView.CityText = customer.City;
                customerEditView.PostcodeText = customer.Postcode;
                customerEditView.EmailText = customer.Email;
                customerEditView.PhoneText = customer.Phone;
            }
        }

        public void saveButtonEvent()
        {
            if (ValidateInput())
            {
                //TODO Save to db
                dbCon.Open();

                string sql = "insert into customers()values()";

                OleDbCommand com = new OleDbCommand(sql, dbCon);
                com.ExecuteNonQuery();
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("your data has been saved!", "hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("error!", "hint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // customerEditView.Close();
            }
            else
            {
                MessageBox.Show("invalid input");
            }
        }

        public void cancelButtonEvent()
        {
            customerEditView.Close();
        }

        private bool ValidateInput()
        {
            return (customerEditView.NameText.Length != 0 &&
                    customerEditView.AddressText.Length != 0 &&
                    customerEditView.CityText.Length != 0 &&
                    customerEditView.PostcodeText.Length != 0 &&
                    customerEditView.EmailText.Length != 0 &&
                    customerEditView.PhoneText.Length != 0);
        }

        //void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        //{
        //    TextBox tb = (TextBox)sender;
        //    if (tb.Text.Length == 0)
        //    {
        //        tb.BackColor = Color.Red;
        //        tb.Tag = false;
        //    }
        //    else
        //    {
        //        tb.BackColor = System.Drawing.SystemColors.Window;
        //        tb.Tag = true;
        //    }
        //    ValidateOK();
        //}


        public void Present()
        {
            customerEditView.Show();
        }
    }
}
