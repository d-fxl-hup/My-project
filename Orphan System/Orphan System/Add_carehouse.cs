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

namespace Orphan_System
{
    public partial class Add_carehouse : Form
    {
        private string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog = OSD; Integrated Security = True";
        public Add_carehouse()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Abuser_Load(object sender, EventArgs e)
        {
            com_major.Items.Add("Rehabilitation");
            com_major.Items.Add("Adoption Offers");
            com_major.Items.Add("Therapeutic");
            com_major.Items.Add("Military");


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orphane orphane = new Orphane();
            orphane.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO care 
                                         ( care_name ,care_manger ,care_phone  ,state ,description,major )
                                           VALUES
                                             (@care_name, @care_manger, @care_phone, @state, @description,@major)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@care_name", txb_carename.Text);
                        command.Parameters.AddWithValue("@care_manger", txb_managername.Text);
                        command.Parameters.AddWithValue("@care_phone", txb_carephone.Text);
                        command.Parameters.AddWithValue("@state", txb_state.Text);
                        command.Parameters.AddWithValue("@description", txb_discription.Text);
                        command.Parameters.AddWithValue("@major", com_major.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Done!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }
        }
    }
}
