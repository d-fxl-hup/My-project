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
    public partial class care_info : Form
    {
        private string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog = OSD; Integrated Security = True";

        public care_info()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void care_info_Load(object sender, EventArgs e)
        {
            Loadcare_info();
        }
            private void Loadcare_info()
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM care";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
                }
            }
        }
    }

