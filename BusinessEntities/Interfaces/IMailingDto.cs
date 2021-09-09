using System.Collections.Generic;

namespace BusinessEntities.Entities
{
    public interface IMailingDto
    {
        int MailingDtoId { get; set; }
        string Information { get; set; }
        List<AlumnusDto> Alumni { get; set; }
    }
}