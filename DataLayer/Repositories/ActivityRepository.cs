using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class ActivityRepository : GenericRepository<Activity>
    {
        public ActivityRepository(OSU2Context osu2context) : base(osu2context)
        {

        }

        public List<Activity> Sort()
        {
            return context.Activities.OrderBy(x => x.StartDate).ToList();
        }
    }
}
