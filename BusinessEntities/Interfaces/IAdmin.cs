using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IAdmin
    {
        List<ActivityDto> Activities { get; set; }
        int AdminDtoId { get; set; }
        List<AlumnusDto> Alumni { get; set; }
        string EmployeeNumber { get; set; }
        List<EmployeeDto> Employees { get; set; }
    }
}