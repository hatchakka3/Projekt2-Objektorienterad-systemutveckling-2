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

namespace PresentationLayer.AlumnusView
{
    public partial class AlumnusProfile : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AlumnusDto Alumnus { get; set; }
        public AlumnusProfile()
        {
            InitializeComponent();
        }

        public AlumnusProfile(AlumnusDto alumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Alumnus = alumnus;
            FacadeServices = facadeServices;
            Setup();
        }

        public void Setup()
        {
            txtName.Text = Alumnus.Name;
            txtUsername.Text = Alumnus.Username;
            txtEmail.Text = Alumnus.Email;
            txtDegree.Text = Alumnus.Degree;
            txtEducation.Text = Alumnus.Education;
            txtSSN.Text = Alumnus.SocialSecurityNumber;
            txtDescription.Text = Alumnus.TextualDescription;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AlumnusApp alp = new AlumnusApp(Alumnus, FacadeServices);
            if (alp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EditProfileForm epf = new EditProfileForm(Alumnus, FacadeServices);
            if (epf.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
