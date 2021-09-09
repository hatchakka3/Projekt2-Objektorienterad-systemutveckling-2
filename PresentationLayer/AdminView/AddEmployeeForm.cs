using BusinessEntities;
using BusinessLayer;
using DataLayer;
using PresentationLayer.AdminView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.CommonForms
{
    public partial class AddEmployeeForm : Form
    {
        public FacadeServices FacadeServices { get; set; } 
        private AdminDto Admin { get; set; }
        public AddEmployeeForm(AdminDto admin, FacadeServices facadeServices)
        {
            InitializeComponent();
            Admin = admin;
            FacadeServices = facadeServices;
            UpdateCombobox();
        }

        public void UpdateCombobox()
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Teacher");
        }

        public void EmptyingTextboxes()
        {
            txtName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtVerify.Text = string.Empty;
            txtSSN.Text = string.Empty;
            txtENumber.Text = string.Empty;
            txtSignature.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AdminApp aApp = new AdminApp(Admin, FacadeServices);
            if (aApp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string current = comboBox1.SelectedItem.ToString();

            if (current == null)
            {
                MessageBox.Show("You have to specify which type of employee you are adding!");
            }
            else if(current == "Admin")
            {
                AdminDto admin = new AdminDto();
                admin.Name = txtName.Text;
                admin.Username = txtUserName.Text;
                admin.SocialSecurityNumber = txtSSN.Text;
                admin.Email = txtEmail.Text;
                admin.EmployeeNumber = txtENumber.Text;

                if (txtPassword.Text == null)
                {
                    MessageBox.Show("You have to specify a password!");
                }
                else if(txtPassword.Text != txtVerify.Text)
                {
                    MessageBox.Show("The passwords doesn't match!");
                }
                else
                {
                    admin.Password = txtPassword.Text;
                    EmptyingTextboxes();
                    FacadeServices.InsertServices.AddAdmin(admin);
                }
            }
            else if(current == "Teacher")
            {
                EmployeeDto employee = new EmployeeDto();
                employee.Name = txtName.Text;
                employee.Username = txtUserName.Text;
                employee.SocialSecurityNumber = txtSSN.Text;
                employee.Email = txtEmail.Text;
                employee.EmployeeNumber = txtENumber.Text;
                employee.Signature = txtSignature.Text;

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("You have to specify a password!");
                }
                else if(txtPassword.Text != txtVerify.Text)
                {
                    MessageBox.Show("The password doesn't match!");
                }
                else
                {
                    employee.Password = txtPassword.Text;
                    EmptyingTextboxes();
                    FacadeServices.InsertServices.AddEmployee(employee);
                }
            }
        }
    }
}
