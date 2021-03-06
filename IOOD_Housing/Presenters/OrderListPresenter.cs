﻿using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Presenters
{
    class OrderListPresenter : Presenter
    {
        private IListSearchView listSearchView;

        public OrderListPresenter(IListSearchView view)
        {
            listSearchView = view;
            listSearchView.SetListTitle("Search Orders");
        }

        public void Present()
        {
            listSearchView.Show();
        }
    }
}
