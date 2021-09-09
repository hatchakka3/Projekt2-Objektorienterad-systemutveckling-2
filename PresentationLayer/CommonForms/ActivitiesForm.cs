using BusinessLayer;
using DataLayer;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.AlumnusView;
using PresentationLayer.AdminView;

namespace PresentationLayer.EmployeeView
{ 
    public partial class ActivitiesForm : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AlumnusDto Alumnus { get; set; }
        private EmployeeDto Employee { get; set; }
        private AdminDto Admin { get; set; }

        //Constructors
        public ActivitiesForm(AdminDto admin, FacadeServices facadeServices)
        {
            InitializeComponent();
            Admin = admin;
            FacadeServices = facadeServices;
            dataGridViewActivities.DataSource = FacadeServices.GetServices.GetAllActivities();
            HideButtons();
            HideColumns();
        }

        public ActivitiesForm(AlumnusDto alumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Alumnus = alumnus;
            FacadeServices = facadeServices;
            dataGridViewActivities.DataSource = FacadeServices.GetServices.GetAllActivities();
            HideButtons();
            HideColumns();
        }

        public ActivitiesForm(EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
            dataGridViewActivities.DataSource = FacadeServices.GetServices.GetAllActivities();
            HideButtons();
            HideColumns();
        }

        //Methods & buttons
        public void HideButtons()
        {
            if(Alumnus != null)
            {
                btnEditActivity.Visible = false;
                btnDelete.Visible = false;
                btnSeeAlumni.Visible = false;
            }
            if(Employee != null)
            {
                btnSignUp.Visible = false;
                btnSeeMore.Visible = false;
                btnDelete.Visible = false;
            }
            if(Admin != null)
            {
                btnSignUp.Visible = false;
                btnSeeMore.Visible = false;
                btnEditActivity.Visible = false;
                btnSeeAlumni.Visible = false;
            }
        }

        public void HideColumns()
        {
            dataGridViewActivities.Columns["ActivityDtoId"].Visible = false;
        }

        private void dataGridViewActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditActivity_Click(object sender, EventArgs e)
        {
            if(dataGridViewActivities.CurrentRow != null)
            {
                EditActivityForm eaf = new EditActivityForm((ActivityDto)dataGridViewActivities.CurrentRow.DataBoundItem, Employee, FacadeServices);
                Visible = !Visible;
                if (eaf.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else
            {
                MessageBox.Show("You have to choose an activity!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Employee != null)
            {
                Visible = !Visible;
                EmployeeApp empApp = new EmployeeApp(Employee, FacadeServices);
                if (empApp.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else if(Alumnus != null)
            {
                Visible = !Visible;
                AlumnusApp alp = new AlumnusApp(Alumnus, FacadeServices);
                if (alp.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else if(Admin != null)
            {
                Visible = !Visible;
                AdminApp app = new AdminApp(Admin, FacadeServices);
                if (app.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (dataGridViewActivities.CurrentRow != null)
            {
                FacadeServices.UpdateServices.SignUpForActivity((ActivityDto)dataGridViewActivities.CurrentRow.DataBoundItem, Alumnus.AlumnusDtoId);
                MessageBox.Show("You are now signed up for this activity!");
            }
        }

        private void btnSeeMore_Click(object sender, EventArgs e)
        {
            if(dataGridViewActivities.CurrentRow != null)
            {
                EditActivityForm eaf = new EditActivityForm((ActivityDto)dataGridViewActivities.CurrentRow.DataBoundItem, Alumnus, FacadeServices);
                Visible = !Visible;
                if (eaf.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewActivities.CurrentRow != null)
            {
                FacadeServices.DeleteServices.DeleteActivity((ActivityDto)dataGridViewActivities.CurrentRow.DataBoundItem);
                dataGridViewActivities.DataSource = null;
                dataGridViewActivities.DataSource = FacadeServices.GetServices.GetAllActivities();
                HideColumns();
            }
        }

        private void btnSeeAlumni_Click(object sender, EventArgs e)
        {
            if(dataGridViewActivities.CurrentRow != null)
            {
                Visible = !Visible;
                SearchedStudents srs = new SearchedStudents((ActivityDto)dataGridViewActivities.CurrentRow.DataBoundItem, Employee, FacadeServices);
                if (srs.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }
    }
}
