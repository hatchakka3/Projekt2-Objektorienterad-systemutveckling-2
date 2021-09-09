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
    public partial class SearchedStudents : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private EmployeeDto Employee { get; set; }
        private AlumnusDto Alumnus { get; set; }
        private ActivityDto Activity { get; set; }

        //Constructors
        public SearchedStudents()
        {
            InitializeComponent();
        }

        public SearchedStudents(EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
        }

        public SearchedStudents(AlumnusDto alumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Alumnus = alumnus;
            FacadeServices = facadeServices;
        }

        public SearchedStudents(ActivityDto activity, EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Activity = activity;
            Employee = employee;
            FacadeServices = facadeServices;
            dataGridViewStudents.DataSource = FacadeServices.GetServices.GetActivitiesAlumni(Activity);
            HideItems();
            HideColumns();
        }

        //Methods
        public void HideColumns()
        {
            dataGridViewStudents.Columns["Password"].Visible = false;
            dataGridViewStudents.Columns["SocialSecurityNumber"].Visible = false;
            dataGridViewStudents.Columns["TextualDescription"].Visible = false;
            dataGridViewStudents.Columns["AlumnusDtoId"].Visible = false;
        }

        public void HideItems()
        {
            btnSearch.Visible = false;
            btnSearch2.Visible = false;
            btnDisplayAll.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtEducation.Visible = false;
            txtName.Visible = false;
        }

        //Buttons
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = FacadeServices.GetServices.SearchAlumnusByName(txtName.Text);
            HideColumns();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = FacadeServices.GetServices.SearchAlumnusByEducation(txtEducation.Text);
            HideColumns();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Employee != null && Activity == null)
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
            else if(Activity != null && Employee != null)
            {
                Visible = !Visible;
                ActivitiesForm af = new ActivitiesForm(Employee, FacadeServices);
                if (af.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }

        private void btnSeeMoreInfo_Click(object sender, EventArgs e)
        {
            if(dataGridViewStudents.CurrentRow != null && Employee != null)
            {
                AlumnusInfo alumnusInfo = new AlumnusInfo((AlumnusDto)dataGridViewStudents.CurrentRow.DataBoundItem, Employee, FacadeServices);
                Visible = !Visible;
                if (alumnusInfo.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else if(dataGridViewStudents.CurrentRow != null && Alumnus != null)
            {
                AlumnusInfo alumnusInfo = new AlumnusInfo((AlumnusDto)dataGridViewStudents.CurrentRow.DataBoundItem, Alumnus, FacadeServices);
                Visible = !Visible;
                if (alumnusInfo.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else
            {
                MessageBox.Show("You have to choose an alumnus from the table!");
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = FacadeServices.GetServices.GetAllAlumnus();
            HideColumns();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
