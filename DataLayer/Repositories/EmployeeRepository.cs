using BusinessEntities;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(OSU2Context osu2context) : base(osu2context)
        {

        }
        //public bool ValidEmployee(string username, string password)
        //{
        //    var query = from p in context.Employees
        //                where p.Username == username
        //                && p.Password == password
        //                select p;

        //    if (query.Any())
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public Employee GetEmployee(string username, string password)
        {
            return context.Employees.Where(e => e.Username == username && e.Password == password).SingleOrDefault();
        }

        //public bool ValidPassword(string password)
        //{
        //    Employee e = new Employee();
        //    return String.Equals(e.Password, password);
        //}

        //private IGenericRepository<Employee> repository = null;

        //public EmployeeRepository()
        //{
        //    this.repository = new GenericRepository<Employee>();
        //}

        //public EmployeeRepository(IGenericRepository<Employee> repository)
        //{
        //    this.repository = repository
        //}
    }
}
