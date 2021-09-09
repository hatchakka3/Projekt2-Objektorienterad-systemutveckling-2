using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BusinessLayer;
using ResponsiveGUI.Models;
using System.Windows;

namespace ResponsiveGUI.ViewModels
{
    public class RegistrationViewModel : Screen, INotifyPropertyChanged
    {
        IWindowManager manager = new WindowManager();
        string name;
        string ssn;
        string education;
        string degree;
        string email;
        string username;
        string password;
        string information;
        bool check = false;
        FacadeServices FacadeServices { get; set; }

        public RegistrationViewModel(FacadeServices facadeServices)
        {
            FacadeServices = facadeServices;
        }

        public string Name
        {
            get { return name; }
            set { name = value; Changed(); }
        }

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; Changed(); }
        }

        public string Education
        {
            get { return education; }
            set { education = value; Changed(); }
        }

        public string Degree
        {
            get { return degree; }
            set { degree = value; Changed(); }
        }

        public string Email
        {
            get { return email; }
            set { email = value; Changed(); }
        }

        public string Username
        {
            get { return username; }
            set { username = value; Changed(); }
        }

        public string Password
        {
            get { return password; }
            set { password = value; Changed(); }
        }

        public string Information
        {
            get { return information; }
            set { information = value; Changed(); }
        }

        public bool Check
        {
            get { return check; }
            set { check = value; Changed(); }
        }

        public void RegisterBtn()
        {
            Alumnus alumnus = new Alumnus();
            alumnus.Name = Name;
            alumnus.SocialSecurityNumber = SSN;
            alumnus.Education = Education;
            alumnus.Degree = Degree;
            alumnus.Email = Email;
            alumnus.Username = Username;
            alumnus.Password = Password;
            alumnus.TextualDescription = Information;

            if(Check == false)
            {
                MessageBox.Show("You have to agree to our Terms and Conditions!");
            }
            else
            {
                FacadeServices.InsertServices.RegistrationAlumnus(alumnus.Dto());
                manager.ShowWindow(new LogInViewModel(), null, null);
                TryClose();
            }
        }

        public void BackBtn()
        {
            manager.ShowWindow(new LogInViewModel(), null, null);
            TryClose();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
