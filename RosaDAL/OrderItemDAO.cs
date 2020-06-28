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
                "SELECT OT.order_ID, M.itemName, OT.amount, OT.[status], " + 
                "(M.price * OT.amount) AS price, MC.menuCategory_id, [order].[orderDate], " +
                "OT.orderItems_id, [order].[notes], [order].[table_id] " +
                "FROM orderItems AS OT " +
                "JOIN menuItem AS M ON OT.menuItem_id = M.menuItem_id " +
                "JOIN menuCategory AS MC ON M.menuCategory_id = MC.menuCategory_id " +
                "JOIN [order] ON OT.order_id = [order].[order_id] " +
                "WHERE OT.order_id = @order_id;", conn);
            cmd.Parameters.AddWithValue("@order_id", order_id);  
           
            SqlDataReader reader = cmd.ExecuteReader();
            List<OrderItem> orderItems = new List<OrderItem>();

            while (reader.Read())
            {
                orderItems.Add(ReadOrderItemRecord(reader));
            }

            return orderItems;
        }
        //By Liv
        public void UpdateTableOrder(int id, int status)  // Updates all ListViews For Bar and Kitchen
        {
            SqlCommand cmd = new SqlCommand("UPDATE [orderItems] SET status = @status" +
            " WHERE orderItems_id = @orderitemsid;", conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderitemsid", id);
            cmd.ExecuteReader();
        }
        //By Liv 
        public List<OrderItem> GetOrderedItemsKitchenOrBar()// Gets Items from a order
        {
            SqlCommand cmd = new SqlCommand("SELECT orderItems.order_id, menuItem.itemName, orderItems.amount, " +
                "orderItems.[status], orderItems.[orderItems_id], " +
                "([menuItem].[price] * orderItems.amount) AS price, menuCategory.menuCategory_id, " +
                "[order].[table_id], [order].[notes], [order].[orderDate] " +
                "FROM orderItems " +
                "JOIN [menuItem] ON orderItems.menuItem_id = menuItem.menuItem_id " +
                "JOIN [menuCategory] ON menuItem.menuCategory_id = menuCategory.menuCategory_id " +
                "JOIN [order] ON orderItems.order_id = [order].[order_id] " +
                "WHERE[order].[orderDate] > GETDATE()" +
                "ORDER BY[order].[orderDate];", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<OrderItem> temp = new List<OrderItem>();
            while (reader.Read())
            {
                temp.Add(ReadOrderItemRecord(reader));
            }
            return temp;
        }
        //Reads the order item record from the database
        //By Dewi and Liv
        private OrderItem ReadOrderItemRecord(SqlDataReader reader)
        {
            OrderItem orderItem = new OrderItem()
            {
                menuItem = new MenuItem()
                {
                    Name = reader["itemName"].ToString(),
                    Price = (decimal)reader["price"],
                    menuCat = (int)reader["menuCategory_id"]
                },

                order = new Order()
                {
                    DateTime = DateTime.Parse(reader["orderDate"].ToString())
                },

                amount = (int)reader["amount"],
                status = (StatusEnum)(int)reader["status"],
                orderItems_id = (int)reader["orderItems_id"]
            };

            //Table in the order class
            orderItem.order.Table.tableId = (int)reader["table_id"];

            if (reader.IsDBNull(8)) // Coloumn 8 is the Notes from the DB 
            {
                orderItem.order.Notes = "none";
            }
            else
            {
                orderItem.order.Notes = (string)reader["notes"];
            }
            return orderItem;
        }
    }

}



