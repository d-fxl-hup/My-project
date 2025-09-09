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
    public partial class Add_orphan : Form
    {
        private string connectionString = @"Data Source=desktop-ah235ms;Initial Catalog = OS; Integrated Security = True";

        public Add_orphan()
        {
            InitializeComponent();
        }

        private void Add_orphan_Load(object sender, EventArgs e)
        {

            com_type.Items.Add("Force");
            com_type.Items.Add("Events");
            com_type.Items.Add("Lost");

            com_gender.Items.Add("Male");
            com_gender.Items.Add("Female");
            com_blood.Items.Add("A+");
            com_blood.Items.Add("A-");
            com_blood.Items.Add("O+");
            com_blood.Items.Add("O-");
            com_blood.Items.Add("AB");

        }


        private void add_abuser_save_Click_1(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO orphan 
                                         (orphan_name ,death_date ,age  ,genetic_diseases ,blood_type  )
                                           VALUES
                                             (@orphan_name, @death_date, @age, @genetic_diseases, @blood_type )";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@orphan_name", txt_name.Text);
                        command.Parameters.AddWithValue("@death_date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@age", Convert.ToInt32(numericUpDown1.Text));
                        //  command.Parameters.AddWithValue("@Gender", com_gender.SelectedItem.ToString());الا ان اضيف  العمؤد 
                        command.Parameters.AddWithValue("@genetic_diseases", txt_dis.Text);
                        command.Parameters.AddWithValue("@blood_type", com_blood.SelectedItem.ToString());

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orphane orphane = new Orphane();
            orphane.Show();
            this.Hide();
        }
    }
}
