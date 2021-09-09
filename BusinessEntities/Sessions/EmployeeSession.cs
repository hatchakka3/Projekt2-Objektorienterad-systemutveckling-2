using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Sessions
{
    public class EmployeeSession : IEmployeeSession
    {
        public Employee Employee { get; set; }

        public EmployeeSession(Employee employee)
        {
            Employee = employee;
        }
    }
}
