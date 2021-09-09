using BusinessEntities;
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
    public class EmployeeAppViewModel : Screen
    {
        Employee Employee { get; set; }
        FacadeServices FacadeServices { get; set; }

        public EmployeeAppViewModel(Employee employee, FacadeServices facadeServices)
        {
            FacadeServices = facadeServices;
            Employee = employee;
        }

        IWindowManager windowManager = new WindowManager();
        public void CreateActivityBtn()
        {
            windowManager.ShowWindow(new CreateActivityViewModel(Employee, FacadeServices), null, null);
            TryClose();
        }

        public void CreateMailingsBtn()
        {
            windowManager.ShowWindow(new CreateMailingsViewModel(), null, null);
        }

        public void EditPersonalInfoBtn()
        {
            windowManager.ShowWindow(new EditEmployeeInfoViewModel(Employee, FacadeServices), null, null);
            TryClose();
        }

        public void SeeActivitiesBtn()
        {
            windowManager.ShowWindow(new ActivitiesViewModel(), null, null);
        }

        public void SearchBtn()
        {
            windowManager.ShowWindow(new SearchAlumniViewModel(Employee, FacadeServices), null, null);
        }

        public void LogOutBtn()
        {
            windowManager.ShowWindow(new LogInViewModel(), null, null);
            TryClose();
        }
    }
}
