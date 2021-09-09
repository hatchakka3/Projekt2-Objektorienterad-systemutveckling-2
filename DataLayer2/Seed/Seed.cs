using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Seed
{
    public class Seed
    {
        public static void Populate(OSU2Context osu2Context)
        {
            osu2Context.Employees.Add(new EmployeeDto()
            {
                Name = "Aleksander Joldzic",
                EmployeeNumber = "123",
                SocialSecurityNumber = "1997",
                Username = "ALJO",
                Password = "123",
                Signature = "ALJO",
                Email = "alejol@hb.se"                
            });

            osu2Context.Admins.Add(new AdminDto()
            {
                Name = "Oliver Jaksch",
                EmployeeNumber = "456",
                SocialSecurityNumber = "1990",
                Username = "OLJA",
                Password = "456",
                Email = "olja@hb.se"
            });

            osu2Context.SaveChanges();
        }
    }
}
