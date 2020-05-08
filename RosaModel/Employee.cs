using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaModel
{
    public class Employee
    {
        public int employeeId { get; set; }
        public RolesEnum role { get; set; }
        public string employeeName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
