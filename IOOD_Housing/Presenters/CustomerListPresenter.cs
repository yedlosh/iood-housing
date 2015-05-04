using IOOD_Housing.DB;
using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Presenters
{
    class CustomerListPresenter : Presenter
    {
        private IListSearchView listSearchView;

        public CustomerListPresenter(IListSearchView view) 
        {
            listSearchView = view;
            listSearchView.SetListTitle("Search Customers");

            DataSource dataSource = DataManager.getInstance().getDataSource(DataManager.Query.Customers);
            listSearchView.setDataGrid(dataSource.getDataset());
        }


        public void Present()
        {
            listSearchView.Show();
        }
    }
}
