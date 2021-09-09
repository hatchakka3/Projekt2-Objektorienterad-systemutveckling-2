using BusinessEntities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<EmployeeDto>
    {
        EmployeeDto GetEmployeePassword(EmployeeDto employee);
        EmployeeDto GetEmployeeUsername(string username, string password);
    }
}