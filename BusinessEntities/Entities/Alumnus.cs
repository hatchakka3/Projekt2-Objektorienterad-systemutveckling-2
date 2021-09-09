using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Alumnus : Person, IAlumnus
    {
        public int AlumnusId { get; set; }
        public string Education { get; set; }
        public string Degree { get; set; }
        public string TextualDescription { get; set; }
        public bool Registered { get; set; }
        public List<Activity> Activities { get; set; }

        public Alumnus()
        {
            Activities = new List<Activity>();
        }
    }
}
