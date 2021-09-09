using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataLayer;
using DataLayer.Repositories;
using BusinessLayer.ServiceFolder;

namespace BusinessLayer
{
    public class FacadeServices : IFacadeServices
    {
        public UnitOfWork Unitofwork { get; set; }

        public ILogInServices LogInServices{ get; set; }
        public IUpdateServices UpdateServices { get; set; }
        public IInsertServices InsertServices { get; set; }
        public IGetServices GetServices { get; set; }
        public IDeleteServices DeleteServices { get; set; }
        public FacadeServices(UnitOfWork unitOfWork)
        {
            Unitofwork = unitOfWork;

            LogInServices = new LogInServices(Unitofwork);
            UpdateServices = new UpdateServices(Unitofwork);
            InsertServices = new InsertServices(Unitofwork);
            GetServices = new GetServices(Unitofwork);
            DeleteServices = new DeleteServices(Unitofwork);
        }
    }
}
