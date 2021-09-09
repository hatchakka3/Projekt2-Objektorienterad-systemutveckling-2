using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using BusinessLayer;
using BusinessEntities;
using System.Windows;
using System.ComponentModel;
using ResponsiveGUI.Models;
using System.Runtime.CompilerServices;

namespace ResponsiveGUI.ViewModels
{
    public class CreateActivityViewModel : Screen, INotifyPropertyChanged
    {
        FacadeServices FacadeServices { get; set; } 
        Employee Employee { get; set; }
        Activity Activity;
        IWindowManager manager = new WindowManager();

        public CreateActivityViewModel(Employee employee, FacadeServices facadeService)
        {
            Employee = employee;
            FacadeServices = facadeService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Activity activity
        {
            get { return Activity; }
            set { activity = value; Changed(); }
        }

        //Constructors
        string description;
        DateTime calender;
        DateTime calenders;
        public string Description
        {
            get { return description; }
            set { description = value; Changed(); }
        }

        public DateTime Calender
        {
            get { return calender; }
            set { calender = value; Changed(); }
        }

        public DateTime Calenders
        {
            get { return calenders; }
            set { calenders = value; Changed(); }
        }

        public void SubmitActivityBtn()
        {
            Activity = new Activity();

            if (Calender == null || Calenders == null)
            {
                MessageBox.Show("Please choose a date");
            }
            else if(Calender > Calenders)
            {
                MessageBox.Show("Invalid dates!");
            }
            else
            {
                activity.StartDate = Calender;
                activity.EndDate = Calenders;
                activity.Description = Description;
                FacadeServices.InsertServices.CreateActivity(this.Activity.Dto(), this.Employee.Dto());

                MessageBox.Show("Activity created!");
            }
        }

        public void BackBtn()
        {
            manager.ShowWindow(new EmployeeAppViewModel(Employee, FacadeServices), null, null);
            TryClose();
        }
    }
}
