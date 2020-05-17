using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaDAL;
using RosaModel;

namespace RosaLogic
{
    public class Payment_Service
    {
        PaymentDAO paymentDAO = new PaymentDAO();
        public List<Payment> GetAllPayments()
        {
            try
            {
                return paymentDAO.Db_Get_AllPayments();
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Payment from the Database!");
                return null;
            }
        }

        public Payment GetPayment(int order_id)
        {
            try
            {
                Payment payment = paymentDAO.GetById(order_id);
                paymentDAO.GetPriceVATById(order_id, out payment.totalPrice, out payment.totalVAT);

                return payment;
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Payment from the Database!");
                return null;
            }
        }

        public void PayBill(Payment payment)
        {
            try
            {
                paymentDAO.UpdateStatusToBilled(payment.orderId);
                paymentDAO.InsertNewBill(payment);
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Payment from the Database!");
            }
        }
    }
}
