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
    public partial class ChangePasswordForm : Form
    {
        Service businessManager = new Service(new OSU2Context());
        private Alumnus Alumnus = new Alumnus();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(Alumnus alumnus)
        {
            InitializeComponent();
            Alumnus = alumnus;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            businessManager.alumnusServices.ValidateAlumnusPassword(txtCurrentPassword.Text);
            if(Alumnus.Password != txtCurrentPassword.Text)
            {
                MessageBox.Show("Invalid password!");
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to make the following changes?","Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    businessManager.alumnusServices.UpdateAlumnusPassword(Alumnus.AlumnusId, txtNewPassword.Text);
                    Visible = !Visible;
                    EditProfileForm epf = new EditProfileForm(Alumnus);
                    if (epf.ShowDialog() == DialogResult.OK)
                        Visible = !Visible;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EditProfileForm alp = new EditProfileForm(Alumnus);
            if (alp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
