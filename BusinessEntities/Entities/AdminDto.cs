using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class AdminDto : Person, IAdmin
    {
        public int AdminDtoId { get; set; }
        public string EmployeeNumber { get; set; }
        public List<ActivityDto> Activities { get; set; }
        public List<EmployeeDto> Employees { get; set; }
        public List<AlumnusDto> Alumni { get; set; }

        public AdminDto()
        {
            Activities = new List<ActivityDto>();
            Employees = new List<EmployeeDto>();
            Alumni = new List<AlumnusDto>();
        }
    }
}
