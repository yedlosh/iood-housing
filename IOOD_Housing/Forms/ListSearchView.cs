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
        void setDataGrid(DataSet data);
    }

    public partial class ListSearchView : Form, IListSearchView
    {
        private DataTable dataTable;

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

        public void setDataGrid(DataSet data)
        {
            dataTable = data.Tables[0];
            dgv_list.DataSource = dataTable;
            

            for (int x = 0; x < dgv_list.ColumnCount; x++)
            {
                dgv_list.Columns[x].ReadOnly = true;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataColumn column in dataTable.Columns)
            {
                sb.AppendFormat("CONVERT({0}, System.String) Like '%{1}%' OR ", column.ColumnName, txt_searchBox.Text.Trim());
            }

            sb.Remove(sb.Length - 3, 3);
            dataTable.DefaultView.RowFilter = sb.ToString();
        }
    }
}
