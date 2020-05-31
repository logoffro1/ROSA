using System;

namespace RosaModel
{
    /// <summary>
    /// Payment model
    /// By Dewi
    /// </summary>
    public class Payment 
    {
       
        //All properties of the Payment
        public int OrderId { get; set; }     
        public Order Order { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalVAT { get; set; }        
        public decimal TipAmount { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }     
        public string Feedback { get; set; }     


        //Constructor with all fields used
        //public Payment(Order order, decimal totalPrice, decimal totalVAT, decimal tipAmount, PaymentMethodEnum paymentMethod, string feedback)
        //{
        //    Order = order;
        //    TotalPrice = totalPrice;
        //    TotalVAT = totalVAT;
        //    TipAmount = tipAmount;
        //    PaymentMethod = paymentMethod;
        //    Feedback = feedback;
        //}

        //Constuctor
        public Payment()
        {
            
        }
    }
}
