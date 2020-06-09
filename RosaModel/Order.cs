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
        public int OrderID { get; set; }
        public Boolean IsPaid { get; set; }
        public string Notes { get; set; }
        public DateTime DateTime { get; set; }
        public Table Table { get; set; }      //return table object
        public List<OrderItem> ListOrderItems { get; set; }

        public Order(int orderID, bool isPaid, string notes, DateTime dateTime, Table table, List<OrderItem> listOrderItems)
        {
            OrderID = orderID;
            IsPaid = isPaid;
            Notes = notes ?? throw new ArgumentNullException(nameof(notes));
            DateTime = dateTime;
            Table = table;
            ListOrderItems = listOrderItems ?? throw new ArgumentNullException(nameof(listOrderItems));
        }
        public Order()
        {
          Table = new Table();
        }
    }
}
          