using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RosaModel;

namespace RosaDAL
{
    /// <summary>
    /// Class that retrieves all data needed from the payment table,
    /// or that retrives data needed for the payment class
    /// 
    /// Note: In the DB, payment is called bill. Bill and payment is the same.
    /// 
    /// By Dewi
    /// </summary>
    public class PaymentDAO : Base
    {
        //change method names!

        public Order GetOrderById(int order_id)
        {
            Order order = GetById(order_id);
            order.listOrderItems = GetOrderItemsById(order_id);

            return order;
        }


        //Returns all data about the order expect the order items
        //---- technically in OrderDAO?
        private Order GetById(int order_id)     //---------- what about an employee?
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT table_id, orderDate, notes, isPaid " +
                "FROM [order] " +
                "WHERE order_id = @order_id", conn);

            cmd.Parameters.AddWithValue("@order_id", order_id);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order = null;

            if (reader.Read())
            {
                order = ReadRecord(reader);
            }

            order.orderID = order_id;
            return order;
        }

        //Reads and returns a payment object with the table id and date of the order, read from a database table
        private Order ReadRecord(SqlDataReader reader)
        {
            return new Order()
            {
                table = (int)reader["table_id"],
                dateTime = (DateTime)reader["orderDate"],
                notes = reader["notes"].ToString(),
                isPaid = (bool)reader["isPaid"]
            };
        }


        //Gets the list of order items from an order, through the order id
        //---- techincally in OrderItem DAO?
        private List<OrderItem> GetOrderItemsById(int order_id)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT OT.order_ID, M.itemName, OT.amount, OT.[status], (M.price * OT.amount) AS price, MC.vat " +
                "FROM orderItems AS OT " +
                "JOIN menuItem AS M ON OT.menuItem_id = M.menuItem_id " +
                "JOIN menuCategory AS MC ON M.menuCategory_id = MC.menuCategory_id " +
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
        private OrderItem ReadOrderItemRecord(SqlDataReader reader)
        {
            OrderItem orderItem = new OrderItem()
            {
                menuItem = new MenuItem()
                {
                    Name = reader["itemName"].ToString(),
                    Price = (decimal)reader["price"],
                    VAT = (decimal)reader["vat"]
                },
                amount = (int)reader["amount"],
                status = (StatusEnum)(int)reader["status"]
            };

            return orderItem;
        }


        //Below is when one wants to pay for the order, thus the DB needs to change to accomodate the payment

        //Changed the order to Paid (Billed) in the database
        public void UpdateOrderStatusToPaid(int order_id)      //Change method name? eg. CloseOrder
        {
            SqlCommand cmd = new SqlCommand(
                "update [order] " +
                "set isPaid = 1" +
                "where order_id = @Id; ", conn);

            cmd.Parameters.AddWithValue("@Id", order_id);

            if (cmd.ExecuteNonQuery() == 0)              
                throw new Exception("Could not update order status to isPaid.");
        }


        //Changed the table to available in the databse
        public void UpdateToAvailableTable(int table_id)
        {
            SqlCommand cmd = new SqlCommand(
                "update [table] " +
                "set isAvailable = 1" +
                "where table_id = @Id; ", conn);

            cmd.Parameters.AddWithValue("@Id", table_id);

            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Could not update table status to available.");

        }
        //Inserts the payment/bill in the database when the order is finished
        public void InsertNewBill(Payment payment)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO bill VALUES " +
                "(@orderId, @totalPrice, @tipAmount, @paymentMethod, @comments, @totalVAT); ", conn);

            cmd.Parameters.AddWithValue("@orderId", payment.OrderId);
            cmd.Parameters.AddWithValue("@totalPrice", payment.TotalPrice);
            cmd.Parameters.AddWithValue("@tipAmount", payment.TipAmount);
            cmd.Parameters.AddWithValue("@paymentMethod", payment.PaymentMethod.ToString());
            cmd.Parameters.AddWithValue("@comments", payment.Feedback);
            cmd.Parameters.AddWithValue("@totalVAT", payment.TotalVAT);

            if (cmd.ExecuteNonQuery() == 0)
                throw new Exception("Could not insert new bill in the database.");
        }
    }
}
