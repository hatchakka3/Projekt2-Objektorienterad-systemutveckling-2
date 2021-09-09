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
    public partial class AlumnusInfo : Form
    {
        public FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AlumnusDto Alumnus = new AlumnusDto();
        private AlumnusDto UsingAlumnus { get; set; }
        private EmployeeDto Employee { get; set; }

        //Constructors
        public AlumnusInfo()
        {
            InitializeComponent();
        }

        public AlumnusInfo(AlumnusDto alumnus, EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            this.Alumnus = alumnus;
            Employee = employee;
            FacadeServices = facadeServices;
            Setup();
        }

        public AlumnusInfo(AlumnusDto alumnus, AlumnusDto usingAlumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Alumnus = alumnus;
            UsingAlumnus = usingAlumnus;
            FacadeServices = facadeServices;
            Setup();
        }

        //Methods
        public void Setup()
        {
            txtName.Text = Alumnus.Name;
            txtEmail.Text = Alumnus.Email;
            txtEducation.Text = Alumnus.Education;
            txtDegree.Text = Alumnus.Degree;
            txtPersonalInfo.Text = Alumnus.TextualDescription;
        }

        //Buttons
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Employee != null)
            {
                Visible = !Visible;
                SearchedStudents srs = new SearchedStudents(Employee, FacadeServices);
                if (srs.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else if(Alumnus != null)
            {
                Visible = !Visible;
                SearchedStudents srs = new SearchedStudents(UsingAlumnus, FacadeServices);
                if (srs.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }
    }
}
