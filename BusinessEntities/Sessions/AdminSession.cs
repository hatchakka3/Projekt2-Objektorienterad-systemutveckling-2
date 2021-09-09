using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Sessions
{
    public class AdminSession : IAdminSession
    {
        public Admin Admin { get; set; }

        public AdminSession(Admin admin)
        {
            Admin = admin;
        }
    }
}
