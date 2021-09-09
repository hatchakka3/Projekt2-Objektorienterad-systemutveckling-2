using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ActivityDto : IActivity
    {
        public int ActivityDtoID { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public List<AlumnusDto> Alumni { get; set; }

        public ActivityDto()
        {
            Alumni = new List<AlumnusDto>();
            Available = true;
        }
    }
}
