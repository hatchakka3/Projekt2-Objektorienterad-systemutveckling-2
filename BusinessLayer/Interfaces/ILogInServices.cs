using BusinessEntities;

namespace BusinessLayer.ServiceFolder
{
    public interface ILogInServices
    {
        AlumnusDto AlumnusLogIn(AlumnusDto alumnus);
        EmployeeDto EmployeeLogIn(EmployeeDto employee);
        AdminDto GetAdminLogIn(AdminDto admin);
    }
}