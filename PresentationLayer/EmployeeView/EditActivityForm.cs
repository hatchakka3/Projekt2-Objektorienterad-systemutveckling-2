using BusinessEntities;
using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.EmployeeView
{
    public partial class EditActivityForm : Form
    {
        Service businessManager = new Service(new OSU2Context());
        private Activity Activity = new Activity();
        public EditActivityForm()
        {
            InitializeComponent();
        }

        public EditActivityForm(Activity activity)
        {
            InitializeComponent();
            Activity = activity;
            SetUp();
        }

        public void SetUp()
        {
            txtDescritption.Text = Activity.Description;
            monthCalendar1.SelectionStart = Activity.StartDate;
            monthCalendar1.SelectionEnd = Activity.EndDate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to make the following changes?","Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                businessManager.UpdateActivity(Activity.ActivityID, txtDescritption.Text, monthCalendar1.SelectionStart, monthCalendar1.SelectionEnd);
                Visible = !Visible;
                ActivitiesForm act = new ActivitiesForm();
                if (act.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            ActivitiesForm empApp = new ActivitiesForm();
            if (empApp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
