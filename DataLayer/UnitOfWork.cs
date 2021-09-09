using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class UnitOfWork
    {
        public OSU2Context Osu2context { get; set; }

        public AlumnusRepository AlumnusRepository { get; set; }
        public ActivityRepository ActivityRepository { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public UnitOfWork(OSU2Context osu2context)
        {
            Osu2context = osu2context;
            AlumnusRepository = new AlumnusRepository(Osu2context);
            ActivityRepository = new ActivityRepository(Osu2context);
            EmployeeRepository = new EmployeeRepository(Osu2context);
        }

        public void SaveChanges()
        {
            Osu2context.SaveChanges();
        }
    }
}
