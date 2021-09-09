using BusinessEntities;
using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public interface IAdminRepository: IGenericRepository<AdminDto>
    {
        AdminDto GetAdminLogin(string username, string password);
        AdminDto ValidateAdminPassword(AdminDto admin);
    }
}