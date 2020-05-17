using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class Payment 
    {
        public int orderId;     //should i have this?
        public Order order;
        public decimal totalPrice;
        public decimal totalVAT;        
        public decimal tipAmount;
        public PaymentMethodEnum paymentMethod;        //dont need to add Enum
        public string comments;     


        public Payment(Order order, decimal totalPrice, decimal totalVAT, decimal tipAmount, PaymentMethodEnum paymentMethod, string comments)
        {
            this.order = order;
            this.totalPrice = totalPrice;
            this.totalVAT = totalVAT;
            this.tipAmount = tipAmount;
            this.paymentMethod = paymentMethod;
            this.comments = comments;
        }


        public Payment()
        {

        }
    }
}
