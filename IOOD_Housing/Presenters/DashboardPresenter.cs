using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using IOOD_Housing.Forms;
using IOOD_Housing.DB;
using System.Data;

namespace IOOD_Housing.Presenters
{
    public class DashboardPresenter
    {
        public IDashboardView dashboardView;
        private DataSource dataSource;

        public DashboardPresenter(IDashboardView view) 
        {
            dashboardView = view;
            dashboardView.MenuStripEvent += OnMenuItemClick;

            dataSource = DataManager.getInstance().getDataSource(DataManager.Query.Schedule);
            dashboardView.setDataGrid(dataSource.getDataset());

            dataSource.getDataset().Tables[0].RowChanged += dataRowChanged;
            updateOrderStatus();
        }

        private void OnMenuItemClick(DashboardView.MenuItems item){
            switch (item)
            { 
                case DashboardView.MenuItems.Exit:
                    Application.Exit();
                    break;
                case DashboardView.MenuItems.NewCustomer:
                    Presenter newCustomerPresenter = new CustomerEditPresenter(new CustomerEditView());
                    newCustomerPresenter.Present();
                    break;
                case DashboardView.MenuItems.NewHouse:
                    Presenter newHousePresenter = new HouseEditPresenter(new HouseEditView());
                    newHousePresenter.Present();
                    break;
                case DashboardView.MenuItems.SearchCustomers:
                    Presenter customerListPresenter = new CustomerListPresenter(new ListSearchView());
                    customerListPresenter.Present();
                    break;
                case DashboardView.MenuItems.SearchHouses:
                    Presenter houseListPresenter = new HouseListPresenter(new ListSearchView());
                    houseListPresenter.Present();
                    break;
                case DashboardView.MenuItems.SearchOrders:
                    Presenter orderListPresenter = new OrderListPresenter(new ListSearchView());
                    orderListPresenter.Present();
                    break;
                default:
                    throw new ArgumentException("DashboardPresenter: Unknown menu item selected!");
            }
        }

        private void dataRowChanged(Object sender, DataRowChangeEventArgs e) 
        {
            updateOrderStatus();
        }
        private void updateOrderStatus()
        {
            DataRowCollection rows = dataSource.getDataset().Tables[0].Rows;
            dashboardView.OrdersCountLabel = rows.Count.ToString();

            DateTime endDate = DateTime.Parse(rows[rows.Count - 1]["endDate"].ToString());
            dashboardView.OrdersEndDateLabel = endDate.ToString("MM/dd/yyyy");
        }
    }
}
