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
    public partial class RoomStatus : Form
    {
        int iid;
        String id;
        public RoomStatus()
        {
            InitializeComponent();
            
        }

        public void ConnectDB()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ENGHASANDADER\SQLSERVER;Initial Catalog=HospitalManagementSystemDatabase;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Room_Status from Room where Room_Number='" + iid + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetString(0).ToString();
            }
            reader.Close();
            conn.Close();

        }

        private void RoomStatus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            if (id == "full")
            {
                MessageBox.Show("Room is not available.", "Room Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(id == "Empty")
            {
                MessageBox.Show("Room is available!", "Room Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            iid = Convert.ToInt32(textBox1.Text);
        }
    }
}
