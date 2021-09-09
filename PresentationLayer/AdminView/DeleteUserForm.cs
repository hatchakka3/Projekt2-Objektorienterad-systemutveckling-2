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

namespace PresentationLayer.AdminView
{
    public partial class DeleteUserForm : Form
    {
        public FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AdminDto Admin { get; set; }

        public DeleteUserForm(AdminDto admin, FacadeServices facadeServices)
        {
            InitializeComponent();
            Admin = admin;
            FacadeServices = facadeServices;
        }

        private void btnAlumni_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FacadeServices.GetServices.GetAllAlumnus();
            dataGridView2.Visible = false;
            dataGridView2.DataSource = null;
            dataGridView3.Visible = false;
            dataGridView3.DataSource = null;
            dataGridView1.Visible = true;
            dataGridView1.Columns["Password"].Visible = false;
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = FacadeServices.GetServices.DisplayAllEmployees();
            dataGridView1.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView3.Visible = false;
            dataGridView3.DataSource = null;
            dataGridView2.Visible = true;
            dataGridView2.Columns["Password"].Visible = false;
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = FacadeServices.GetServices.GetAllAdmins();
            dataGridView1.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView2.Visible = false;
            dataGridView2.DataSource = null;
            dataGridView3.Visible = true;
            dataGridView3.Columns["Password"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                if(dataGridView1.CurrentRow != null)
                {
                    FacadeServices.DeleteServices.DeleteAlumnus((AlumnusDto)dataGridView1.CurrentRow.DataBoundItem);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = FacadeServices.GetServices.GetAllAlumnus();
                    dataGridView2.Visible = false;
                    dataGridView2.DataSource = null;
                    dataGridView3.Visible = false;
                    dataGridView3.DataSource = null;
                    dataGridView1.Visible = true;
                    dataGridView1.Columns["Password"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Please choose an alumnus from the table!");
                }
            }
            if(dataGridView2.DataSource != null)
            {
                if(dataGridView2.CurrentRow != null)
                {
                    FacadeServices.DeleteServices.DeleteEmployee((EmployeeDto)dataGridView2.CurrentRow.DataBoundItem);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = FacadeServices.GetServices.DisplayAllEmployees();
                    dataGridView1.Visible = false;
                    dataGridView1.DataSource = null;
                    dataGridView3.Visible = false;
                    dataGridView3.DataSource = null;
                    dataGridView2.Visible = true;
                    dataGridView2.Columns["Password"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Please choose an employee from the table!");
                }
            }
            else if (dataGridView3.DataSource != null)
            {
                if(dataGridView3.CurrentRow != null)
                {
                    FacadeServices.DeleteServices.DeleteAdmin((AdminDto)dataGridView3.CurrentRow.DataBoundItem);
                    dataGridView3.DataSource = null;
                    dataGridView3.DataSource = FacadeServices.GetServices.GetAllAdmins();
                    dataGridView1.Visible = false;
                    dataGridView1.DataSource = null;
                    dataGridView2.Visible = false;
                    dataGridView2.DataSource = null;
                    dataGridView3.Visible = true;
                    dataGridView3.Columns["Password"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Please choose an admin  from the table!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AdminApp app = new AdminApp(Admin, FacadeServices);
            if (app.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
