using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace IOOD_Housing.DB
{
    class CustomerDataSource
    {
        private static CustomerDataSource instance;
        private String conString = Properties.Settings.Default.connectionString;
        private OleDbConnection connection;

        private OleDbDataAdapter daCustomers;
        private DataSet dsCustomers;

        private CustomerDataSource() 
        {
            connection = new OleDbConnection(conString);
            connection.Open();
            string studentsTable = "Select * from Customer;";
            daCustomers = new OleDbDataAdapter(studentsTable, connection);
            dsCustomers = new DataSet("Customers");
            daCustomers.Fill(dsCustomers);
        }

        public static CustomerDataSource getInstance(){
            if(instance == null)
            {
                instance = new CustomerDataSource();
            }
            return instance;
        }

        public DataSet getCustomerDataset() {
            return dsCustomers;
        }

        public void updateCustomerDataset(string tableName) {
            daCustomers.Update(dsCustomers, tableName);
        }

    }
}
