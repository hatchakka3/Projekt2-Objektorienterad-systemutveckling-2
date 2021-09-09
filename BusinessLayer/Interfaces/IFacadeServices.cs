using BusinessLayer.ServiceFolder;
using DataLayer;

namespace BusinessLayer
{
    public interface IFacadeServices
    {
        IDeleteServices DeleteServices { get; set; }
        IGetServices GetServices { get; set; }
        IInsertServices InsertServices { get; set; }
        ILogInServices LogInServices { get; set; }
        UnitOfWork Unitofwork { get; set; }
        IUpdateServices UpdateServices { get; set; }
    }
}