using BusinessEntities;
using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class MailingRepository : GenericRepository<MailingDto>, IMailingRepository
    {
        public MailingRepository(OSU2Context osu2Context) : base(osu2Context)
        {

        }

        public void UpdateMailingWithAddedAlumnus(AlumnusDto alumnus, MailingDto mailing)
        {
            if(mailing != null && alumnus != null)
            {
                alumnus = context.Alumni.Where(a => a.AlumnusDtoId == alumnus.AlumnusDtoId).FirstOrDefault();
                mailing.Alumni.Add(alumnus);
            }
        }
    }
}
