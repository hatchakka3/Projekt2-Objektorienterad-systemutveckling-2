using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PresentationLayer
{
    public class Observer : IObserver
    {
        public Observer(CheckBox checkBox)
        {
            CheckBox = checkBox;
        }
        private CheckBox CheckBox { get; }
        public void ObserverUpdate()
        {
            if (!CheckBox.Checked)
            {
                CheckBox.ForeColor = Color.Red;
            }
            else
            {
                CheckBox.ForeColor = Color.Green;
            }
        }
    }
}
