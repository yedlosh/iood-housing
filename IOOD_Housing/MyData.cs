using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace IOOD_Housing
{
    public class MyData
    {
        MyConn myconn = new MyConn();

        public OleDbDataAdapter customers;

        public DataSet customer;

        public OleDbDataAdapter makeOrder;

        public MyData()
        {
 
        }
        public void createDataAdapter()
        {
            makeOrder = new OleDbDataAdapter();

            makeOrder.SelectCommand = new OleDbCommand("SELECT * FROM ",myconn.conn);
        }
    }
}
