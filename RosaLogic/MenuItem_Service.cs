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
                List<MenuItem> bars = menuItemDAO.GetsMenuItems();
                return bars;
            }
            catch 
            {
                return null;                
            }
        }
    }
}
