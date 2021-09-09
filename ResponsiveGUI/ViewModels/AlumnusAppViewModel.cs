using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using ResponsiveGUI.Models;
using BusinessLayer;

namespace ResponsiveGUI.ViewModels
{
    public class AlumnusAppViewModel : Screen
    {
        Alumnus Alumnus { get; set; }
        FacadeServices FacadeServices { get; set; }

        public AlumnusAppViewModel(Alumnus alumnus, FacadeServices facadeServices)
        {
            FacadeServices = facadeServices;
            Alumnus = alumnus;
        }
    }
}
