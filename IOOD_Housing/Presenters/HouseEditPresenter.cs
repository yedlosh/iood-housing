using IOOD_Housing.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Presenters
{
    class HouseEditPresenter : Presenter
    {
        private IHouseEditView houseEditView;

        public HouseEditPresenter(IHouseEditView view)
        {
            houseEditView = view;

            houseEditView.SaveEvent += saveButtonEvent;
            houseEditView.CancelEvent += cancelButtonEvent;
        }

        public void Present()
        {
            houseEditView.Show();
        }

        public void saveButtonEvent()
        {

        }

        public void cancelButtonEvent()
        {
            houseEditView.Close();
        }
    }
}
