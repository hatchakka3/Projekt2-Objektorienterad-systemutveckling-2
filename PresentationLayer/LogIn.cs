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

namespace PresentationLayer
{
    public partial class LogIn : Form
    {
        public FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));

        public LogIn(FacadeServices facadeServices)
        {
            InitializeComponent();
            FacadeServices = facadeServices;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            EmployeeDto employee = new EmployeeDto();
            employee.Username = txtUserName.Text;
            employee.Password = txtPassword.Text;
            employee = FacadeServices.LogInServices.EmployeeLogIn(employee);

            AlumnusDto alumnus = new AlumnusDto();
            alumnus.Username = txtUserName.Text;
            alumnus.Password = txtPassword.Text;
            alumnus = FacadeServices.LogInServices.AlumnusLogIn(alumnus);

            AdminDto admin = new AdminDto();
            admin.Username = txtUserName.Text;
            admin.Password = txtPassword.Text;
            admin = FacadeServices.LogInServices.GetAdminLogIn(admin);

            if (employee == null && alumnus == null && admin == null)
            {
                MessageBox.Show("Wrong credentials");
            }
            else if(employee != null)
            {
                Visible = !Visible;
                EmployeeApp empApp = new EmployeeApp(employee, FacadeServices);
                if (empApp.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else if(alumnus != null)
            {
                Visible = !Visible;
                AlumnusApp aluApp = new AlumnusApp(alumnus, FacadeServices);
                if (aluApp.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else if(admin != null)
            {
                Visible = !Visible;
                AdminApp aApp = new AdminApp(admin, FacadeServices);
                if (aApp.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm regForm = new RegistrationForm(FacadeServices);
            regForm.ShowDialog();
        }
    }
}
