using BusinessEntities;
using BusinessLayer;
using DataLayer;
using DataLayer.Seed;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //new DbReset(new OSU2Context()).Execute();
            
            OSU2Context osu2Context = new OSU2Context();
            UnitOfWork unitOfWork = new UnitOfWork(osu2Context);
            FacadeServices FacadeServices = new FacadeServices(unitOfWork);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(FacadeServices));

            //Seed.Populate(osu2Context);
        }
    }
}
