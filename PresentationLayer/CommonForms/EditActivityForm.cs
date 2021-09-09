using BusinessEntities;
using BusinessLayer;
using DataLayer;
using PresentationLayer.AlumnusView;
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
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private ActivityDto Activity { get; set; }
        private EmployeeDto Employee { get; set; }
        private AlumnusDto Alumnus { get; set; }

        //Constructors
        public EditActivityForm()
        {
            InitializeComponent();
        }

        public EditActivityForm(ActivityDto activity, EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Activity = activity;
            Employee = employee;
            FacadeServices = facadeServices;
            SetUp();
        }

        public EditActivityForm(ActivityDto activity, AlumnusDto alumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Activity = activity;
            Alumnus = alumnus;
            FacadeServices = facadeServices;
            SetUp();
            HideButton();
        }

        //Methods
        public void HideButton()
        {
            if(Alumnus != null && Employee == null)
            {
                btnUpdate.Visible = false;
            }
        }

        public void SetUp()
        {
            txtDescritption.Text = Activity.Description;
            monthCalendar1.SelectionStart = Activity.StartDate;
            monthCalendar1.SelectionEnd = Activity.EndDate;           
        }

        //Buttons
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to make the following changes?","Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Activity.Description = txtDescritption.Text;
                Activity.StartDate = monthCalendar1.SelectionStart;
                Activity.EndDate = monthCalendar1.SelectionEnd;
                FacadeServices.UpdateServices.UpdateActivity(Activity.ActivityDtoID, Activity);
                Visible = !Visible;
                ActivitiesForm act = new ActivitiesForm(Employee, FacadeServices);
                if (act.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Employee != null)
            {
                Visible = !Visible;
                ActivitiesForm empApp = new ActivitiesForm(Employee, FacadeServices);
                if (empApp.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else if(Alumnus != null)
            {
                Visible = !Visible;
                ActivitiesForm af = new ActivitiesForm(Alumnus, FacadeServices);
                if (af.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }
    }
}
