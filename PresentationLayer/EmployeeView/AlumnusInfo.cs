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
        public BusinessManager businessManager = new BusinessManager(new OSU2Context());
        private Alumnus Alumnus = new Alumnus();
        private Employee Employee { get; set; }

        //Constructors
        public AlumnusInfo()
        {
            InitializeComponent();
        }

        public AlumnusInfo(Alumnus alumnus, Employee employee)
        {
            InitializeComponent();
            this.Alumnus = alumnus;
            Employee = employee;
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
            Visible = !Visible;
            SearchedStudents srs = new SearchedStudents(Employee);
            if (srs.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
