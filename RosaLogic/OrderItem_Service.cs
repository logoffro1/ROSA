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
                return orderItemDAO.GetById(order_id);
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Order Item from the Database!");
                return null;
            }
        }
    }
}
