using RosaDAL;
using RosaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaLogic
{
    public class Revenue_Service
    {
        private RevenueDAO revenue_DB = new RevenueDAO();
        
        public List<RevenueItem> GetRevenue(DateTime start, DateTime end)
        {
            if (start > end)
                throw new Exception("Invalid date range selected");
            return revenue_DB.GetOrderItemsSalesByPeriod(start, end);
        }

    }
}
