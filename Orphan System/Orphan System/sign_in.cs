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
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=desktop-ah235ms;Initial Catalog=OS;Integrated Security=True");
        public static string user_v;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT  emp_name,emp_pass FROM employ WHERE  emp_name='Ahmed' AND  emp_pass= @pass", con);
            cmd.Parameters.AddWithValue("pass", textBox1.Text);
            SqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            if (myreader.Read())
            {
                int resultcomp = String.Compare(textBox1.Text, myreader.GetValue(1).ToString());
                if (resultcomp == 0)
                {
                    user_v = myreader["emp_name"].ToString();
                   
                    Orphane orphane = new Orphane();
                    orphane.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Error username or password");
                }

            }
            else
            {
                con.Close();
                MessageBox.Show("Error username or password");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            fill_combo();
        }
        private void fill_combo()
        {
            SqlCommand cmd2 = new SqlCommand("SELECT emp_id,emp_name FROM employ WHERE emp_name <>'Ahmed'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "emp_name";
            comboBox1.ValueMember = "emp_id";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select User";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please Select User");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM employ WHERE emp_id=@id AND emp_pass=@pass", con);
                cmd.Parameters.AddWithValue("id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("pass", textBox2.Text.Trim());
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                if (myreader.Read())
                {
                    int resultcomp = String.Compare(textBox2.Text, myreader.GetValue(2).ToString());
                    if (resultcomp == -1)
                    {
                        user_v = myreader["emp_name"].ToString();

                     /*   string add_v, update_v, delete_v;
                         add_v = Convert.ToString(myreader["add_data"].ToString());
                         update_v = Convert.ToString(myreader["update_data"].ToString());
                         delete_v = Convert.ToString(myreader["delete_data"].ToString());
                       */ 

                        Login login = new Login();
                        login.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Error jj username or password");
                    }

                }
                else
                {
                    con.Close();
                    MessageBox.Show("Error username or password");
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
