using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiveGUI.ViewModels
{
    public class ActivitiesViewModel : Screen
    {
        IWindowManager windowManager = new WindowManager();

        public void EditActivity()
        {
            windowManager.ShowWindow(new EditActivityViewModel(), null, null);
        }
    }
}
