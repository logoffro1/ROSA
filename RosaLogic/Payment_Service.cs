using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaDAL;
using RosaModel;

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


        //Passes orderID to return a payment object, all of it's fields except for the feedback and tip
        public Payment GetPayment(int order_id)
        {
            try
            {
                Payment payment = paymentDAO.GetById(order_id);
                paymentDAO.GetPriceVATById(order_id, out decimal outTotalPrice, out decimal outVATPrice);

                payment.TotalPrice = outTotalPrice;
                payment.TotalVAT = outVATPrice;

                return payment;
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Payment from the Database!");
                return null;
            }
        }

        //Inserts a new payment/bill in the database, and changes the status of the order to 'paid'
        public void PayBill(Payment payment)
        {
            try
            {
                paymentDAO.UpdateStatusToBilled(payment.OrderId);
                paymentDAO.InsertNewBill(payment);
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Payment from the Database!");
            }
        }
    }
}
