using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveGUI.Models
{
    public class EmployeeSession : INotifyPropertyChanged 
    {
        private Employee employee;

        public Employee Employee
        {
            get { return employee; }
            set { employee = value;
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
