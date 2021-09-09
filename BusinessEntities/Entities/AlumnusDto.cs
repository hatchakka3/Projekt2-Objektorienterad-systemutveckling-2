using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class AlumnusDto : Person, IAlumnus
    {
        public int AlumnusDtoId { get; set; }
        public string Education { get; set; }
        public string Degree { get; set; }
        public string TextualDescription { get; set; }
        public bool Registered { get; set; }
        public List<ActivityDto> Activities { get; set; }
        public List<MailingDto> Mailings { get; set; }

        public AlumnusDto()
        {
            Activities = new List<ActivityDto>();
            Mailings = new List<MailingDto>();
        }
    }
}
