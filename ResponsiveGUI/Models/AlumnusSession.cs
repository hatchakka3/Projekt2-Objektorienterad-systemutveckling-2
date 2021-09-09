using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;

namespace ResponsiveGUI.Models
{
    public class AlumnusSession : INotifyPropertyChanged
    {
        private Alumnus alumnus;

        public Alumnus Alumnus
        {
            get { return alumnus; }
            set { alumnus = value;
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
