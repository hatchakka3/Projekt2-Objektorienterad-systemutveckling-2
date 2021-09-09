using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Sessions
{
    public class AlumnusSession : IAlumnusSession
    {
        public Alumnus Alumnus { get; set; }

        public AlumnusSession(Alumnus alumnus)
        {
            Alumnus = alumnus;
        }
    }
}
