using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class EmployeeDto : Person, IEmployee
    {
        public int EmployeeDtoId { get; set; }
        public string Signature { get; set; }
        public string EmployeeNumber { get; set; }
        public List<ActivityDto> Activities { get; set; }
        public ICollection<MailingDto> Mailings { get; set; }

        public EmployeeDto()
        {
            Activities = new List<ActivityDto>();
            Mailings = new List<MailingDto>();
        }
    }
}
