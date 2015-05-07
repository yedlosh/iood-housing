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
        DataTable customerTable;

        public CustomerDataSource(string query) : base(query){
            customerTable = base.dataSet.Tables[0];
        }


        public void addCustomer(Customer customer) {
            
            DataRow custRow = customerTable.NewRow();
            customerToRow(customer, custRow);
            customerTable.Rows.Add(custRow);

            updateSource();
        }

        public List<Customer> getAllCustomers() 
        {
            var custList = new List<Customer>();

            foreach (DataRow row in customerTable.Rows)
            {
                custList.Add(rowToCustomer(row));
            }

            return custList;
        }

        public Customer getCustomerById(int id) {
            var rowSet = customerTable.Select("ID = " + id);
            if (rowSet != null && rowSet.Length > 0)
            {
                return rowToCustomer(rowSet[0]);
            }
            else return null;
        }

        public Customer getCustomerByIndex(int index)
        {
            var row = customerTable.Rows[index];
            return rowToCustomer(row);
        }

        public void updateCustomer(Customer customer) {
            var rowSet = customerTable.Select("ID = " + customer.Id);

            if (rowSet != null && rowSet.Length > 0)
            {
                customerToRow(customer, rowSet[0]);
            }

            updateSource();
        }

        public void deleteCustomer(Customer customer) { 
        
        }

        private Customer rowToCustomer(DataRow row) {
            var customer = new Customer();

            customer.Id = row.Field<int>(0);
            customer.Name = row.Field<string>(1);
            customer.Address = row.Field<string>(2);
            customer.City = row.Field<string>(3);
            customer.Postcode = row.Field<string>(4);
            customer.Email = row.Field<string>(5);
            customer.Phone = row.Field<string>(6);

            return customer;
        }

        private DataRow customerToRow(Customer customer, DataRow row) {
            if (customer.Id != 0) 
            {
                row["ID"] = customer.Id;
            }
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
