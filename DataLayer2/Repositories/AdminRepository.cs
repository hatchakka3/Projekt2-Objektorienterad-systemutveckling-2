using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class AdminRepository : GenericRepository<AdminDto>, IAdminRepository
    {
        public AdminRepository(OSU2Context osu2context) : base(osu2context)
        {

        }

        public AdminDto GetAdminLogin(string username, string password)
        {
            return context.Admins.Where(a => a.Username == username && a.Password == password).SingleOrDefault();
        }

        public AdminDto ValidateAdminPassword(AdminDto admin)
        {
            return context.Admins.Where(a => a.Password == admin.Password).FirstOrDefault();
        }
    }
}
