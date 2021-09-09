using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Activity : IActivity
    {
        public int ActivityID { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public List<Alumnus> Alumni { get; set; }

        public Activity()
        {
            Alumni = new List<Alumnus>();
            Available = true;
        }
    }
}
