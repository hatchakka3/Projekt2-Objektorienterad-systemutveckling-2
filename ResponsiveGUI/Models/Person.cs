using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ResponsiveGUI.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string username;
        private string password;
        private string socialSecurityNumber;
        private string email;

        public string Name
        {
            get { return name; }
            set { name = value;
                Changed();
            }
        }

        public string Username
        {
            get { return username; }
            set { username = value;
                Changed();
            }
        }

        public string Password
        {
            get { return password; }
            set { password = value;
                Changed();
            }
        }

        public string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value;
                Changed();
            }
        }

        public string Email
        {
            get { return email; }
            set { email = value;
                Changed();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
