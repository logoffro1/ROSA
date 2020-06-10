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
                new ErrorHandler("Couldn't read the employee Database");
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
                new ErrorHandler("Couldn't insert into the employee Database");
            }
        }
        public void EditAccount(string username, string notes)
        {
            try
            {
                employeeDAO.EditAccount(username, notes);
            }
            catch
            {
                new ErrorHandler("Couldn't edit the account");
            }

        }
        public string[] GetNotes(Employee employee)
        {
            try
            {
                return employeeDAO.GetNotes(employee);
            }
            catch
            {
                new ErrorHandler("Error trying to get the notes from the DB");
                return null;
            }

        }
        public void EditAccount(Employee oldEmployee, Employee newEmployee)
        {
            try
            {
                employeeDAO.EditAccount(oldEmployee, newEmployee);
            }
            catch
            {
                new ErrorHandler("Couldn't update the Employee Table");
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
                new ErrorHandler("Couldn't remove employee from the Database");
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
                new ErrorHandler("Couldn't read from the employee Table");
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
                new ErrorHandler("Couldn't read from the employee Table");
                return null;
            }

        }
    }
}
