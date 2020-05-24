using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaModel;
using System.Configuration;
namespace RosaDAL
{
    public class MenuItemDAO : Base
    {
        public List<MenuItem> Db_Get_All_MenuItem()
        {
            string query = "SELECT [orderDate], [table_id], [price], [amount], [itemName], [status], [notes], [orderItems_id], [menuCategory_id], [orderitems].[order_id] FROM [orderItems] JOIN [order] ON orderItems.order_id = [order].order_id JOIN [menuItem] ON orderItems.menuItem_id = menuItem.menuItem_id;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public MenuItem GetFromTableTheStatus(int status)
        {
            SqlCommand cmd = new SqlCommand("SELECT [orderDate], [table_id], [price], [amount], [itemName], [status], [notes], [orderItems_id], [menuCategory_id], [orderitems].[order_id] FROM [orderitems] JOIN [order] ON orderItems.order_id = [order].order_id JOIN [menuItem] ON orderItems.menuItem_id = menuItem.menuItem_id WHERE [status] = @status", conn);
            cmd.Parameters.AddWithValue("@status", status);
            SqlDataReader reader = cmd.ExecuteReader();
            MenuItem temp = null;
            if (reader.Read())
            {
                temp = ReadTable(reader);
            }
            return temp;
        }
        public void UpdateTableOrder(MenuItem table, int status)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [orderItems] SET status = @status WHERE order_id = @orderid; ", conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderId", table.orderID);

            cmd.ExecuteReader();
        }
        private MenuItem ReadTable(SqlDataReader reader)
        {
            MenuItem itemtemp = new MenuItem()
            {
                TableId = (int)reader["table_id"],
                dateSold = DateTime.Parse(reader["orderDate"].ToString()),
                Price = (decimal)reader["price"],
                Name = (string)reader["itemName"],
                menuCat = (int)reader["menuCategory_id"],
                Quantity = (int)reader["amount"],
                orderID = (int)reader["order_id"],
                Status = (StatusEnum)(int)reader["status"],
                Note = (string)reader["notes"]
            };
            return itemtemp;
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItem = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem temp = new MenuItem()
                {
                    TableId = (int)dr["table_id"],
                    dateSold = DateTime.Parse(dr["orderDate"].ToString()),
                    Price = (decimal)dr["price"],
                    Name = (string)dr["itemName"],
                    menuCat = (int)dr["menuCategory_id"],
                    Quantity = (int)dr["amount"],
                    orderID = (int)dr["order_id"],
                    Status = (StatusEnum)(int)dr["status"]

                };
                if (dr.IsNull("notes"))
                {
                    temp.Note = "none";
                }
                else
                {
                    temp.Note = (string)dr["notes"];
                }

                menuItem.Add(temp);
            }

            return menuItem;
        }
    }
}
