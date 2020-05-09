using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaDAL;
using RosaModel;
namespace RosaLogic
{
  public class Table_Service
    {
        TableDAO tableDAO = new TableDAO();
        public List<Table> GetAllTables()
        {
            try
            {
                return tableDAO.Db_Get_AllTables();
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Tables from the Database!");
                return null;
            }
            
        }
        public Table GetById(int id)
        {
            try
            {
                return tableDAO.GetById(id);
            }

            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the Table from the Database!");

                return null;
            }
          
        }
    }
}
