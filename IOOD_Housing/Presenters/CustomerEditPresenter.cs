using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using IOOD_Housing.Forms;
using System.Windows.Forms;
using IOOD_Housing.DB;


namespace IOOD_Housing.Presenters
{
    class CustomerEditPresenter : Presenter
    {
        private ICustomerEditView customerEditView;
        private Customer customer;
        private bool editing = false;

        public CustomerEditPresenter(ICustomerEditView view, Customer customer = null) 
        {
            customerEditView = view;

            customerEditView.SaveEvent += saveButtonEvent;
            customerEditView.CancelEvent += cancelButtonEvent;

            customerEditView.FieldChanged += fieldChangedEvent;
            customerEditView.FormClosedEvent += formClosedEvent;

            if (customer != null) {
                customerEditView.NameText = customer.Name;
                customerEditView.AddressText = customer.Address;
                customerEditView.CityText = customer.City;
                customerEditView.PostcodeText = customer.Postcode;
                customerEditView.EmailText = customer.Email;
                customerEditView.PhoneText = customer.Phone;
                this.customer = customer;
                editing = true;
            }
        }

        public void saveButtonEvent()
        {
            if (ValidateInput()) { 
                //TODO Save to db
                CustomerDataSource dataSource = (CustomerDataSource) DataManager.getInstance().getDataSource(DataManager.Query.Customers);

                if (!editing)
                {
                    customer = new Customer();
                    updateCustomerFromView(customer);
                    dataSource.addCustomer(customer);
                }
                else 
                {
                    updateCustomerFromView(customer);
                    dataSource.updateCustomer(customer);
                }
                customerEditView.Close();
            } 
        }

        public void cancelButtonEvent()
        {
            customerEditView.Close();
        }

        private bool ValidateInput()
        {
            bool clean = true;

            if(customerEditView.NameText.Length == 0)
            {
                customerEditView.SetFieldError(CustomerEditView.TextField.Name, true);
                clean = false;
            }
            if(customerEditView.AddressText.Length == 0)
            {
                customerEditView.SetFieldError(CustomerEditView.TextField.Address, true);
                clean = false;
            }
            if(customerEditView.CityText.Length == 0)
            {
                customerEditView.SetFieldError(CustomerEditView.TextField.City, true);
                clean = false;
            }
            if(customerEditView.PostcodeText.Length == 0)
            {
                customerEditView.SetFieldError(CustomerEditView.TextField.Postcode, true);
                clean = false;
            }
            if (customerEditView.EmailText.Length == 0 && customerEditView.PhoneText.Length == 0)
            {
                customerEditView.SetFieldError(CustomerEditView.TextField.Email, true);
                customerEditView.SetFieldError(CustomerEditView.TextField.Phone, true);
            }
            if (!clean)
            {
                MessageBox.Show("Please fill all required fields!", "Customer Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (customerEditView.EmailText.Length == 0 && customerEditView.PhoneText.Length == 0)
            {
                MessageBox.Show("Please enter phone or email contact!", "Customer Form",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                clean = false;
            }

            return clean;
        }

        private void fieldChangedEvent(CustomerEditView.TextField field){

            customerEditView.SetFieldError(field, false);

            if (field == CustomerEditView.TextField.Phone) 
            {
                customerEditView.SetFieldError(CustomerEditView.TextField.Email, false);
            }
            else if (field == CustomerEditView.TextField.Email)
            {
                customerEditView.SetFieldError(CustomerEditView.TextField.Phone, false);
            }
        }

        private void formClosedEvent() 
        {
            if (editing)
            {
                var detailpresenter = new CustomerDetailPresenter(new CustomerDetailView(), customer);
                detailpresenter.Present();
            }
        }


        public void Present()
        {
            customerEditView.Show();
        }

        private void updateCustomerFromView(Customer customer){

            customer.Name = customerEditView.NameText;
            customer.Address = customerEditView.AddressText;
            customer.City = customerEditView.CityText;
            customer.Postcode = customerEditView.PostcodeText;
            customer.Email = customerEditView.EmailText;
            customer.Phone = customerEditView.PhoneText;
        }
    }
}
