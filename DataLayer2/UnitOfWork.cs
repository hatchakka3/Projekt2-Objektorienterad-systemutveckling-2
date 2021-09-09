using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private OSU2Context osu2Context;

        public OSU2Context Osu2context
        {
            get { return osu2Context; }
            set
            {
                osu2Context = value;
                Update(osu2Context);
            }
        }

        public IAlumnusRepository AlumnusRepository { get; set; }
        public IActivityRepository ActivityRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IAdminRepository AdminRepository { get; set; }
        public IMailingRepository MailingRepository { get; set; }

        public UnitOfWork(OSU2Context osu2context)
        {
            Osu2context = osu2context;
        }

        public UnitOfWork Update(OSU2Context osu2context)
        {
            AlumnusRepository = new AlumnusRepository(osu2context);
            ActivityRepository = new ActivityRepository(osu2context);
            EmployeeRepository = new EmployeeRepository(osu2context);
            AdminRepository = new AdminRepository(osu2context);
            MailingRepository = new MailingRepository(osu2Context);

            return this;
        }

        public void SaveChanges()
        {
            Osu2context.SaveChanges();
        }
    }
}
