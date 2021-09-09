using System;
using BusinessEntities;
using System.Collections.Generic;
using BusinessEntities.Entities;

namespace BusinessLayer.ServiceFolder
{
    public interface IUpdateServices
    {
        void SignUpForActivity(ActivityDto activity, int id);
        void UpdateActivity(int id, ActivityDto a);
        void UpdateAdmin(int id, AdminDto a);
        void UpdateAdminPassword(int id, AdminDto a);
        void UpdateAlumnusPassword(int id, AlumnusDto alumnus);
        void UpdateAlumnusProfile(int id, AlumnusDto alumnus);
        void UpdateEmployee(int ID, EmployeeDto e);
        void UpdateEmployeePassword(int id, EmployeeDto e);
        AdminDto ValidateAdminPassword(AdminDto admin);
        AlumnusDto ValidateAlumnusPassword(AlumnusDto alumnus);
        EmployeeDto ValidateEmployeePassword(EmployeeDto employee);
        void AddAlumniToMailing(AlumnusDto alumnus, MailingDto mailing);
    }
}