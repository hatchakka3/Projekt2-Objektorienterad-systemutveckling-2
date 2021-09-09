using System.Collections.Generic;
using BusinessEntities;
using BusinessEntities.Entities;

namespace BusinessLayer.ServiceFolder
{
    public interface IGetServices
    {
        IEnumerable<EmployeeDto> DisplayAllEmployees();
        IEnumerable<ActivityDto> GetAllActivities();
        IEnumerable<AdminDto> GetAllAdmins();
        IEnumerable<AlumnusDto> GetAllAlumnus();
        ICollection<ActivityDto> GetAlumnusActivities(AlumnusDto alumnus);
        List<AlumnusDto> SearchAlumnusByEducation(string input);
        List<AlumnusDto> SearchAlumnusByName(string input);
        IEnumerable<MailingDto> GetAllMailings();
        ICollection<AlumnusDto> GetActivitiesAlumni(ActivityDto activity);
    }
}