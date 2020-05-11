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
        public Employee GetAccount(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("select employee_id, role_id, employeeName, username, [password] FROM employee where username = @username AND [password] = @password;", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            if (reader.Read())
            {
                employee = ReadTable(reader);
            }
            return employee;
        }
        private Employee ReadTable(SqlDataReader reader)
        {
            Employee employee = new Employee()
            {
                employeeId = (int)reader["employee_id"],
                employeeName = reader["employeeName"].ToString(),
                username = reader["username"].ToString(),
                password = reader["password"].ToString(),
                role = (RolesEnum)reader["role_id"]

            };

            return employee;

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
