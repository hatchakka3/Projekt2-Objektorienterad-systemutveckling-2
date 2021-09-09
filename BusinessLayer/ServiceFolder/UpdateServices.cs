using BusinessEntities;
using BusinessEntities.Entities;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ServiceFolder
{
    public class UpdateServices : IUpdateServices
    {
        private UnitOfWork UnitOfWork { get; set; }

        public UpdateServices(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        //Alumni
        public void UpdateAlumnusProfile(int id, AlumnusDto alumnus)
        {
            alumnus = UnitOfWork.Update(new OSU2Context()).AlumnusRepository.GetById((object)id);
            if (alumnus != null)
            {
                UnitOfWork.Update(new OSU2Context()).AlumnusRepository.Update(alumnus);
            }
        }

        public AlumnusDto ValidateAlumnusPassword(AlumnusDto alumnus)
        {
            alumnus = UnitOfWork.Update(new OSU2Context()).AlumnusRepository.GetAlumnusPassword(alumnus);
            if (alumnus != null)
                return alumnus;
            return null;
        }

        public void UpdateAlumnusPassword(int id, AlumnusDto a)
        {
            AlumnusDto alumnus = UnitOfWork.Update(new OSU2Context()).AlumnusRepository.GetById((object)id);
            alumnus.Password = a.Password;
            if (alumnus != null)
            {
                UnitOfWork.Update(new OSU2Context()).AlumnusRepository.Update(alumnus);
            }
        }

        public void SignUpForActivity(ActivityDto activity, int id)
        {
            AlumnusDto alumnus = UnitOfWork.AlumnusRepository.GetById(id);
            activity = UnitOfWork.ActivityRepository.GetById(activity.ActivityDtoID);
            if (alumnus != null && activity != null)
            {
                alumnus.Activities.Add(activity);
                UnitOfWork.AlumnusRepository.Update(alumnus);
                activity.Alumni.Add(alumnus);
                UnitOfWork.ActivityRepository.Update(activity);
            }
        }

        //Employees
        public void UpdateEmployee(int ID, EmployeeDto e)
        {
            EmployeeDto employee = UnitOfWork.Update(new OSU2Context()).EmployeeRepository.GetById(ID);
            employee.Username = e.Username;
            employee.Email = e.Email;
            if (employee != null)
            {
                UnitOfWork.Update(new OSU2Context()).EmployeeRepository.Update(employee);
            }
        }

        public EmployeeDto ValidateEmployeePassword(EmployeeDto employee)
        {
            employee = UnitOfWork.Update(new OSU2Context()).EmployeeRepository.GetEmployeePassword(employee);
            if (employee != null)
                return employee;
            return null;
        }

        public void UpdateEmployeePassword(int id, EmployeeDto e)
        {
            EmployeeDto employee = UnitOfWork.Update(new OSU2Context()).EmployeeRepository.GetById(id);
            employee.Password = e.Password;
            if (employee != null)
            {
                UnitOfWork.Update(new OSU2Context()).EmployeeRepository.Update(employee);
            }
        }

        //Activities
        public void UpdateActivity(int id, ActivityDto a)
        {
            ActivityDto activity = UnitOfWork.Update(new OSU2Context()).ActivityRepository.GetById(id);
            activity.Description = a.Description;
            activity.StartDate = a.StartDate;
            activity.EndDate = a.EndDate;
            if (activity != null)
            {
                UnitOfWork.Update(new OSU2Context()).ActivityRepository.Update(activity);
            }
        }

        //Admins
        public void UpdateAdmin(int id, AdminDto a)
        {
            AdminDto admin = UnitOfWork.Update(new OSU2Context()).AdminRepository.GetById(id);
            admin.Username = a.Username;
            admin.Email = a.Email;
            if (admin != null)
            {
                UnitOfWork.Update(new OSU2Context()).AdminRepository.Update(admin);
            }
        }

        public AdminDto ValidateAdminPassword(AdminDto admin)
        {
            admin = UnitOfWork.Update(new OSU2Context()).AdminRepository.ValidateAdminPassword(admin);
            if (admin != null)
            {
                return admin;
            }
            return null;
        }

        public void UpdateAdminPassword(int id, AdminDto a)
        {
            AdminDto admin = UnitOfWork.Update(new OSU2Context()).AdminRepository.GetById(id);
            admin.Password = a.Password;
            if (admin != null)
                UnitOfWork.Update(new OSU2Context()).AdminRepository.Update(admin);
        }

        //Mailings
        public void AddAlumniToMailing(AlumnusDto alumnus, MailingDto mailing)
        {
            if(mailing != null && alumnus != null)
            {
                UnitOfWork.MailingRepository.UpdateMailingWithAddedAlumnus(alumnus, mailing);
                UnitOfWork.AlumnusRepository.UpdateAlumnusWithMailing(alumnus, mailing);
                UnitOfWork.MailingRepository.Update(mailing);
            }
        }
    }
}

