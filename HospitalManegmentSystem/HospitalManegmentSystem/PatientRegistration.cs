using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HospitalManegmentSystem
{
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
                       
        }

        public void InsertionDB()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENGHASANDADER\SQLSERVER;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Patient (PID,FirstName,Surname,Fathersname,address,Phone_Number,email,age,gender,bloodgroup,information)" +
                "    values (@PID,@FirstName,@Surname,@Fathersname,@address,@Phone_Number,@email,@age,@gender,@bloodgroup,@information)",conn);
            cmd.Parameters.AddWithValue("@PID", textBox1.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Surname", textBox9.Text);
            cmd.Parameters.AddWithValue("@Fathersname", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", textBox5.Text);
            cmd.Parameters.AddWithValue("@email", textBox6.Text);
            cmd.Parameters.AddWithValue("@age", textBox7.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@bloodgroup", comboBox2.Text);
            cmd.Parameters.AddWithValue("@information", textBox8.Text);
            cmd.ExecuteNonQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu m = new Menu();
            m.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1_TextChanged.Clear();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertionDB();
            button1.Enabled = false;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true; // to reactive SAVE button when changing any data
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true; // to reactive SAVE button when changing any data
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true; // to reactive SAVE button when changing any data
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;// to reactive SAVE button when changing any data
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;// to reactive SAVE button when changing any data
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;// to reactive SAVE button when changing any data
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;// to reactive SAVE button when changing any data
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;// to reactive SAVE button when changing any data
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;// to reactive SAVE button when changing any data
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
