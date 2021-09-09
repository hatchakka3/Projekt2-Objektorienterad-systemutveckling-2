using BusinessEntities;
using BusinessLayer;
using DataLayer;
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

namespace PresentationLayer.AlumnusView
{
    public partial class ChangePasswordForm : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AlumnusDto Alumnus { get; set; }
        private EmployeeDto Employee { get; set; }
        private AdminDto Admin { get; set; }

        public ChangePasswordForm(AdminDto admin, FacadeServices facadeServices)
        {
            InitializeComponent();
            Admin = admin;
            FacadeServices = facadeServices;
        }

        public ChangePasswordForm(AlumnusDto alumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Alumnus = alumnus;
            FacadeServices = facadeServices;
        }

        public ChangePasswordForm(EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Alumnus != null)
            {
                FacadeServices.UpdateServices.ValidateAlumnusPassword(Alumnus);
                if (Alumnus.Password != txtCurrentPassword.Text)
                {
                    MessageBox.Show("Invalid password!");
                }
                else if (txtNewPassword.Text != txtVerifyPassword.Text)
                {
                    MessageBox.Show("Password doesn't match!");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to make the following changes?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Alumnus.Password = txtNewPassword.Text;
                        FacadeServices.UpdateServices.UpdateAlumnusPassword(Alumnus.AlumnusDtoId, Alumnus);
                        Visible = !Visible;
                        EditProfileForm epf = new EditProfileForm(Alumnus, FacadeServices);
                        if (epf.ShowDialog() == DialogResult.OK)
                            Visible = !Visible;
                    }
                }
            }
            if(Employee != null)
            {
                FacadeServices.UpdateServices.ValidateEmployeePassword(Employee);
                if (Employee.Password != txtCurrentPassword.Text)
                {
                    MessageBox.Show("Invalid password!");
                }
                else if (txtNewPassword.Text != txtVerifyPassword.Text)
                {
                    MessageBox.Show("Password doesn't match!");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to make the following changes?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Employee.Password = txtNewPassword.Text;
                        FacadeServices.UpdateServices.UpdateEmployeePassword(Employee.EmployeeDtoId, Employee);
                        Visible = !Visible;
                        EditEmployeeInfoForm epf = new EditEmployeeInfoForm(Employee, FacadeServices);
                        if (epf.ShowDialog() == DialogResult.OK)
                            Visible = !Visible;
                    }
                }
            }
            else if (Admin != null)
            {
                FacadeServices.UpdateServices.ValidateAdminPassword(Admin);
                if (Admin.Password != txtCurrentPassword.Text)
                {
                    MessageBox.Show("Invalid password!");
                }
                else if (txtNewPassword.Text != txtVerifyPassword.Text)
                {
                    MessageBox.Show("Password doesn't match!");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to make the following changes?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Admin.Password = txtNewPassword.Text;
                        FacadeServices.UpdateServices.UpdateAdminPassword(Admin.AdminDtoId, Admin);
                        Visible = !Visible;
                        EditEmployeeInfoForm epf = new EditEmployeeInfoForm(Admin, FacadeServices);
                        if (epf.ShowDialog() == DialogResult.OK)
                            Visible = !Visible;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(Alumnus != null)
            {
                Visible = !Visible;
                EditProfileForm alp = new EditProfileForm(Alumnus, FacadeServices);
                if (alp.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            if(Employee != null)
            {
                Visible = !Visible;
                EditEmployeeInfoForm eeif = new EditEmployeeInfoForm(Employee, FacadeServices);
                if (eeif.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            if(Admin != null)
            {
                Visible = !Visible;
                EditEmployeeInfoForm eeif = new EditEmployeeInfoForm(Admin, FacadeServices);
                if (eeif.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }
    }
}
