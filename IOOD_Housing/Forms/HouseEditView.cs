using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IOOD_Housing.Forms
{
    public interface IHouseEditView : IViewForm
    {


        event Action SaveEvent;
        event Action CancelEvent;
    
    }
    public partial class HouseEditView : Form, IHouseEditView
    {

        public event Action SaveEvent;
        public event Action CancelEvent;

        public HouseEditView()
        {
            InitializeComponent();
        }

        void IViewForm.Close()
        {
            this.Close();
        }

        void IViewForm.Show()
        {
            this.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (SaveEvent != null)
            {
                SaveEvent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (CancelEvent != null)
            {
                CancelEvent();
            }
        }
    }
}
