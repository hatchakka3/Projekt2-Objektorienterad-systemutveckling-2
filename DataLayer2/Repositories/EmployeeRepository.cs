using BusinessEntities;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeDto>, IEmployeeRepository
    {
        public EmployeeRepository(OSU2Context osu2context) : base(osu2context)
        {

        }
        public EmployeeDto GetEmployeeUsername(string username, string password)
        {
            return context.Employees.Where(e => e.Username == username && e.Password == password).FirstOrDefault();
        }

        public EmployeeDto GetEmployeePassword(EmployeeDto employee)
        {
            return context.Employees.Where(e => e.Password == employee.Password).FirstOrDefault();
        }
    }
}
