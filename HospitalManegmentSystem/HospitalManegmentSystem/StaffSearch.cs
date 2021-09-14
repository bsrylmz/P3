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
    public partial class StaffSearch : Form
    {
        public StaffSearch()
        {
            InitializeComponent();
        }

        private void StaffSearch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffInformation s = new StaffInformation();
            this.Visible = false;
            s.Visible = true;
        }
    }
}
