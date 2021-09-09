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
    public class GetServices : IGetServices
    {
        private UnitOfWork UnitOfWork { get; set; }

        public GetServices(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        //Alumni
        public List<AlumnusDto> SearchAlumnusByName(string input)
        {
            return UnitOfWork.Update(new OSU2Context()).AlumnusRepository.SearchAlumnusByName(input);
        }

        public List<AlumnusDto> SearchAlumnusByEducation(string input)
        {
            return UnitOfWork.Update(new OSU2Context()).AlumnusRepository.SearchAlumnusByEducation(input);
        }

        public IEnumerable<AlumnusDto> GetAllAlumnus()
        {
            return UnitOfWork.Update(new OSU2Context()).AlumnusRepository.GetAll();
        }

        public ICollection<ActivityDto> GetAlumnusActivities(AlumnusDto alumnus)
        {
            return UnitOfWork.AlumnusRepository.GetAlumnusActivities(alumnus);
        }

        //Employees
        public IEnumerable<EmployeeDto> DisplayAllEmployees()
        {
            return UnitOfWork.Update(new OSU2Context()).EmployeeRepository.GetAll();
        }

        //Activities
        public IEnumerable<ActivityDto> GetAllActivities()
        {
            return UnitOfWork.Update(new OSU2Context()).ActivityRepository.GetAll();
        }

        public ICollection<AlumnusDto> GetActivitiesAlumni(ActivityDto activity)
        {
            return UnitOfWork.ActivityRepository.GetActivitiesAlumni(activity);
        }

        //Admins
        public IEnumerable<AdminDto> GetAllAdmins()
        {
            return UnitOfWork.Update(new OSU2Context()).AdminRepository.GetAll();
        }

        public IEnumerable<MailingDto> GetAllMailings()
        {
            return UnitOfWork.Update(new OSU2Context()).MailingRepository.GetAll();
        }
    }
}
