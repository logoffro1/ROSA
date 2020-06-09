﻿using System;
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

        public OrderItem(int orderID, StatusEnum status) // for the Bar and Kitchen View
        {
            this.orderID = orderID; // because it is unque 
            this.status = status; // beacuse it needs to be updated
        }

        public OrderItem()
        {

        }
    }
}
