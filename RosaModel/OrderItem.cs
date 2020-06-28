using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class OrderItem
    {
        public int orderID;
        public int orderItems_id;
        public MenuItem menuItem;
        public StatusEnum status;
        public int amount;
        public int menuItemID;
        public string menuItemName;
        public Order order;
        public OrderItem()
        {

        }
    }
}
