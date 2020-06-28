using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaDAL;
using RosaModel;


namespace RosaLogic
{
    public class OrderItem_Service
    {
        OrderItemDAO orderItemDAO = new OrderItemDAO();
        public List<OrderItem> GetById(int order_id)
        {
            try
            {
                return orderItemDAO.GetOrderItemsById(order_id);
            }
            catch
            {
                ErrorHandler error = new ErrorHandler("Couldn't read the Order Item from the Database!");
                return null;
            }
        }
        // By Liv
        public void UpdateTableOrder(int id, int status) // Updates the table 
        {
            try
            {
                orderItemDAO.UpdateTableOrder(id, status); // by orederItem_id and status
            }
            catch
            {
                throw new Exception("Could not update TableOrder");
            }
        }
        // By Liv
        public List<OrderItem> GetKItchenOrderedItems() // Gets items from the order
        {
            try
            {
                return orderItemDAO.GetOrderedItemsKitchenOrBar();
            }

            catch
            {
                return null;
            }
        }
    }
}
