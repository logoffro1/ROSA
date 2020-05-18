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
    public class PaymentDAO : Base
    {
        public List<Payment> Db_Get_AllPayments()
        {
            //read employees from database
            string query =
                "SELECT O.order_id, O.table_id, O.orderDate, B.totalPrice, B.comments, B.paymentMethod, B.tipAmount, M.itemName, M.price " +
                "FROM bill AS B " +
                "JOIN [order] AS O ON B.order_id = O.order_id " +
                "JOIN listMenuItems AS L ON B.order_id = L.order_id " +
                "JOIN menuItem AS M ON L.menuItem_id = M.menuItem_id; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Table Id and OrderDate
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

        private void ReadPriceVAT(SqlDataReader reader, out decimal paymentTotalPrice, out decimal paymentTotalVAT)
        {
            paymentTotalPrice = (decimal)reader["totalPrice"];
            paymentTotalVAT = (decimal)reader["totalVAT"];
        }

        private Payment ReadRecord(SqlDataReader reader)
        {
            Payment payment = new Payment()
            {
                order = new Order()
                {
                    table = (int)reader["table_id"],
                    dateTime = (DateTime)reader["orderDate"]
                },
            };

            return payment;
        }

        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();
            Payment payment = new Payment();

            int index = -1;
            int temp;
            bool newOrder;
            int rowNum = 1;

            foreach (DataRow dr in dataTable.Rows)
            {
                rowNum++;


                temp = (int)dr["order_id"];

                newOrder = temp != index;

                if (newOrder)
                {
                    if (index != -1)
                        payments.Add(payment);

                    payment = new Payment() {

                        order = new Order()
                        {
                            table = (int)dr["table_id"],
                            dateTime = (DateTime)dr["orderDate"],
                            //cash
                            listMenuItems = new List<MenuItem>()
                            
                        }
                    };
                }

                MenuItem menu = new MenuItem()
                {
                    Name = dr["itemName"].ToString(),
                    Price = (decimal)dr["price"]
                };

                payment.order.listMenuItems.Add(menu);

                index = temp;

                if (rowNum > dataTable.Rows.Count)
                {
                    payments.Add(payment);
                }
            }


            return payments;
        }

        public void UpdateStatusToBilled(int order_id)
        {

            SqlCommand cmd = new SqlCommand(
                "update [order] " +
                "set status = 5" +
                "where order_id = @Id; ", conn);

            cmd.Parameters.AddWithValue("@Id", order_id);

            cmd.ExecuteReader();
        }

        public void InsertNewBill(Payment payment)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO bill VALUES " +
                "(@orderId, @totalPrice, @tipAmount, @paymentMethod, @comments, @totalVAT); ", conn);

            cmd.Parameters.AddWithValue("@orderId", payment.orderId);
            cmd.Parameters.AddWithValue("@totalPrice", payment.totalPrice);
            cmd.Parameters.AddWithValue("@tipAmount", payment.tipAmount);
            cmd.Parameters.AddWithValue("@paymentMethod", payment.paymentMethod.ToString());
            cmd.Parameters.AddWithValue("@comments", payment.comments);
            cmd.Parameters.AddWithValue("@totalVAT", payment.totalVAT);

            cmd.ExecuteReader(); //wasnt there anotehr method, one that doesnt return a value? ask tami

        }
    }
}
