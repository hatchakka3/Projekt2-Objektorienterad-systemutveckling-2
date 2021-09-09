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
    public partial class EditProfileForm : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AlumnusDto Alumnus { get; set; }
        public EditProfileForm()
        {
            InitializeComponent();
        }

        public EditProfileForm(AlumnusDto alumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Alumnus = alumnus;
            FacadeServices = facadeServices;
            SetUp();
        }

        public void SetUp()
        {
            txtName.Text = Alumnus.Name;
            txtUsername.Text = Alumnus.Username;
            txtEmail.Text = Alumnus.Email;
            txtDescription.Text = Alumnus.TextualDescription;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to make the following changes?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Alumnus.Name = txtName.Text;
                Alumnus.Username = txtUsername.Text;
                Alumnus.Email = txtEmail.Text;
                Alumnus.TextualDescription = txtDescription.Text;
                FacadeServices.UpdateServices.UpdateAlumnusProfile(Alumnus.AlumnusDtoId, Alumnus);
                SetUp();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            ChangePasswordForm cpf = new ChangePasswordForm(Alumnus, FacadeServices);
            if (cpf.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AlumnusProfile alp = new AlumnusProfile(Alumnus, FacadeServices);
            if (alp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
