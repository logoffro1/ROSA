using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaDAL;
using RosaModel;
namespace RosaLogic
{
    public class Employee_Service
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public List<Employee> GetEmployees()
        {
            try
            {
                return employeeDAO.Db_Get_AllEmployees();
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read the employee DB");
                return null;
            }
          
        }
    }
}
