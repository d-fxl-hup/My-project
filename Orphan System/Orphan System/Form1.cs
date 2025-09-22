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
    public partial class Login : Form
    {
        private string SQLSEVERconnection = "Data Source=desktop-ah235ms;Initial Catalog=OS;Integrated Security=True";


        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            try
            {


                using (SqlConnection connection = new SqlConnection(SQLSEVERconnection))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM employ WHERE emp_id = @emp_id AND emp_pass = @emp_pass";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@emp_id", username);
                    command.Parameters.AddWithValue("@emp_pass", password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");

                        this.Hide();

                        Orphane orphane = new Orphane();
                        orphane.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/



            sign_in sign_In = new sign_in();
            sign_In.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label3.Text = "Welcome, " + sign_in.user_v;
        }
    }
}
