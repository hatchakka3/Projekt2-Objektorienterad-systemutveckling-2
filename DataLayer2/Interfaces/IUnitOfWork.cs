using DataLayer.Repositories;

namespace DataLayer
{
    public interface IUnitOfWork
    {
        IActivityRepository ActivityRepository { get; set; }
        IAdminRepository AdminRepository { get; set; }
        IAlumnusRepository AlumnusRepository { get; set; }
        IEmployeeRepository EmployeeRepository { get; set; }
        IMailingRepository MailingRepository { get; set; }
        OSU2Context Osu2context { get; set; }

        void SaveChanges();
        UnitOfWork Update(OSU2Context osu2context);
    }
}