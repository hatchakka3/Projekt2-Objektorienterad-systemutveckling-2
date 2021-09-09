using System.Collections.Generic;

namespace BusinessEntities
{
    public interface IEmployee
    {
        List<ActivityDto> Activities { get; set; }
        int EmployeeDtoId { get; set; }
        string EmployeeNumber { get; set; }
        string Signature { get; set; }
    }
}