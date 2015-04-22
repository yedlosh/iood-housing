using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using IOOD_Housing.Forms;

namespace IOOD_Housing.Presenters
{
    public class DashboardPresenter
    {
        public IDashboardView dashboardView;

        public DashboardPresenter(IDashboardView view) 
        {
            dashboardView = view;
            dashboardView.MenuStripEvent += OnMenuItemClick;
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
    }
}
