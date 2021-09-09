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
    public class DeleteServices : IDeleteServices
    {
        private UnitOfWork UnitOfWork { get; set; }

        public DeleteServices(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        //Alumnus
        public void DeleteAlumnus(AlumnusDto alumnus)
        {
            if (alumnus != null)
            {
                UnitOfWork.Update(new OSU2Context()).AlumnusRepository.Delete(alumnus.AlumnusDtoId);
            }
        }

        //Employees
        public void DeleteEmployee(EmployeeDto employee)
        {
            if (employee != null)
            {
                UnitOfWork.Update(new OSU2Context()).EmployeeRepository.Delete(employee.EmployeeDtoId);
            }
        }

        //Activities
        public void DeleteActivity(ActivityDto activity)
        {
            if(activity != null)
            {
                UnitOfWork.Update(new OSU2Context()).ActivityRepository.Delete(activity.ActivityDtoID);
            }
        }

        //Admins
        public void DeleteAdmin(AdminDto admin)
        {
            if (admin != null)
            {
                UnitOfWork.Update(new OSU2Context()).AdminRepository.Delete(admin.AdminDtoId);
            }
        }

        public void DeleteMailing(MailingDto mailing)
        {
            if(mailing != null)
            {
                UnitOfWork.Update(new OSU2Context()).MailingRepository.Delete(mailing.MailingDtoId);
            }
        }
    }
}
