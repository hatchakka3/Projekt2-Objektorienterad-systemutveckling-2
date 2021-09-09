using BusinessEntities;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ServiceFolder
{
    public class LogInServices : ILogInServices
    {
        private UnitOfWork UnitOfWork { get; set; }
        public LogInServices(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public AlumnusDto AlumnusLogIn(AlumnusDto alumnus)
        {
            alumnus = UnitOfWork.Update(new OSU2Context()).AlumnusRepository.GetAlumnusLogIn(alumnus.Username, alumnus.Password);
            if (alumnus != null)
                return alumnus;
            return null;
        }

        public EmployeeDto EmployeeLogIn(EmployeeDto employee)
        {
            employee = UnitOfWork.Update(new OSU2Context()).EmployeeRepository.GetEmployeeUsername(employee.Username, employee.Password);
            if (employee != null)
                return employee;
            return null;
        }

        public AdminDto GetAdminLogIn(AdminDto admin)
        {
            admin = UnitOfWork.Update(new OSU2Context()).AdminRepository.GetAdminLogin(admin.Username, admin.Password);
            if (admin != null)
                return admin;
            return null;
        }
    }
}
