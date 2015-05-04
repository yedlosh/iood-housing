using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace IOOD_Housing.DB
{
    class DataSource
    { 
        private String conString = Properties.Settings.Default.connectionString;
        private OleDbConnection connection;

        protected OleDbDataAdapter dataAdapter;
        private OleDbCommandBuilder commandBuilder;
        protected DataSet dataSet;

        public DataSource(string query) 
        {
            connection = new OleDbConnection(conString);
            connection.Open();
            dataAdapter = new OleDbDataAdapter(query, connection);
            commandBuilder = new OleDbCommandBuilder(dataAdapter);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);        
        }

        public DataSet getDataset() {
            return dataSet;
        }

        public void updateSource() {
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            dataAdapter.Update(dataSet);
       } 
    }
}
