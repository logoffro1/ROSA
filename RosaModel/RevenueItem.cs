using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RosaModel
{
    public class RevenueItem
    {
        public string orderItems;     // name of the item
        public string menuItems;        
        public int sales;       // amount of times the item was sold
        public float totalPrice;     // the price of the item
        
        public float Turnover   // total income from this item 
        {
            get
            {
                return sales * totalPrice;
            }
        }
    }
}
