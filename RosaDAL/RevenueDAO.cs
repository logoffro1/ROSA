using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaModel;

namespace RosaDAL
{
    public class RevenueDAO : Base
    {
        public List<RevenueItem> GetOrderItemsSalesByPeriod(DateTime startDate, DateTime endDate)
        {
            //putting the dates at the end and start of the day
            TimeSpan ts = new TimeSpan(00, 00, 00);
            startDate = startDate.Date + ts;
            ts = new TimeSpan(23, 59, 59);
            endDate = endDate.Date + ts;
            //creating the query to get the item name, sales, cost and amount of times it was bought by a unique customer
            string query = " ";
            //adding the start and end date parameters
            SqlParameter[] sqlParameters = new SqlParameter[0];
            {
                new SqlParameter("@start", startDate);
                new SqlParameter("@end", endDate);
            };
            //execute the query and read and return the results
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        List<RevenueItem> ReadTables(DataTable dataTable)
        {
            //return if no results
            if (dataTable == null)
                return null;
            //create empty list for the results
            List<RevenueItem> items = new List<RevenueItem>();
            //loop over each row and change it to a revenue item
            foreach (DataRow dr in dataTable.Rows)
            {
                items.Add(new RevenueItem()
                {
                    orderItems = (string)dr["orderItems"],
                    menuItems = (string) dr["menuItems"],
                    sales = (int)dr["sales"],
                    cost = float.Parse(dr["cost"].ToString()),
                    boughtByCustomer = (int)dr["boughtByCustomers"]
                });
            }

            return items;
        }
    }
}
