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
    /// <summary>
    /// Class that retrieves all data needed from the order item table,
    /// or that retrives data needed for the order item class
    /// </summary>
    public class OrderItemDAO : Base
    {

        //Gets the list of order items from an order, through the order id
        //By Dewi
        public List<OrderItem> GetOrderItemsById(int order_id)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT OT.order_ID, M.itemName, OT.amount, OT.[status], (M.price * OT.amount) AS price " +
                "FROM orderItems AS OT " +
                "JOIN menuItem AS M ON OT.menuItem_id = M.menuItem_id " +
                "WHERE Ot.order_id = @order_id; ", conn);

            cmd.Parameters.AddWithValue("@order_id", order_id);
            SqlDataReader reader = cmd.ExecuteReader();
            List<OrderItem> orderItems = new List<OrderItem>();
                    while (reader.Read())
            {
                orderItems.Add(ReadOrderItemRecord(reader));
            }

            return orderItems;
        }

        //Reads the order item record from the database
        //By Dewi
        private OrderItem ReadOrderItemRecord(SqlDataReader reader)
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
    }

}



