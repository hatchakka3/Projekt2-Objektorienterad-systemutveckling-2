using BusinessEntities;
using BusinessEntities.Entities;
using System.Collections.Generic;

namespace BusinessLayer.ServiceFolder
{
    public interface IInsertServices
    {
        void AddAdmin(AdminDto admin);
        void AddEmployee(EmployeeDto employee);
        void CreateActivity(ActivityDto activity, EmployeeDto employee);
        void RegistrationAlumnus(AlumnusDto alumnus);
        void CreateMailing(MailingDto mailing);
    }
}