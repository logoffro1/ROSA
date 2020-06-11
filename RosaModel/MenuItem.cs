using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int menuCat { get; set; }
        public decimal VAT { get; set; }
        public int ID { get; set; }
        public OrderItem orderItem { get; set; }
        public Order order { get; set; }
        public int stock { get; set; }

        public MenuItem(string name, decimal price, int menuCat, decimal vAT, OrderItem orderItem, Order order)
        {
            Name = name;
            Price = price;
            this.menuCat = menuCat;
            VAT = vAT;
            this.orderItem = orderItem;
            this.order = order;
        }

        public MenuItem()
        {
        }
    }
}
