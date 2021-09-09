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
    public partial class RegistrationForm : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        Subject s = new Subject();
        Observer o;
        public RegistrationForm(FacadeServices facadeServices)
        {
            InitializeComponent();
            UpdateComboboxes();
            FacadeServices = facadeServices;
            o = new Observer(checkBoxTerms);
            s.Attach(o);
        }

        public void UpdateComboboxes()
        {
            comboBoxEducation.Items.Add("Computer economist");
            comboBoxEducation.Items.Add("System architecture");
            comboBoxEducation.Items.Add("Systems science");

            comboBoxDegree.Items.Add("Bachelor");
            comboBoxDegree.Items.Add("Master of science");
            comboBoxDegree.Items.Add("Master");
            comboBoxDegree.Items.Add("PhD");
        }

        private void txtSSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            s.Notify();
            AlumnusDto alumnus = new AlumnusDto();
            alumnus.Name = txtName.Text;
            alumnus.SocialSecurityNumber = txtSSN.Text;
            alumnus.TextualDescription = txtTextualDescription.Text;
            alumnus.Password = txtPassword.Text;
            alumnus.Username = txtUsername.Text;
            alumnus.Email = txtEmail.Text;

            if (comboBoxEducation.SelectedItem == null)
            {
                MessageBox.Show("No education specified");
            }

            else  if(comboBoxDegree.SelectedItem == null)
            {
                MessageBox.Show("No degree specified");
            }

            else if (!checkBoxTerms.Checked)
            {
                MessageBox.Show("You have to agree to our terms and conditions!");
            }
            else if(comboBoxDegree.SelectedIndex > -1 && comboBoxEducation.SelectedIndex > -1 && checkBoxTerms.Checked == true)
            {
                alumnus.Degree = comboBoxDegree.SelectedItem.ToString();
                alumnus.Education = comboBoxEducation.SelectedItem.ToString();
                FacadeServices.InsertServices.RegistrationAlumnus(alumnus);
                MessageBox.Show("Welcome to this application, we hope you enjoy it!");

                this.Visible = !this.Visible;
                LogIn logIn = new LogIn(FacadeServices);
                if (logIn.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            LogIn login = new LogIn(FacadeServices);
            if (login.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void checkBoxTerms_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
