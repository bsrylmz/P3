using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManegmentSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PatientRegistration p = new PatientRegistration();
            p.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientInformation p = new PatientInformation();
            this.Visible = false;
            p.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoctorRegistration d = new DoctorRegistration();
            this.Visible = false;
            d.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaffInformation s = new StaffInformation();
            this.Visible = false;
            s.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddRoom a = new AddRoom();
            this.Visible = false;
            a.Visible = true;
        }
    }
}
