using RosaDAL;
using RosaModel;
using System;

namespace RosaLogic
{
    /// <summary>
    /// The class that connects the DAO classes, where all the payment DB conections goes through here
    /// By Dewi
    /// </summary>
    public class Payment_Service
    {
        //PaymentDAO field to access it's methods
        PaymentDAO paymentDAO = new PaymentDAO();


        //Passes orderID to return a payment object, all of it's fields except for the feedback, paymentMethod, tip, Order's isPaid, Order's notes

            //Rather get ORDER from DB
            //Create payment object and fill with order
            //Send payment back with tip/paymentmethod

        public Payment GetPayment(int order_id)
        {
            try
            {
                //meantime keep in PAYMENTDAO

                //Gets order object from DB
                Order order = paymentDAO.GetOrderById(order_id);

                //Make a payment object which contains order
                Payment payment = new Payment()
                {
                    OrderId = order_id,
                    Order = order
                };

                //Go through the order's orderitems to get the total price and total vat of the order
                payment.TotalPrice = 0;
                payment.TotalVAT = 0;

                foreach(OrderItem item in order.ListOrderItems)
                {
                    payment.TotalPrice += item.menuItem.Price;
                    payment.TotalVAT += item.menuItem.VAT;
                }

                return payment;
            }
            catch(Exception e)
            {
                ErrorDAO error = new ErrorDAO($"Couldn't read the Payment from the Database! ({e.Message})");
                return null;
            }
        }

        //Inserts a new payment/bill in the database, and changes the status of the order to 'paid', and changes the table to available
        public void PayBill(Payment payment)
        {
            try
            {
                //Use DB transaction - when one thing goes bad, all tyransacions goes back to original state
                
                paymentDAO.UpdateOrderStatusToPaid(payment.OrderId);
                paymentDAO.UpdateToAvailableTable(payment.Order.Table.tableId);
                paymentDAO.InsertNewBill(payment);
            }
            catch(Exception e)
            {
                ErrorDAO error = new ErrorDAO($"Couldn't read the Payment from the Database! ({e.Message})");
            }
        }
    }
}
