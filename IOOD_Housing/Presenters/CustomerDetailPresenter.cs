using IOOD_Housing.DB;
using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Presenters
{
    class CustomerDetailPresenter : Presenter
    {
        private ICustomerDetailView customerDetailView;
        private DataSource orderSource;
        private Customer customer;

        public CustomerDetailPresenter(ICustomerDetailView view, Customer customer)
        {
            customerDetailView = view;
            this.customer = customer;

            customerDetailView.NameLabel = customer.Name;
            customerDetailView.IdLabel = customer.Id.ToString();
            customerDetailView.EmailLabel = customer.Email;
            customerDetailView.PhoneLabel = customer.Phone;

            customerDetailView.AddressLabel = customer.Address;

            orderSource = DataManager.getInstance().getDataSource(DataManager.Query.Orders);
            
            //Filter the Orders dataset to only this customer and required fields
            var filteredView = new DataView(orderSource.getDataset().Tables[0]);
            filteredView.RowFilter = ("customerID = " + customer.Id);

            string[] selectedColumns = new[] { "ID", "orderDate", "status" };
            DataTable orderDetail = filteredView.ToTable(false, selectedColumns);

            //Fill the dgv in view
            customerDetailView.setOrderGrid(orderDetail);

            //Bind the events
            customerDetailView.EditUserEvent += onEditUser;
        }

        public void Present()
        {
            customerDetailView.Show();
        }

        private void onEditUser()
        {
            var detailpresenter = new CustomerEditPresenter(new CustomerEditView(), customer);
            detailpresenter.Present();
            customerDetailView.Close();
        }
    }
}
