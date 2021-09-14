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
    public partial class PathToStaff : Form
    {
        public PathToStaff()
        {
            InitializeComponent();
        }

        private void PathToStaff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffSearch s = new StaffSearch();
            this.Visible = false;
            s.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffSearch s = new StaffSearch();
            this.Visible = false;
            s.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffSearch s = new StaffSearch();
            this.Visible = false;
            s.Visible = true;
        }
    }
}
