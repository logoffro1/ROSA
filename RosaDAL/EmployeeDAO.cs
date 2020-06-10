using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RosaModel;
namespace RosaDAL
{
    /// <summary>
    ///   Employee DAO class
    ///   Made by Cosmin Ilie
    ///   Student number: 645976
    /// </summary>
    public class EmployeeDAO : Base
    {
        public List<Employee> Db_Get_AllEmployees()
        {
            //read employees from database
            String query = "select employee_id, role_id, employeeName, username, [password] from employee;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddAccount(Employee employee) // add new employee to DB
        {
            String query = "insert into employee values(@role, @name,@userName,@password, NULL);";
            SqlParameter[] parameters = new SqlParameter[4]
            {
                    new SqlParameter("@role", (int)employee.role),
                    new SqlParameter("@name", employee.firstName + " " + employee.lastName),
                    new SqlParameter("@username", employee.username),
                    new SqlParameter("@password", employee.password)
            };
            ExecuteEditQuery(query, parameters);

        }
        public void RemoveAccount(Employee employee) //remove an employee from DB based on username
        {
            String query = "delete from employee where username = @username;";

            SqlParameter[] parameter = new SqlParameter[1]
            {
                    new SqlParameter("@username", employee.username)
            };
            ExecuteEditQuery(query, parameter);

        }
        public void EditAccount(string username, string notes) //edit only the NOTES of an account
        {
            String query = "UPDATE employee SET personalNotes = @notes WHERE username = @username;";
            SqlParameter[] parameters = new SqlParameter[2]
            {
                    new SqlParameter("@username", username),
                    new SqlParameter("@notes", notes)
            };
            ExecuteEditQuery(query, parameters);

        }
        public void EditAccount(Employee oldEmployee, Employee newEmployee) //edit more details about an employee
        {
            String query = "UPDATE employee SET role_id = @roleId, employeeName = @name, username = @newUsername, [password] = password WHERE username = @username;";

            SqlParameter[] parameters = new SqlParameter[5]
            {
                new SqlParameter("@username", oldEmployee.username),
                new SqlParameter("@password", newEmployee.password),
                new SqlParameter("@name", newEmployee.firstName + " " + newEmployee.lastName),
                new SqlParameter("@roleId", (int)newEmployee.role),
                new SqlParameter("@newUsername", newEmployee.username)
            };
            ExecuteEditQuery(query, parameters);

        }
        public string[] GetNotes(Employee employee) //get the NOTES from the DB (used in the home page)
        {
            string[] notes = new string[0];
            using (SqlCommand cmd = new SqlCommand("SELECT personalNotes FROM employee WHERE username = @username;", conn))
            {
                cmd.Parameters.AddWithValue("@username", employee.username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        if (!reader.IsDBNull(0)) // if the notes are not null
                            notes = reader["personalNotes"].ToString().Split(';');
                }
            }
            return notes;
        }
        public Employee GetAccountByUsername(string username) //return an account based on the username
        {
            Employee employee = null;

            using (SqlCommand cmd = new SqlCommand("select employee_id, role_id, employeeName, username, [password] FROM employee where username = @username;", conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        employee = ReadEmployee(reader);
                }
            }
            return employee;
        }

        public Employee GetAccount(string username, string password) //get an account matching the parameters
        {
            Employee employee = null;

            using (SqlCommand cmd = new SqlCommand("select employee_id, role_id, employeeName, username, [password] FROM employee where username = @username AND [password] = @password COLLATE Latin1_General_CS_AS;", conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        employee = ReadEmployee(reader);
                }
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

