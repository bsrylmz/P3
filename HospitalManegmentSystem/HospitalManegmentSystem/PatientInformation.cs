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
using System.Data.SqlClient;

namespace HospitalManegmentSystem
{
    public partial class PatientInformation : Form
    {
        int iid;
        public PatientInformation()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            String id,name,sname,fname, address, num, email, blood, inf, age, gender;
            SqlConnection conn = new SqlConnection(@"Data Source=ENGHASANDADER\SQLSERVER;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Patient where PID='"+iid+"'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
                name = reader.GetString(3);
                sname = reader.GetString(4);
                fname = reader.GetString(5);
                address = reader.GetString(6);
                num = Convert.ToString(reader.GetInt64(7));
                email = reader.GetString(8);
                age = Convert.ToString(reader.GetInt32(9));
                gender = reader.GetString(10);
                blood = reader.GetString(11);
                inf = reader.GetString(12);

                textBox1.Text = id;
                textBox2.Text = name;
                textBox3.Text = sname;
                textBox4.Text = fname;
                textBox5.Text = address;
                textBox6.Text = num;
                textBox7.Text = email;
                textBox8.Text = age;
                textBox9.Text = gender;
                textBox10.Text = blood;
                textBox11.Text = inf;
            }
            reader.Close();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Path p = new Path();
            p.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Visible = true;
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientInformation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            iid = Convert.ToInt32(textBox1.Text);
            ConnectDB();
        }
    }
}
