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
   public class EmployeeDAO : Base
    {
        public List<Employee> Db_Get_AllEmployees()
        {
            //read employees from database
            string query = "select employee_id, role_id, employeeName, username, [password] from employee;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    employeeId = (int)dr["employee_id"],
                    role = (RolesEnum)(int)dr["role_id"],
                    employeeName = dr["employeeName"].ToString(),
                    username = dr["username"].ToString(),
                    password = dr["password"].ToString()                
                };
              
                employees.Add(employee);
            }
            return employees;
        }
    }
}
