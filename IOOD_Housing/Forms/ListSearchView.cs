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

        event Action<int> ItemSelected;
    }

    public partial class ListSearchView : Form, IListSearchView
    {
        public event Action<int> ItemSelected;

        private DataTable dataTable;

        public ListSearchView()
        {
            InitializeComponent();
        }

        void IViewForm.Close()
        {
            this.Close();
        }

        void IViewForm.Hide()
        {
            this.Hide();
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

            dgv_list.AllowUserToDeleteRows = false;
            dgv_list.AllowUserToAddRows = false;

            for (int x = 0; x < dgv_list.ColumnCount; x++)
            {
                dgv_list.Columns[x].ReadOnly = true;
            }

            dataTable.DefaultView.RowFilter = "";
            setTotalLabel();
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
            setTotalLabel();
        }

        private void setTotalLabel() 
        {
            lbl_total_out.Text = dataTable.DefaultView.Count.ToString();
        }

        private void dgv_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            itemSelected(Convert.ToInt32(dgv_list.CurrentCell.OwningRow.Cells[0].Value));

        }

        private void dgv_list_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            itemSelected(Convert.ToInt32(dgv_list.SelectedRows[0].Cells[0].Value));
        }

        private void itemSelected(int id)
        {
            if (ItemSelected != null)
            {
                ItemSelected(id);
            }
        }
    }
}
