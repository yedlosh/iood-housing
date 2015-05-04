using IOOD_Housing.DB;
using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Presenters
{
    class HouseListPresenter : Presenter
    {
        private IListSearchView listSearchView;

        public HouseListPresenter(IListSearchView view)
        {
            listSearchView = view;
            listSearchView.SetListTitle("Search Houses");

            DataSource dataSource = DataManager.getInstance().getDataSource(DataManager.Query.Houses);
            listSearchView.setDataGrid(dataSource.getDataset());
        }

        public void Present()
        {
            listSearchView.Show();
        }
    }
}
