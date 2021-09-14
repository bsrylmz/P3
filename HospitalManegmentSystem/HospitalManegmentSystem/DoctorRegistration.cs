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
    public partial class DoctorRegistration : Form
    {
        public DoctorRegistration()
        {
            InitializeComponent();
        }

        public void InsertionDB()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENGHASANDADER\SQLSERVER;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Doctor (DocID,FirstName,Surname,Fathersname,address,Phone_Number,email,date_of_joining,gender,bloodgroup,qualifications)" +
                "    values (@DocID,@FirstName,@Surname,@Fathersname,@address,@Phone_Number,@email,@date_of_joining,@gender,@bloodgroup,@qualifications)", conn);
            cmd.Parameters.AddWithValue("@DocID", textBox1.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Surname", textBox3.Text);
            cmd.Parameters.AddWithValue("@Fathersname", textBox4.Text);
            cmd.Parameters.AddWithValue("@address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", textBox6.Text);
            cmd.Parameters.AddWithValue("@email", textBox6.Text);
            cmd.Parameters.AddWithValue("@date_of_joining", textBox8.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@bloodgroup", comboBox2.Text);
            cmd.Parameters.AddWithValue("@qualifications", textBox9.Text);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";

            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Visible = false;
            m.Visible = true;
        }

        private void DoctorRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertionDB();
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
