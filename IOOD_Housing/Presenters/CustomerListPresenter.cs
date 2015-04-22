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
        }


        public void Present()
        {
            listSearchView.Show();
        }
    }
}
