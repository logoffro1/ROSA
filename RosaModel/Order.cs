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

    }
}
          