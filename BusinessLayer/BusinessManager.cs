using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessEntities.Sessions;
using DataLayer;
using DataLayer.Repositories;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public UnitOfWork unitofwork { get; set; }
        public BusinessManager(OSU2Context osu2Context)
        {
            unitofwork = new UnitOfWork(osu2Context);
        }

        //AlumnusBusinessManager
        public void RegistrationAlumnus(Alumnus alumnus)
        {
            unitofwork.AlumnusRepository.Insert(alumnus);
        }

        public AlumnusSession AlumnusLogIn(string username, string password)
        {
            AlumnusSession alumnusSession = null;
            Alumnus alumnus = unitofwork.AlumnusRepository.GetAlumnusLogIn(username, password);
            if (alumnus != null && alumnus.Password == password)
                alumnusSession = new AlumnusSession(alumnus);
            return alumnusSession;
        }

        public List<Alumnus> SearchAlumnusByName(string input)
        {
            return unitofwork.AlumnusRepository.SearchAlumnusByName(input);
        }

        public List<Alumnus> SearchAlumnusByEducation(string input)
        {
            return unitofwork.AlumnusRepository.SearchAlumnusByEducation(input);
        }

        public IEnumerable<Alumnus> GetAllAlumnus()
        {
            return unitofwork.AlumnusRepository.GetAll();
        }

        public void UpdateAlumnusProfile(int id, string name, string username, string email, string description)
        {
            Alumnus alumnus = unitofwork.AlumnusRepository.GetById(id);
            alumnus.Name = name;
            alumnus.Username = username;
            alumnus.Email = email;
            alumnus.TextualDescription = description;
            if(alumnus != null)
            {
                unitofwork.AlumnusRepository.Update(alumnus);
            }
        }

        public Alumnus ValidateAlumnusPassword(string password)
        {
            Alumnus alumnus = unitofwork.AlumnusRepository.GetAlumnusPassword(password);
            if (alumnus != null)
                return alumnus;
            return null;
        }

        public void UpdateAlumnusPassword(int id, string password)
        {
            Alumnus alumnus = unitofwork.AlumnusRepository.GetById(id);
            alumnus.Password = password;
            if(alumnus != null)
            {
                unitofwork.AlumnusRepository.Update(alumnus);
            }
        }

        public void SignUpForActivity(Activity activity, int id)
        {
            Alumnus alumnus = unitofwork.AlumnusRepository.GetById(id);
            activity = unitofwork.ActivityRepository.GetById(activity.ActivityID);
            if(alumnus != null && activity != null)
            {
                alumnus.Activities.Add(activity);
                unitofwork.AlumnusRepository.Update(alumnus);
                activity.Alumni.Add(alumnus);
                unitofwork.ActivityRepository.Update(activity);
            }
        }

        public ICollection<Activity> GetAlumnusActivities(Alumnus alumnus)
        {
            return unitofwork.AlumnusRepository.GetAlumnusActivities(alumnus);
        }

        public void DeleteAlumnus(Alumnus alumnus)
        {
            if(alumnus != null)
            {
                unitofwork.AlumnusRepository.Delete(alumnus.AlumnusId);
            }
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

        public void UpdateEmployee(int ID, string username, string email)
        {
            Employee employee = unitofwork.EmployeeRepository.GetById(ID);
            employee.Username = username;
            employee.Email = email;
            if (employee != null)
            {
                unitofwork.EmployeeRepository.Update(employee);
            }
        }

        public Employee ValidateEmployeePassword(string password)
        {
            Employee employee = unitofwork.EmployeeRepository.GetEmployeePassword(password);
            if (employee != null)
                return employee;
            return null;
        }

        public void UpdateEmployeePassword(int id, string password)
        {
            Employee employee = unitofwork.EmployeeRepository.GetById(id);
            employee.Password = password;
            if (employee != null)
            {
                unitofwork.EmployeeRepository.Update(employee);
            }
        }

        public List<Employee> SearchEmployeeByName(string input)
        {
            return unitofwork.EmployeeRepository.SearchEmployeeOnName(input);
        }

        public IEnumerable<Employee> DisplayAllEmployees()
        {
            return unitofwork.EmployeeRepository.GetAll();
        }

        public void AddEmployee(Employee employee)
        {
            unitofwork.EmployeeRepository.Insert(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            if(employee != null)
            {
                unitofwork.EmployeeRepository.Delete(employee.EmployeeId);
            }
        }

        //ActivityBusinessManager
        public void CreateActivity(Activity activity, Employee employee)
        {
            employee.Activities.Add(activity);
            unitofwork.EmployeeRepository.Update(employee);
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

        public void DeleteActivity(Activity activity)
        {
            unitofwork.ActivityRepository.Delete(activity.ActivityID);
        }

        //AdminBusinessManager
        public AdminSession GetAdminLogIn(string username, string password)
        {
            AdminSession adminSession = null;
            Admin admin = unitofwork.AdminRepository.GetAdminLogin(username, password);
            if (admin != null && admin.Password == password)
                return adminSession = new AdminSession(admin);
            return null;
        }

        public void UpdateAdmin(int id, string username, string email)
        {
            Admin admin = unitofwork.AdminRepository.GetById(id);
            admin.Username = username;
            admin.Email = email;
            if(admin != null)
            {
                unitofwork.AdminRepository.Update(admin);
            }
        }

        public Admin ValidateAdminPassword(string password)
        {
            Admin admin = unitofwork.AdminRepository.ValidateAdminPassword(password);
            if(admin != null)
            {
                return admin;
            }
            return null;
        }

        public void UpdateAdminPassword(int id, string password)
        {
            Admin admin = unitofwork.AdminRepository.GetById(id);
            admin.Password = password;
            if (admin != null)
                unitofwork.AdminRepository.Update(admin);
        }

        public void AddAdmin(Admin admin)
        {
            unitofwork.AdminRepository.Insert(admin);
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            return unitofwork.AdminRepository.GetAll();
        }

        public void DeleteAdmin(Admin admin)
        {
            if(admin != null)
            {
                unitofwork.AdminRepository.Delete(admin.AdminId);
            }
        }
    }
}
