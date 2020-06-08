using System.Collections.Generic;
using RosaDAL;
using RosaModel;
namespace RosaLogic
{
    /// <summary>
    ///   Employee Service class
    ///   Made by Cosmin Ilie
    ///   Student number: 645976
    /// </summary>
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
                ErrorHandler error = new ErrorHandler("Couldn't read the employee Database");
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
                ErrorHandler error = new ErrorHandler("Couldn't insert into the employee Database");
            }
        }
        public void EditAccount(string username, string notes)
        {
            employeeDAO.EditAccount(username, notes);
        }
        public string[] GetNotes(Employee employee)
        {
            return employeeDAO.GetNotes(employee);
        }
        public void EditAccount(Employee oldEmployee, Employee newEmployee)
        {
            try
            {
                employeeDAO.EditAccount(oldEmployee, newEmployee);
            }
            catch
            {
                ErrorHandler error = new ErrorHandler("Couldn't update the Employee Table");
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

                ErrorHandler error = new ErrorHandler("Couldn't remove employee from the Database");
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
                ErrorHandler error = new ErrorHandler("Couldn't read from the employee Table");
                return null;
            }

        }

        public Employee GetAccountByUsername(string username)
        {
            try
            {
                return employeeDAO.GetAccountByUsername(username);
            }
            catch
            {
                ErrorHandler error = new ErrorHandler("Couldn't read from the employee Table");
                return null;
            }

        }
    }
}
