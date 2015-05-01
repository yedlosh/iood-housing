using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace IOOD_Housing.Presenters
{
    class CustomerListPresenter : Presenter
    {
        private IListSearchView listSearchView;
        OleDbConnection dbCon;
        public CustomerListPresenter(IListSearchView view) 
        {
            listSearchView = view;
            listSearchView.SetListTitle("Search Customers");
            dbCon.Open();
            String sql = "select * from customers";

            OleDbCommand dbCmd = new OleDbCommand(sql, dbCon);
            OleDbDataReader dbReader = dbCmd.ExecuteReader();

            string customerList = "";
            while (dbReader.Read())
            {
 
            }

        }


        public void Present()
        {
            listSearchView.Show();
        }
    }
}
