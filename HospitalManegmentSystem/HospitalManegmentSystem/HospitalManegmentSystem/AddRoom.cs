using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManegmentSystem
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        public void InsertionDB()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENGHASANDADER\SQLSERVER;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Room (Room_Number,Room_Type,Room_Charges,Room_Status)" +
                "    values (@Room_Number,@Room_Type,@Room_Charges,@Room_Status)", conn);
            cmd.Parameters.AddWithValue("@Room_Number", textBox1.Text);
            cmd.Parameters.AddWithValue("@Room_Charges", textBox2.Text);
            cmd.Parameters.AddWithValue("@Room_Type", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Room_Status", "full");
            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertionDB();//DON'T FORGET TO CHECK THE ROOM AVALIBILITY
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Visible = false;
            m.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomStatus r = new RoomStatus();
            this.Visible = false;
            r.Visible = true;
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
