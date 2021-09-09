using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class ActivityRepository : GenericRepository<ActivityDto>, IActivityRepository
    {
        public ActivityRepository(OSU2Context osu2context) : base(osu2context)
        {

        }

        public ICollection<AlumnusDto> GetActivitiesAlumni(ActivityDto activity)
        {
            var alumni = context.Alumni.Where(r => r.Activities.Any(a => a.ActivityDtoID == activity.ActivityDtoID));
            return alumni.ToList();
        }
    }
}
