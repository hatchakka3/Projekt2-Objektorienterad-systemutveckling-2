using System;
using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IActivity
    {
        int ActivityDtoID { get; set; }
        List<AlumnusDto> Alumni { get; set; }
        bool Available { get; set; }
        string Description { get; set; }
        DateTime EndDate { get; set; }
        DateTime StartDate { get; set; }
    }
}