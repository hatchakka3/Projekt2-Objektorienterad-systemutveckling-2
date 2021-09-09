using BusinessLayer;
using Caliburn.Micro;
using ResponsiveGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveGUI.ViewModels
{
    public class AdminAppViewModel : Screen
    {
        Admin Admin { get; set; }
        FacadeServices FacadeServices { get; set; }

        public AdminAppViewModel(Admin admin, FacadeServices facadeServices)
        {
            FacadeServices = facadeServices;
            Admin = admin;
        }
    }
}
