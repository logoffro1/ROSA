using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{

    public class Order
    {
        public int orderID { get; set; }
        public Boolean isPaid { get; set; }
        public string notes { get; set; }
        public DateTime dateTime { get; set; }
        public int table { get; set; }
        public List<MenuItem> listMenuItems { get; set; }
    }
}
          