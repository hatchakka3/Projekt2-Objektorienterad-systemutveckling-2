using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using BusinessLayer;
using ResponsiveGUI.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ResponsiveGUI.ViewModels
{
    public class ChangePasswordViewModel : Screen, INotifyPropertyChanged
    {
        IWindowManager manager = new WindowManager();
        FacadeServices FacadeServices { get; set; }
        Employee employee;
        string current;
        string password;
        string verifyPassword;

        public ChangePasswordViewModel(Employee employee, FacadeServices facadeServices)
        {
            Employee = employee;
            FacadeServices = facadeServices;
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; Changed(); }
        }

        public string Current
        {
            get { return current; }
            set { current = value; Changed(); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; Changed(); }
        }

        public string VerifyPassword
        {
            get { return verifyPassword; }
            set { verifyPassword = value; Changed(); }
        }

        public void EmptyStrings()
        {
            Current = null;
            Password = null;
            VerifyPassword = null;
        }

        public void SaveBtn()
        {
            if(Employee != null)
            {
                FacadeServices.UpdateServices.ValidateEmployeePassword(Employee.Dto());
                if(Employee.Password != Current)
                {
                    MessageBox.Show("Invalid password!");
                }
                else if(Password != VerifyPassword)
                {
                    MessageBox.Show("Passwords doesn't match!");
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to make the following changes?", "Message", MessageBoxButton.YesNo);

                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            Employee.Password = Password;
                            FacadeServices.UpdateServices.UpdateEmployeePassword(Employee.EmployeeDtoId, Employee.Dto());
                            manager.ShowWindow(new EditEmployeeInfoViewModel(Employee, FacadeServices), null, null);
                            TryClose();
                            break;
                        case MessageBoxResult.No:
                            EmptyStrings();
                            break;
                    }
                }
            }
        }

        public void BackBtn()
        {
            manager.ShowWindow(new EditEmployeeInfoViewModel(Employee, FacadeServices), null, null);
            TryClose();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
