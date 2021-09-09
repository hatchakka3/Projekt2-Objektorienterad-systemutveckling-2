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

namespace PresentationLayer.EmployeeView
{
    public partial class CreateActivityForm : Form
    {
        FacadeServices FacadeServices { get; set; } //= new FacadeServices(new UnitOfWork(new OSU2Context()));
        private EmployeeDto Employee { get; set; }

        //Constructors
        public CreateActivityForm()
        {
            InitializeComponent();
        }

        public CreateActivityForm(EmployeeDto employee, FacadeServices facadeServices)
        {
            InitializeComponent();
            Employee = employee;
            FacadeServices = facadeServices;
        }

        //Buttons
        private void btnSubmitActivity_Click(object sender, EventArgs e)
        {
            ActivityDto activity = new ActivityDto();
            activity.Description = txtDescription.Text;

            if(CalendarStartDate.SelectionStart == null || CalendarStartDate.SelectionEnd == null)
            {
                MessageBox.Show("Please choose a date");
            }
            else
            {
                activity.StartDate = CalendarStartDate.SelectionStart;
                activity.EndDate = CalendarStartDate.SelectionEnd;
                FacadeServices.InsertServices.CreateActivity(activity, Employee);

                MessageBox.Show("Activity created!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
            EmployeeApp empApp = new EmployeeApp(Employee, FacadeServices);
            if (empApp.ShowDialog() == DialogResult.OK)
                Visible = !Visible;
        }
    }
}
