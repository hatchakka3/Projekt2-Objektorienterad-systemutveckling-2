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
    public class InsertServices : IInsertServices
    {
        private UnitOfWork UnitOfWork { get; set; }

        public InsertServices(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        //Alumni
        public void RegistrationAlumnus(AlumnusDto alumnus)
        {
            UnitOfWork.Update(new OSU2Context()).AlumnusRepository.Insert(alumnus);
        }

        //Employees
        public void AddEmployee(EmployeeDto e)
        {
            EmployeeDto employee = e;
            UnitOfWork.Update(new OSU2Context()).EmployeeRepository.Insert(employee);
        }

        //Activities
        public void CreateActivity(ActivityDto activity, EmployeeDto employee)
        {
            employee = UnitOfWork.Update(new OSU2Context()).EmployeeRepository.GetById(employee.EmployeeDtoId);

            employee.Activities.Add(activity);
            UnitOfWork.Update(new OSU2Context()).EmployeeRepository.Update(employee);
            UnitOfWork.Update(new OSU2Context()).ActivityRepository.Insert(activity);
        }

        //Admins 
        public void AddAdmin(AdminDto admin)
        {
            UnitOfWork.Update(new OSU2Context()).AdminRepository.Insert(admin);
        }

        //Mailings
        public void CreateMailing(MailingDto mailing)
        {
            UnitOfWork.Update(new OSU2Context()).MailingRepository.Insert(mailing);        
        }
    }
}
