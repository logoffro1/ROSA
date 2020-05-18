using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class MenuItem
    {

        public int TableId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public StatusEnum Status { get; set; }
        public int menuCat { get; set; }
        public int orderID { get; set; }
        public string Note { get; set; } 
        public DateTime dateSold;
        public MenuItem(int tableId, string name, int quantity, decimal price, StatusEnum status, int orderID, DateTime dateSold, string note)
        {
            TableId = tableId;
            Name = name ?? throw new ArgumentNullException(nameof(name));            
            Quantity = quantity;
            Price = price;
            Status = status;
            this.orderID = orderID;
            this.dateSold = dateSold;
            Note = note ?? throw new ArgumentNullException(nameof(note));
        }
        public MenuItem()
        {
        }
    }
}
