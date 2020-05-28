using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaDAL;
using RosaModel;
namespace RosaLogic
{
    public class MenuItem_Service
    {
        MenuItemDAO menuItemDAO = new MenuItemDAO();
        public List<MenuItem> GetOrderItem()
        {
            try
            {
                List<MenuItem> bars = menuItemDAO.Db_Get_AllOrders();
                return bars;
            }
            catch
            {
                return null;
         
               
            }
        }
        public void UpdateTableOrder(int id, int status)
        {
            try
            {
                menuItemDAO.UpdateTableOrder(id, status);
            }
            catch
            {
                throw new Exception("Could not update TableOrder");
            }
        }
        public MenuItem GetFromTableTheStatus(int status)
        {
            try
            {
                return menuItemDAO.GetFromTableTheStatus(status);
            }

            catch
            {
                return null;
            }
        }
    }
}
