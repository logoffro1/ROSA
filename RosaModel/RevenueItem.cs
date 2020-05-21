using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class RevenueItem
    {
        public string orderItems;     // name of the item
        public string menuItems;        
        public int sales;       // amount of times the item was sold
        public double cost;     // the price of the item
        public int boughtByCustomer; // the amount of unique customers it was bought by
        public double Turnover   // total income from this item 
        {
            get
            {
                return sales * cost;
            }
        }
    }
}
