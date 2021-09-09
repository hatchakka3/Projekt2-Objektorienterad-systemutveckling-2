using BusinessEntities;
using BusinessLayer;
using PresentationLayer.EmployeeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EmployeeApp : Form
    {
        private EmployeeDto Employee { get; set; }
        public FacadeServices FacadeServices { get; set; }

        //Constructors
        public EmployeeApp()
        {
            InitializeComponent();
        }

        public EmployeeApp(EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
        }

        //Buttons
        private void btnCreateActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateActivityForm caf = new CreateActivityForm(Employee, FacadeServices);
            caf.ShowDialog();
        }

        private void btnEditPersonalInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditEmployeeInfoForm editInfo = new EditEmployeeInfoForm(Employee, FacadeServices);
            editInfo.ShowDialog();
        }

        private void btnMailings_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateMailingsForm mailingsForm = new CreateMailingsForm(Employee, FacadeServices);
            mailingsForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            LogIn logIn = new LogIn(FacadeServices);
            if (logIn.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnSearchStudents_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            SearchedStudents srs = new SearchedStudents(Employee, FacadeServices);
            if (srs.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnSeeActivities_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            ActivitiesForm act = new ActivitiesForm(Employee, FacadeServices);
            if (act.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
