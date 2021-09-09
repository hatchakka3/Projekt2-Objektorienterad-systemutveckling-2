using BusinessEntities;
using BusinessLayer;
using PresentationLayer.CommonForms;
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

namespace PresentationLayer.AdminView
{
    public partial class AdminApp : Form
    {
        private AdminDto Admin { get; set; }
        public FacadeServices FacadeServices { get; set; } 
        public AdminApp()
        {
            InitializeComponent();
        }

        public AdminApp(AdminDto admin, FacadeServices facadeServices)
        {
            InitializeComponent();
            Admin = admin;
            FacadeServices = facadeServices;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            LogIn logIn = new LogIn(FacadeServices);
            if (logIn.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EditEmployeeInfoForm eei = new EditEmployeeInfoForm(Admin, FacadeServices);
            if (eei.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AddEmployeeForm add = new AddEmployeeForm(Admin, FacadeServices);
            if (add.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            ActivitiesForm af = new ActivitiesForm(Admin, FacadeServices);
            if (af.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            DeleteUserForm df = new DeleteUserForm(Admin, FacadeServices);
            if (df.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
