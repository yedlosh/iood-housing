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
    public interface IListSearchView : IViewForm
    { 
        void SetListTitle(string title);
    }

    public partial class ListSearchView : Form, IListSearchView
    {
        public ListSearchView()
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

        public void SetListTitle(string title)
        {
            this.Text = title;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
