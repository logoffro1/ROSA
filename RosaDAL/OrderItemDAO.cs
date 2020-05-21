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
    public class OrderItemDAO : Base
    {
        public List<OrderItem> GetById(int order_id)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT OT.order_ID, M.itemName, OT.amount, (M.price * OT.amount) AS price " +
                "FROM orderItems AS OT " +
                "JOIN menuItem AS M ON OT.menuItem_id = M.menuItem_id " +
                "WHERE Ot.order_id = @order_id; ", conn);

            cmd.Parameters.AddWithValue("@order_id", order_id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<OrderItem> orderItems = new List<OrderItem>();

            while (reader.Read())
            {
                orderItems.Add(ReadRecord(reader));
            }

            return orderItems;
        }
        private OrderItem ReadRecord(SqlDataReader reader)
        {
            OrderItem orderItem = new OrderItem()
            {
                menuItem = new MenuItem()
                {
                    Name = reader["itemName"].ToString(),
                    Price = (decimal)reader["price"]
                },
                amount = (int)reader["amount"],
                status = (StatusEnum)(int)reader["status"]
            };

            return orderItem;
        } 




        public List<OrderItem> ReadTables(DataTable dataTable)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT orderItems_id,order_id,menuitem_id,amount" +
                "FROM orderItems AS OT " +
                "WHERE order_id = @order_id; ", conn);

            List<OrderItem> OrderItems = new List<OrderItem>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    OrderItem orderitem = new OrderItem()
                    {
                        orderItems_id = (int)dr["orderItems_id"],
                        orderID = (int)dr["order_id"],
                        amount = (int)dr["amount"],
                        menuItem = (MenuItem)dr["menuItem_id"]
                    };

                    OrderItems.Add(orderitem);
                }
                return OrderItems;
        }
    }

}



