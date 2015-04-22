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
    
    }
    public partial class HouseEditView : Form, IHouseEditView
    {
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
    }
}
