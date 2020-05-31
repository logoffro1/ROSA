using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{

    public class Order
    {
        //upoercase
        public int orderID { get; set; }
        public Boolean isPaid { get; set; }
        public string notes { get; set; }
        public DateTime dateTime { get; set; }
        public int table { get; set; }      //return table object
        public List<OrderItem> listOrderItems { get; set; }

        public Order(int orderID, bool isPaid, string notes, DateTime dateTime, int table, List<OrderItem> listOrderItems)
        {
            this.orderID = orderID;
            this.isPaid = isPaid;
            this.notes = notes ?? throw new ArgumentNullException(nameof(notes));
            this.dateTime = dateTime;
            this.table = table;
            this.listOrderItems = listOrderItems ?? throw new ArgumentNullException(nameof(listOrderItems));
        }
        public Order()
        {

        }
    }
}
          