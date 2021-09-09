using BusinessEntities;
using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class AlumnusRepository : GenericRepository<AlumnusDto>, IAlumnusRepository
    {
        public AlumnusRepository(OSU2Context osu2context) : base(osu2context)
        {
            
        }
        public AlumnusDto GetAlumnusLogIn(string username, string password)
        {
            return context.Alumni.Where(a => a.Username == username && a.Password == password).SingleOrDefault();
        }

        public AlumnusDto GetAlumnusPassword(AlumnusDto alumnus)
        {
            return context.Alumni.Where(a => a.Password == alumnus.Password).FirstOrDefault();
        }

        public ICollection<ActivityDto> GetAlumnusActivities(AlumnusDto alumnus)
        {
            var activities = context.Activities.Where(r => r.Alumni.Any(a => a.AlumnusDtoId == alumnus.AlumnusDtoId));
            return activities.ToList();
        }

        public List<AlumnusDto> SearchAlumnusByName(string input)
        {
            return context.Alumni.Where(a => a.Name.Equals(input)).ToList();
        }

        public List<AlumnusDto> SearchAlumnusByEducation(string input)
        {
            return context.Alumni.Where(a => a.Education.Equals(input)).ToList();
        }

        public void UpdateAlumnusWithMailing(AlumnusDto alumnus, MailingDto mailing)
        {
            if(alumnus != null && mailing != null)
            {
                mailing = context.Mailings.Where(m => m.MailingDtoId == mailing.MailingDtoId).FirstOrDefault();
                alumnus.Mailings.Add(mailing);
            }
        }
    }
}
