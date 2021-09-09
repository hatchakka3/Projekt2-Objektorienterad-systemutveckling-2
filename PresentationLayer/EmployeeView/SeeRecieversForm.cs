using BusinessEntities;
using BusinessEntities.Entities;
using BusinessLayer;
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
    public partial class SeeRecieversForm : Form
    {
        EmployeeDto Employee { get; set; }
        FacadeServices FacadeServices { get; set; }
        MailingDto Mailing { get; set; }
 
        public SeeRecieversForm(EmployeeDto employee, FacadeServices facadeServices, MailingDto mailing)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
            Mailing = mailing;
            UpdateDataGrid();         
        }

        public void UpdateDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FacadeServices.GetServices.GetAllAlumnus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            CreateMailingsForm cf = new CreateMailingsForm(Employee, FacadeServices);
            if (cf.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1 != null)
            {
                AlumnusDto alumnus = (AlumnusDto)dataGridView1.CurrentRow.DataBoundItem;
                FacadeServices.UpdateServices.AddAlumniToMailing(alumnus, Mailing);
                MessageBox.Show("Reciever added!");
            } 
        }
    }
}
