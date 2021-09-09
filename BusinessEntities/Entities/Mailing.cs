using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Mailing
    {
        public int MailingId { get; set; }
        public List<AlumnusDto> Alumni { get; set; }
    }
}
