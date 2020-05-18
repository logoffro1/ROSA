using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class Order
    {
        //will all be private
        public int id;
        public int table;
        public DateTime dateTime;
        public List<MenuItem> listMenuItems;        //not menuItems, it's orderItem + status

        public Order(int table, DateTime dateTime)
            : this(table)
        {
            this.dateTime = dateTime;
        }
        public Order(int table)
        {
            this.table = table;
            listMenuItems = new List<MenuItem>();
        }

        public Order()
        { }
    }
}
