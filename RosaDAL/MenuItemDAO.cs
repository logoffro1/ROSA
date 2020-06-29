using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaModel;
using System.Configuration;
namespace RosaDAL
{
    public class MenuItemDAO : Base
    {
        public List<MenuItem> GetsMenuItems()
        {
            string query = "select * from [menuItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private MenuItem ReadTable(SqlDataReader reader)
        {
            MenuItem itemtemp = new MenuItem()
            {
                Name = (string)reader["itemName"],
                menuCat = (int)reader["menuCategory_id"]
            };

            return itemtemp;
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItem = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem temp = new MenuItem()
                {
                    Name = (string)dr["itemName"],
                    menuCat = (int)dr["menuCategory_id"]
                };

                menuItem.Add(temp);
            }

            return menuItem;
        }
    }
}

