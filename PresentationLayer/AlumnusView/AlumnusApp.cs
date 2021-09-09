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
    public partial class AlumnusApp : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AlumnusDto Alumnus { get; set; }
        public AlumnusApp()
        {
            InitializeComponent();
        }

        public AlumnusApp(AlumnusDto alumnus, FacadeServices facadeService)
        {
            InitializeComponent();
            Alumnus = alumnus;
            FacadeServices = facadeService;
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AlumnusProfile alp = new AlumnusProfile(Alumnus, FacadeServices);
            if (alp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnSeeActivities_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            ActivitiesForm aaf = new ActivitiesForm(Alumnus, FacadeServices);
            if (aaf.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            LogIn logIn = new LogIn(FacadeServices);
            if (logIn.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnMyActivities_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AlumnusActivities aat = new AlumnusActivities(Alumnus, FacadeServices);
            if (aat.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            SearchedStudents ss = new SearchedStudents(Alumnus, FacadeServices);
            if (ss.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FacadeServices.DeleteServices.DeleteAlumnus(Alumnus);

                Visible = !Visible;
                LogIn logIn = new LogIn(FacadeServices);
                if (logIn.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
        }
    }
}
