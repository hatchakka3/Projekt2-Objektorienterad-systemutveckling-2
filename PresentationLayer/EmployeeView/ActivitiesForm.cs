using BusinessLayer;
using DataLayer;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.EmployeeView
{
    public partial class ActivitiesForm : Form
    {
        Service businessManager = new Service(new OSU2Context());
        public ActivitiesForm()
        {
            InitializeComponent();
            dataGridViewActivities.DataSource = businessManager.GetAllActivities();
        }

        private void dataGridViewActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditActivity_Click(object sender, EventArgs e)
        {
            if(dataGridViewActivities.CurrentRow != null)
            {
                EditActivityForm eaf = new EditActivityForm((Activity)dataGridViewActivities.CurrentRow.DataBoundItem);
                Visible = !Visible;
                if (eaf.ShowDialog() == DialogResult.OK)
                    Visible = !Visible;
            }
            else
            {
                MessageBox.Show("You have to choose an activity!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EmployeeApp empApp = new EmployeeApp();
            if (empApp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
