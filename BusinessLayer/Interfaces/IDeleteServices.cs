using BusinessEntities;
using BusinessEntities.Entities;

namespace BusinessLayer.ServiceFolder
{
    public interface IDeleteServices
    {
        void DeleteActivity(ActivityDto activity);
        void DeleteAdmin(AdminDto admin);
        void DeleteAlumnus(AlumnusDto alumnus);
        void DeleteEmployee(EmployeeDto employee);
        void DeleteMailing(MailingDto mailing);
    }
}