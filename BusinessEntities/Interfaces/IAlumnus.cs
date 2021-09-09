using BusinessEntities.Entities;
using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IAlumnus
    {
        List<ActivityDto> Activities { get; set; }
        int AlumnusDtoId { get; set; }
        string Degree { get; set; }
        string Education { get; set; }
        bool Registered { get; set; }
        string TextualDescription { get; set; }
        List<MailingDto> Mailings { get; set; }
    }
}