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
    public partial class SearchedStudents : Form
    {
        BusinessManager businessManager = new BusinessManager(new OSU2Context());
        private Employee Employee { get; set; }

        //Constructors
        public SearchedStudents()
        {
            InitializeComponent();
        }

        public SearchedStudents(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        //Methods
        public void HideColumns()
        {
            dataGridViewStudents.Columns["Password"].Visible = false;
            dataGridViewStudents.Columns["SocialSecurityNumber"].Visible = false;
            dataGridViewStudents.Columns["TextualDescription"].Visible = false;
        }

        //Buttons
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = businessManager.SearchAlumnusByName(txtName.Text);
            HideColumns();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = businessManager.SearchAlumnusByEducation(txtEducation.Text);
            HideColumns();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EmployeeApp empApp = new EmployeeApp(Employee);
            if (empApp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnSeeMoreInfo_Click(object sender, EventArgs e)
        {
            if(dataGridViewStudents.CurrentRow != null)
            {
                AlumnusInfo alumnusInfo = new AlumnusInfo((Alumnus)dataGridViewStudents.CurrentRow.DataBoundItem, Employee);
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
            dataGridViewStudents.DataSource = businessManager.GetAllAlumnus();
            HideColumns();
        }
    }
}
