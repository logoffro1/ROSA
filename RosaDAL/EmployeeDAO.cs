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
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddAccount(Employee employee)
        {
            SqlCommand cmd = new SqlCommand("insert into employee values(@role, @name,@userName,@password);", conn);
            cmd.Parameters.AddWithValue("@role", (int)employee.role);
            cmd.Parameters.AddWithValue("@name", employee.firstName+" " + employee.lastName);
            cmd.Parameters.AddWithValue("@username", employee.username);
            cmd.Parameters.AddWithValue("@password", employee.password);
            cmd.ExecuteReader();
        }
        public void RemoveAccount(Employee employee)
        {
            SqlCommand cmd = new SqlCommand("delete from employee where username = @username;", conn);
            cmd.Parameters.AddWithValue("@username", employee.username);
            cmd.ExecuteReader();

        }


      public void EditAccount(string username, string notes)
        {
            SqlCommand cmd = new SqlCommand("UPDATE employee SET personalNotes = @notes WHERE username = @username;", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@notes", notes);
            cmd.ExecuteReader();
        }
        public void EditAccount(Employee oldEmployee,Employee newEmployee)
        {
            SqlCommand cmd = new SqlCommand("UPDATE employee SET role_id = @roleId, employeeName = @name, username = @newUsername, [password] = password WHERE username = @username;", conn);
            cmd.Parameters.AddWithValue("@username", oldEmployee.username);
            cmd.Parameters.AddWithValue("@password", newEmployee.password);
            cmd.Parameters.AddWithValue("@name", newEmployee.firstName+" "+newEmployee.lastName);
            cmd.Parameters.AddWithValue("@roleId", (int)newEmployee.role);
            cmd.Parameters.AddWithValue("@newUsername", newEmployee.username);
            cmd.ExecuteReader();
        }
        public string[] GetNotes(Employee employee)
        {
            string[] notes = new string[0];
            SqlCommand cmd = new SqlCommand("select personalNotes FROM employee where username = @username;", conn);
            cmd.Parameters.AddWithValue("@username", employee.username);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                    notes = reader["personalNotes"].ToString().Split(';');
            }
           

            return notes;
        }
        public Employee GetAccount(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("select employee_id, role_id, employeeName, username, [password] FROM employee where username = @username AND [password] = @password COLLATE Latin1_General_CS_AS;", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            if (reader.Read())
            {
                employee = ReadEmployee(reader);
            }
            return employee;
        }
        private Employee ReadEmployee(SqlDataReader reader)
        {
            string[] employeeName = reader["employeeName"].ToString().Split(' ');
            Employee employee = new Employee()
            {
                employeeId = (int)reader["employee_id"],
                firstName = employeeName[0],
                lastName = employeeName[1],
                username = reader["username"].ToString(),
                password = reader["password"].ToString(),
                role = (Roles)reader["role_id"]              
            };
            return employee;
        }
        private List<Employee> ReadEmployees(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
           
            foreach (DataRow dr in dataTable.Rows)
            {
                string[] employeeName = dr["employeeName"].ToString().Split(' ');
                Employee employee = new Employee()
                {
                    employeeId = (int)dr["employee_id"],
                    role = (Roles)(int)dr["role_id"],
                    firstName = employeeName[0],
                    lastName = employeeName[1],
                    username = dr["username"].ToString(),
                    password = dr["password"].ToString()                
                };
              
                employees.Add(employee);
            }
            return employees;
        }
    }
}
