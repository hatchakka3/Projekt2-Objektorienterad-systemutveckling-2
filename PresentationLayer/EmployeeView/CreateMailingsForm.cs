using BusinessEntities;
using BusinessEntities.Entities;
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

namespace PresentationLayer.EmployeeView
{
    public partial class CreateMailingsForm : Form
    {
        FacadeServices FacadeServices { get; set; } 
        private EmployeeDto Employee { get; set; }
        MailingDto mailing { get; set; }

        public CreateMailingsForm(EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            dataGridViewMailings.DataSource = null;
            dataGridViewMailings.DataSource = FacadeServices.GetServices.GetAllMailings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EmployeeApp empApp = new EmployeeApp(Employee, FacadeServices);
            if (empApp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MailingDto mailing = new MailingDto();

            mailing.Information = textBox1.Text;

            FacadeServices.InsertServices.CreateMailing(mailing);
            MessageBox.Show("Mailing create!");
            UpdateDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeeRecievers_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            SeeRecieversForm sf = new SeeRecieversForm(Employee, FacadeServices, (MailingDto)dataGridViewMailings.CurrentRow.DataBoundItem);
            if (sf.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewMailings != null)
            {
                if (MessageBox.Show("Are you sure you want to delete the mailing?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FacadeServices.DeleteServices.DeleteMailing((MailingDto)dataGridViewMailings.CurrentRow.DataBoundItem);
                    UpdateDataGrid();
                }
            }
        }
    }
}
