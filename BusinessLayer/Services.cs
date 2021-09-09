using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessEntities.Sessions;
using DataLayer;
using DataLayer.Repositories;
using BusinessLayer.Services;

namespace BusinessLayer
{
    public class Service
    {
        public UnitOfWork unitofwork { get; set; }
        public AlumnusServices alumnusServices { get; set; }
        public Service(OSU2Context osu2Context)
        {
            unitofwork = new UnitOfWork(osu2Context);
            alumnusServices = new AlumnusServices(osu2Context);
        }

        //EmployeeBusinessManager
        public EmployeeSession EmployeeLogIn(string username, string password)
        {
            EmployeeSession employeeSession = null;
            Employee employee = unitofwork.EmployeeRepository.GetEmployeeUsername(username, password);
            if (employee != null && employee.Password == password)
                employeeSession = new EmployeeSession(employee);
            return employeeSession;
        }

        public void UpdateEmployee(int ID, string username, string password, string email)
        {
            Employee employee = unitofwork.EmployeeRepository.GetById(ID);
            employee.Username = username;
            employee.Password = password;
            employee.Email = email;
            if (employee != null)
            {
                unitofwork.EmployeeRepository.Update(employee);
            }
        }

        //ActivityBusinessManager
        public void CreateActivity(Activity activity)
        {
            unitofwork.ActivityRepository.Insert(activity);
        }

        public IEnumerable<Activity> GetAllActivities()
        {
            return unitofwork.ActivityRepository.GetAll();
        }

        public void UpdateActivity(int id, string description, DateTime startDate, DateTime endDate)
        {
            Activity activity = unitofwork.ActivityRepository.GetById(id);
            activity.Description = description;
            activity.StartDate = startDate;
            activity.EndDate = endDate;
            if(activity != null)
            {
                unitofwork.ActivityRepository.Update(activity);
            }
        }
    }
}
