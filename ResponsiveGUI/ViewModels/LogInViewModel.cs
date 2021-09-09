using AutoMapper;
using BusinessLayer;
using Caliburn.Micro;
using DataLayer;
using ResponsiveGUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ResponsiveGUI.ViewModels
{
    public class LogInViewModel : Screen, INotifyPropertyChanged
    {
        IWindowManager windowManager = new WindowManager();
        FacadeServices facadeServices = new FacadeServices(new UnitOfWork(new OSU2Context()));
        Alumnus alumnus;
        Admin admin;
        Employee employee;
        string username;
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; Changed(); }
        }

        public string Username
        {
            get { return username; }
            set { username = value; Changed(); }
        }

        public Alumnus Alumnus
        {
            get { return alumnus; }
            set { alumnus = value; Changed(); }
        }
       public Admin Admin
        {
            get { return admin; }
            set { admin = value; Changed(); }
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; Changed(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LogInViewModel()
        {
            Alumnus = new Alumnus();
            Admin = new Admin();
            Employee = new Employee();
        }

        public void LogInViewLoginBtn()
        {
            Alumnus.Username = Username;
            Alumnus.Password = Password;
            BusinessEntities.AlumnusDto alumn = facadeServices.LogInServices.AlumnusLogIn(this.Alumnus.Dto());

            Admin.Username = Username;
            Admin.Password = Password;
            BusinessEntities.AdminDto Admi = facadeServices.LogInServices.GetAdminLogIn(this.Admin.Dto());

            Employee.Username = Username;
            Employee.Password = Password;
            BusinessEntities.EmployeeDto Employ = facadeServices.LogInServices.EmployeeLogIn(this.Employee.Dto());

            if (alumn == null && Admi == null && Employ == null)
            {
                MessageBox.Show("Wrong credentials!");
            }
            else if (alumn != null)
            {
                windowManager.ShowWindow(new AlumnusAppViewModel(this.Alumnus.ReverseDto(alumn), facadeServices), null, null);
                TryClose();
            }

            else if (Admi != null)
            {
                windowManager.ShowWindow(new AdminAppViewModel(this.Admin.ReverseDto(Admi), facadeServices), null, null);
                TryClose();
            }

            else if (Employ != null)
            {
                windowManager.ShowWindow(new EmployeeAppViewModel(this.Employee.ReverseDto(Employ), facadeServices), null, null);
                TryClose();
            }
        }
        public void RegisterBtn()
        {
            windowManager.ShowWindow(new RegistrationViewModel(facadeServices), null, null);
            TryClose();
        }

    }

}

