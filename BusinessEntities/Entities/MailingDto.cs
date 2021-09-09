using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class MailingDto : IMailingDto
    {
        public int MailingDtoId { get; set; }
        public string Information { get; set; }
        public List<AlumnusDto> Alumni { get; set; }

        public MailingDto()
        {
            Alumni = new List<AlumnusDto>();
        }
    }
}
