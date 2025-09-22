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
    public partial class supervisor : Form
    {
        string connectionString = @"Data Source=desktop-ah235ms;Initial Catalog= OS;Integrated Security=True";

        public supervisor()
        {
            InitializeComponent();
        }

        private void supervisor_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

                    string query = "INSERT INTO supervaizor (sup_id, sup_name, card_num, sup_phone, state,area) " + "VALUES (@sup_id, @sup_name, @card_num, @sup_phone, @state, @area)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@sup_id", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@sup_name", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@card_num", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@sup_phone", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@state", textBox7.Text.Trim());
                    cmd.Parameters.AddWithValue("@area", textBox5.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Succsefully!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
    }
}
