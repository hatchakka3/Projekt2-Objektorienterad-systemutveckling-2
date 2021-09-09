using BusinessEntities;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        EmployeeRepository empR = null;
        List<Employee> Employees;

        public Employee GetEmployee(string username, string password)
        {
            Employee employee = Employees.Where(e => e.Username == username && e.Password == password).SingleOrDefault();
            if(employee.Username != username && employee.Password != password)
            {
                employee = empR.GetEmployee(username, password);
                Employees.Add(employee);
            }
            return employee;
        }

        //public Employee GetEmployeePassword(string password)
        //{
        //    Employee employee = Employees.Where(e => e.Password == password).SingleOrDefault();
        //    if(employee.Password != password)
        //    {
        //        employee = empR.ValidPassword(password);
        //        Employees.Add(employee);
        //    }
        //    return employee;
        //}
    }
}
