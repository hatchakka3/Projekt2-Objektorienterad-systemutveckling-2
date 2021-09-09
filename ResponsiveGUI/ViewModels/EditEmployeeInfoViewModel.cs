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
    public class EditEmployeeInfoViewModel : Screen, INotifyPropertyChanged
    {
        IWindowManager manager = new WindowManager();
        FacadeServices FacadeServices { get; set; }
        Employee employee;
        string username;
        string email;

        public EditEmployeeInfoViewModel(Employee employee, FacadeServices facadeServices)
        {
            Employee = employee;
            FacadeServices = facadeServices;
            SetUp();
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; Changed(); }
        }

        public string Username
        {
            get { return username; }
            set { username = value; Changed(); }
        }

        public string Email
        {
            get { return email; }
            set { email = value; Changed(); }
        }

        public void SetUp()
        {
            Username = Employee.Username;
            Email = Employee.Email;
        }

        public void UpdateBtn()
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to make the follwing changes?", "EditEmployeeInfoView", MessageBoxButton.YesNo);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    if(Employee != null)
                    {
                        Employee.Username = Username;
                        Employee.Email = Email;
                        FacadeServices.UpdateServices.UpdateEmployee(Employee.EmployeeDtoId, Employee.Dto());
                    }
                    break;
                case MessageBoxResult.No:
                    SetUp();
                    break;
            }
        }

        public void ChangePasswordBtn()
        {
            manager.ShowWindow(new ChangePasswordViewModel(Employee, FacadeServices), null, null);
            TryClose();
        }

        public void BackBtn()
        {
            manager.ShowWindow(new EmployeeAppViewModel(Employee, FacadeServices), null, null);
            TryClose();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
