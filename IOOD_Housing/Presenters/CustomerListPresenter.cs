using IOOD_Housing.DB;
using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Presenters
{
    class CustomerListPresenter : Presenter
    {
        private IListSearchView listSearchView;
        private CustomerDataSource dataSource;

        public CustomerListPresenter(IListSearchView view) 
        {
            listSearchView = view;
            listSearchView.SetListTitle("Search Customers");

            dataSource = (CustomerDataSource) DataManager.getInstance().getDataSource(DataManager.Query.Customers);
            listSearchView.setDataGrid(dataSource.getDataset());

            listSearchView.ItemSelected += customerSelected;
        }


        public void Present()
        {
            listSearchView.Show();
        }

        private void customerSelected(int id)
        {
            var customer = dataSource.getCustomerById(id);
            var detailpresenter = new CustomerDetailPresenter(new CustomerDetailView(), customer);
            detailpresenter.Present();
        }
    }
}
