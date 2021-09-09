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
    public partial class EditEmployeeInfoForm : Form
    {
        BusinessManager businessManager = new BusinessManager(new OSU2Context());
        private Employee Employee = new Employee();

        //Constructors
        public EditEmployeeInfoForm()
        {
            InitializeComponent();
        }

        public EditEmployeeInfoForm(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            SetUp();
        }

        //Methods
        public void SetUp()
        {
            txtUserName.Text = Employee.Username;
            txtEmail.Text = Employee.Email;
        }

        //Buttons
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to make the following changes?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {
                  businessManager.UpdateEmployee(Employee.EmployeeId, txtUserName.Text, txtEmail.Text);
                  Visible = !Visible;
                  EmployeeApp empApp = new EmployeeApp(Employee);
                  if (empApp.ShowDialog() == DialogResult.OK)
                     Visible = !Visible;
               }             
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EmployeeApp empApp = new EmployeeApp(Employee);
            if (empApp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            ChangePasswordForm cpf = new ChangePasswordForm(Employee);
            if (cpf.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
