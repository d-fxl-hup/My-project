using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Orphan_System
{
    public partial class cop : Form
    {

        string connectionString = @"Data Source=desktop-ah235ms;Initial Catalog= OS;Integrated Security=True";
        public cop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orphane orphane = new Orphane();
            orphane.Show();
            this.Close();


        }

        private void add_abuser_save_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "INSERT INTO cop (cop_id, cop_name, cop_master, cop_phone, state,area) " + "VALUES (@cop_id, @cop_name, @cop_master, @cop_phone, @state, @area)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@cop_id", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@cop_name", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@cop_master", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@cop_phone", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@state", textBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@area", textBox6.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Succsefully!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:"+ex.Message);
                }
            }
        }
    }
}
