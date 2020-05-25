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
    /// <summary>
    /// 
    /// Class that retrieves all data needed from the payment table,
    /// or that retrives data needed for the payment class
    /// By Dewi
    /// </summary>
    public class PaymentDAO : Base
    {

        //Returns the table id and order date from the class order 
        //to put in the payment object
        public Payment GetById(int order_id)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT O.table_id, O.orderDate " +
                "FROM [order] AS O " +
                "WHERE O.order_id = @order_id", conn);

            cmd.Parameters.AddWithValue("@order_id", order_id);
            SqlDataReader reader = cmd.ExecuteReader();
            Payment payment = null;

            if (reader.Read())
            {
                payment = ReadRecord(reader);
            }
            return payment;
        }


        //Uses out parameters to obtain the total price of an order, with it's vat
        //All calculated through SQL
        //Out parameters are used because the payment object is not passed here
        public void GetPriceVATById(int order_id, out decimal paymentTotalPrice, out decimal paymentTotalVAT)
        {
            SqlCommand cmd = new SqlCommand(
               "SELECT SUM(O.amount * MI.price) AS totalPrice, SUM(O.amount * (MI.price * MC.vat)) AS totalVAT " +
               "FROM orderItems AS O " +
               "JOIN menuItem AS MI ON O.menuItem_id = MI.menuItem_id " +
               "JOIN menuCategory AS MC ON MI.menuCategory_id = MC.menuCategory_id  " +
               "WHERE O.order_id = @order_id;" , conn);

            cmd.Parameters.AddWithValue("@order_id", order_id);
            SqlDataReader reader = cmd.ExecuteReader();
            paymentTotalPrice = -1;
            paymentTotalVAT = -1;

            if (reader.Read())
            {
                ReadPriceVAT(reader, out paymentTotalPrice, out paymentTotalVAT);
            }

        }

        //Reads the total price and total VAT of a order from the databse table
        private void ReadPriceVAT(SqlDataReader reader, out decimal paymentTotalPrice, out decimal paymentTotalVAT)
        {
            paymentTotalPrice = (decimal)reader["totalPrice"];
            paymentTotalVAT = (decimal)reader["totalVAT"];
        }

        //Reads and returns a payment object with the table id and date of the order, read from a database table
        private Payment ReadRecord(SqlDataReader reader)
        {
            Payment payment = new Payment()
            {
                Order = new Order()
                {
                    table = (int)reader["table_id"],
                    dateTime = (DateTime)reader["orderDate"]
                },
            };

            return payment;
        }

        //Changed the order to Paid (Billed) in the database
        public void UpdateStatusToBilled(int order_id)
        {

            SqlCommand cmd = new SqlCommand(
                "update [order] " +
                "set isPaid = 1" +
                "where order_id = @Id; ", conn);

            cmd.Parameters.AddWithValue("@Id", order_id);

            cmd.ExecuteReader();
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

            cmd.ExecuteReader(); //wasnt there anotehr method, one that doesnt return a value? ask tami

        }
    }
}
