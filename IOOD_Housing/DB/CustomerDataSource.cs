using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace IOOD_Housing.DB
{
    class CustomerDataSource : DataSource
    {

        public CustomerDataSource(string query) : base(query){}


        public void addCustomer(Customer customer) {
            DataTable customerTable = base.dataSet.Tables[0];
            DataRow custRow = customerTable.NewRow();
            customerToRow(customer, custRow);
            customerTable.Rows.Add(custRow);

            updateSource();
        }

        public void updateCustomer(Customer customer) { 
        
        }

        public void deleteCustomer(Customer customer) { 
        
        }

        private DataRow customerToRow(Customer customer, DataRow row) {           
            row["custName"] = customer.Name;
            row["address"] = customer.Address;
            row["city"] = customer.City;
            row["postcode"] = customer.Postcode;
            row["email"] = customer.Email;
            row["phone"] = customer.Phone;

            return row;
        }
    }
}
