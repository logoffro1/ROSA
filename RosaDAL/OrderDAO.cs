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
    public class OrderDAO : Base
    {
        public List<Order> Db_Get_AllOrders()
        {
            //read orders from database
            string query = "select order_id,table_id,isPaid,notes from [order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> ReadTables(DataTable dataTable)
        {
     
            List<Order> Orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["order_id"]
                    //isPaid = (Boolean)dr["isPaid"],
                    //notes = (string)dr["notes"],
                };

                order.Table.tableId = (int)dr["table_id"];

                Orders.Add(order);
            }
            return Orders;
        }
        
        public void CreateNewOrder(int tableID,int employeeID)
        {
           // DateTime datetime = DateTime.Now;
           // string comment = "note";

            //string query = $"INSERT INTO [order](orderDate, table_id, employee_id, notes) VALUES ({datetime},{tableID},{employeeID},{comment}";
            string query = $"INSERT INTO [order](table_id,employee_id) VALUES ({tableID},{employeeID})";


            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);

        }
        public void RemoveOrder(int OrderID)
        {
            string query = $"DELETE FROM [order]  WHERE order_id = ({OrderID})";


            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);

        }

        //Gets full orderItem through the orderID
        //By Dewi
        public Order GetOrderByID(int orderID)
        {
            SqlCommand cmd = new SqlCommand(
                "select table_id, orderDate " +
                "from [order]" +
                "where order_id = @Id; ", conn);

            cmd.Parameters.AddWithValue("@order_id", orderID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return ReadRecord(reader);
            }

            throw new Exception("Could not read order!");
        }

        private Order ReadRecord(SqlDataReader reader)
        {
            Order order = new Order
            {
                DateTime = (DateTime)reader["orderDate"]
            };

            order.Table.tableId = (int)reader["table_id"];

            return order;
        }
    }
}
