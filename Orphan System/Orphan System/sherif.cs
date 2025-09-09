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
    public partial class sherif : Form
    {
        string connectionString = @"Data Source=desktop-ah235ms;Initial Catalog= OS;Integrated Security=True";
        // SqlConnection con = new SqlConnection("Data Source=desktop-ah235ms;Initial Catalog=OS;Integrated Security=True");


        public sherif()
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

                    string query = "INSERT INTO sherif ( card_num, state,sherif_id,sherif_name,street) " + "VALUES ( @card_num, @state, @sherif_id, @sherif_name, @street)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    //  cmd.Parameters.AddWithValue("@sup_id", textBox9.Text.Trim());sup_id, sup_name,cop_id, cop_name,
                    //cmd.Parameters.AddWithValue("@sup_name", textBox7.Text.Trim());@sup_id, @sup_name, @cop_id, @cop_name,
                    cmd.Parameters.AddWithValue("@card_num", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@state", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@sherif_id", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@sherif_name", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@street", textBox5.Text.Trim());
                    //  cmd.Parameters.AddWithValue("@cop_id", textBox6.Text.Trim());
                    //cmd.Parameters.AddWithValue("@cop_name", textBox8.Text.Trim());



                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Succsefully!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void sherif_Load(object sender, EventArgs e)
        {
           // LoadCopData();
            //LoadSupervisorData();
        }

      /*  private void LoadSupervisorData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT sup_id,sup_name FROM supervaizor", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //sup id combobox
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "sup_id";
                comboBox3.ValueMember = "sup_id";
                //sup name combobox
                comboBox4.DataSource = dt.Copy();
                comboBox4.DisplayMember = "sup_name";
                comboBox4.ValueMember = "sup_id";
                //cop id combobox



            }
        }
        private void LoadCopData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT cop_id,cop_name FROM cop", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //cop id combobox
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "cop_id";
                comboBox1.ValueMember = "cop_id";
                //cop name combobox
                comboBox2.DataSource = dt.Copy();
                comboBox2.DisplayMember = "cop_name";
                comboBox2.ValueMember = "cop_id";


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          // if (comboBox1.SelectedValue != null)
                comboBox2.SelectedValue = comboBox1.SelectedValue;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (comboBox2.SelectedValue != null)

                comboBox1.SelectedValue = comboBox2.SelectedValue;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (comboBox3.SelectedValue != null)

                comboBox4.SelectedValue = comboBox3.SelectedValue;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   if (comboBox4.SelectedValue != null)

                comboBox3.SelectedValue = comboBox4.SelectedValue;
        }*/
    } 
}
