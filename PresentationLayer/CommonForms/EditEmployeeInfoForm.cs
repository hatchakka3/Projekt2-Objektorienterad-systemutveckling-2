using BusinessEntities;
using BusinessLayer;
using DataLayer;
using PresentationLayer.AdminView;
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
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private EmployeeDto Employee { get; set; }
        private AdminDto Admin { get; set; }

        //Constructors
        public EditEmployeeInfoForm()
        {
            InitializeComponent();
        }

        public EditEmployeeInfoForm(EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
            SetUp();
        }

        public EditEmployeeInfoForm(AdminDto admin, FacadeServices facadeServices)
        {
            InitializeComponent();
            Admin = admin;
            FacadeServices = facadeServices;
            SetUp2();
        }

        //Methods
        public void SetUp()
        {
            txtUserName.Text = Employee.Username;
            txtEmail.Text = Employee.Email;
        }

        public void SetUp2()
        {
            txtUserName.Text = Admin.Username;
            txtEmail.Text = Admin.Email;
        }

        //Buttons
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to make the following changes?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {
                if(Employee != null)
                {
                    Employee.Username = txtUserName.Text;
                    Employee.Email = txtEmail.Text;
                    FacadeServices.UpdateServices.UpdateEmployee(Employee.EmployeeDtoId, Employee);
                    Visible = !Visible;
                    EmployeeApp empApp = new EmployeeApp(Employee, FacadeServices);
                    if (empApp.ShowDialog() == DialogResult.OK)
                        Visible = !Visible;
                }
                if(Admin != null)
                {
                    Admin.Username = txtUserName.Text;
                    Admin.Email = txtEmail.Text;
                    FacadeServices.UpdateServices.UpdateAdmin(Admin.AdminDtoId, Admin);
                    Visible = !Visible;
                    AdminApp adApp = new AdminApp(Admin, FacadeServices);
                    if (adApp.ShowDialog() == DialogResult.OK)
                        Visible = !Visible;
                }
               }             
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(Employee != null)
            {
                Visible = !Visible;
                EmployeeApp empApp = new EmployeeApp(Employee, FacadeServices);
                if (empApp.ShowDialog() == DialogResult.OK)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(Employee != null)
            {
                Visible = !Visible;
                ChangePasswordForm cpf = new ChangePasswordForm(Employee, FacadeServices);
                if (cpf.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            if (Admin != null)
            {
                Visible = !Visible;
                ChangePasswordForm cpForm = new ChangePasswordForm(Admin, FacadeServices);
                if (cpForm.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }
    }
}
