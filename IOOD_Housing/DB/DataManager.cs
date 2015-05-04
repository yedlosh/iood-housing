using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOOD_Housing.DB
{
    /// <summary>
    /// This class serves as a factory and pool for DataSource objects.
    /// </summary>
    class DataManager
    {
        private static DataManager instance;

        Dictionary<Query, DataSource> dataSources;

        public enum Query 
        { 
            Customers,
            Orders,
            Houses,
            Schedule
        }

        private Dictionary<Query, string> queries = new Dictionary<Query, string>(){
            {Query.Customers, "Select * from Customers;"},
            {Query.Orders, "Select * from Orders;"},
            {Query.Houses, "Select * from Houses;"},
            {Query.Schedule, "SELECT Schedule.orderID, Schedule.startDate, Schedule.endDate, Houses.houseName, Customers.custName " +
                             "FROM ((Customers INNER JOIN [Orders] ON Customers.[ID] = Orders.[customerID]) " +
                             "INNER JOIN Houses ON Houses.[ID] = Orders.[houseID]) " +
                             "INNER JOIN Schedule ON Orders.[ID] = Schedule.[orderID];"}
        };

        private DataManager() 
        {
            dataSources = new Dictionary<Query, DataSource>();
        }

        public static DataManager getInstance()
        {
            if (instance == null)
            {
                instance = new DataManager();
            }
            return instance;
        }

        public DataSource getDataSource(Query query) { 
            DataSource dataSource;
            if (dataSources.TryGetValue(query, out dataSource))
            {
                return dataSource;
            }
            else 
            {
                string queryString;
                if (queries.TryGetValue(query, out queryString))
                {
                    switch (query) {
                        case(Query.Customers):
                            dataSource = new CustomerDataSource(queryString);
                            break;
                        default:
                            dataSource = new DataSource(queryString);
                            break;
                    }
                    dataSources.Add(query, dataSource);
                    return dataSource;
                }

                return null;
            }
        }
    }
}
