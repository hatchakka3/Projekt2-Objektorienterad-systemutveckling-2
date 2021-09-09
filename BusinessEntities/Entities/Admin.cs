using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Admin : Person, IAdmin
    {
        public int AdminId { get; set; }
        public string EmployeeNumber { get; set; }
        public List<Activity> Activities { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Alumnus> Alumni { get; set; }

        public Admin()
        {
            Activities = new List<Activity>();
            Employees = new List<Employee>();
            Alumni = new List<Alumnus>();
        }
    }
}
