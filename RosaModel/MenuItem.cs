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
        public int stock { get; set; }
        public MenuItem()
        {
        }
    }
}
