using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using IOOD_Housing.Forms;

namespace IOOD_Housing
{
    public class MyConn
    {   
        OleDbConnection dbCon;

        
        static String dbpathname = @"E:\Msc Computer Science\object oriented design\student.accdb";
        String connection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + dbpathname;

        private OleDbConnection conn
        {
            
            dbCon = new OleDbConnection(connection);
        }

        public void Open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public void Close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}
