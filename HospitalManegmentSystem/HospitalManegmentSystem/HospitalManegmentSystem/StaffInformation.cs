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
    public partial class StaffInformation : Form
    {
        int iid;
        public StaffInformation()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            String id, name, sname, fname, address, num, email, blood, inf, date_of_joining, gender;
            SqlConnection conn = new SqlConnection(@"Data Source=ENGHASANDADER\SQLSERVER;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Doctor where DocID='" + iid + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0).ToString();
                name = reader.GetString(1);
                sname = reader.GetString(2);
                fname = reader.GetString(3);
                address = reader.GetString(4);
                num = Convert.ToString(reader.GetInt64(5));
                email = reader.GetString(6);
                date_of_joining = reader.GetString(7); ;
                gender = reader.GetString(8);
                blood = reader.GetString(9);
                inf = reader.GetString(10);

                textBox1.Text = id;
                textBox2.Text = name;
                textBox3.Text = sname;
                textBox4.Text = fname;
                textBox5.Text = address;
                textBox6.Text = num;
                textBox7.Text = email;
                textBox8.Text = date_of_joining;
                textBox9.Text = gender;
                textBox10.Text = blood;
                textBox11.Text = inf;
            }
            reader.Close();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffSearch s = new StaffSearch();
            this.Visible = false;
            s.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Visible = false;
            m.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iid = Convert.ToInt32(textBox1.Text);
            ConnectDB();
        }
    }
}
