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
                ErrorDAO error = new ErrorDAO("Couldn't read the employee Database");
                return null;
            }

        }
        public void AddAccount(Employee employee)
        {
            try
            {
                employeeDAO.AddAccount(employee);
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't insert into the employee Database");
            }
        }
        public void EditAccount(Employee oldEmployee,Employee newEmployee)
        {
            try
            {
                employeeDAO.EditAccount(oldEmployee,newEmployee);
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't update the Employee Table");
            }
        }
            public void RemoveAccount(Employee employee)
        {
            try
            {
                employeeDAO.RemoveAccount(employee);
            }
            catch
            {

                ErrorDAO error = new ErrorDAO("Couldn't remove employee from the Database");
            }
        }
        public Employee GetAccount(string username, string password)
        {
            try
            {
                return employeeDAO.GetAccount(username, password);
            }
            catch
            {
                ErrorDAO error = new ErrorDAO("Couldn't read from the employee Table");
                return null;
            }

        }
    }
}
