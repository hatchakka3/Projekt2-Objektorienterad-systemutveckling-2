using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Employee : Person, IEmployee
    {
        public int EmployeeId { get; set; }
        public string Signature { get; set; }
        public string EmployeeNumber { get; set; }
        public List<Activity> Activities { get; set; }
        public List<Mailing> Mailings { get; set; }

        public Employee()
        {
            Activities = new List<Activity>();
            Mailings = new List<Mailing>();
        }
    }
}
