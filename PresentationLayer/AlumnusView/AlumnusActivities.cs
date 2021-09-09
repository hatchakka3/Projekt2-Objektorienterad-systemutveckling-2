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
    public partial class AlumnusActivities : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private AlumnusDto Alumnus { get; set; }
        public AlumnusActivities()
        {
            InitializeComponent();
        }

        public AlumnusActivities(AlumnusDto alumnus, FacadeServices facadeServices)
        {
            InitializeComponent();
            Alumnus = alumnus;
            FacadeServices = facadeServices;
            dataGridViewActivities.DataSource = FacadeServices.GetServices.GetAlumnusActivities(Alumnus);
        }

        public void HideColumns()
        {
            dataGridViewActivities.Columns["Employee"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            AlumnusApp alp = new AlumnusApp(Alumnus, FacadeServices);
            if (alp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnSeeMore_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EditActivityForm eaf = new EditActivityForm((ActivityDto)dataGridViewActivities.CurrentRow.DataBoundItem, Alumnus, FacadeServices);
            if (eaf.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
