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
    public partial class ActivitiesAlumnusForm : Form
    {
        Service businessManager = new Service(new OSU2Context());
        private Alumnus Alumnus = new Alumnus();
        public ActivitiesAlumnusForm()
        {
            InitializeComponent();
        }

        public ActivitiesAlumnusForm(Alumnus alumnus)
        {
            InitializeComponent();
            Alumnus = alumnus;
            dataGridViewActivities.DataSource = businessManager.GetAllActivities();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
