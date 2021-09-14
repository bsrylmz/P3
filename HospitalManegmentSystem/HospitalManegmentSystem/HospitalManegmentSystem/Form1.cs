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
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        public Form1()
        {
          
            InitializeComponent();
            
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = (1000) * (2);
            timer.Enabled = true;
            //timer.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            //MessageBox.Show("Tick");
            this.Hide();
            timer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
