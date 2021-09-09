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
using System.Collections.ObjectModel;
using BusinessEntities;

namespace ResponsiveGUI.ViewModels
{
    public class SearchAlumniViewModel : Screen, INotifyPropertyChanged
    {
        IWindowManager manager = new WindowManager();
        FacadeServices FacadeServices { get; set; }
        Employee employee;
        string name;
        string education;
        IEnumerable<AlumnusDto> alumni;

        public SearchAlumniViewModel(Employee employee, FacadeServices facadeServices)
        {
            FacadeServices = facadeServices;
            Employee = employee;
            alumni = new List<AlumnusDto>();
        }

        public IEnumerable<AlumnusDto> Alumni
        {
            get { return alumni; }
            set { alumni = value; Changed(); }
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; Changed(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; Changed(); }
        }

        public string Education
        {
            get { return education; }
            set { education = value; Changed(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SearchNameBtn()
        {
            Alumni = FacadeServices.GetServices.SearchAlumnusByName(Name);
        }

        public void SearchEducationBtn()
        {
            Alumni = FacadeServices.GetServices.SearchAlumnusByEducation(Education);
        }

        public void DisplayAllAlumnsBtn()
        {
            Alumni = FacadeServices.GetServices.GetAllAlumnus();
        }
    }
}
