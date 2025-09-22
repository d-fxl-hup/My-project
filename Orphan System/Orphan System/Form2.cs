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
//using Microsoft.Reporting.WinForms;

namespace Orphan_System
{
    public partial class View_info : Form

    {
        private string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog = OSD; Integrated Security = True";
        private int selectedorphan_id = -1;
        public View_info()
        {
            InitializeComponent();

        }

        private void View_info_Load(object sender, EventArgs e)
        {
            LoadOrphans();
        }
        private void LoadOrphans()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM orphan";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null);
    {
                textBox1.Text = dataGridView1.CurrentRow.Cells["orphan_name"].Value?.ToString();
                txt_date.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["death_date"].Value).ToString("dd/MM/yyyy");
                txt_gender.Text = dataGridView1.CurrentRow.Cells["gender"].Value?.ToString();
                txt_type.Text = dataGridView1.CurrentRow.Cells["type"].Value?.ToString();
                txt_health.Text = dataGridView1.CurrentRow.Cells["genetic_diseases"].Value?.ToString();
                txt_blood.Text = dataGridView1.CurrentRow.Cells["blood_type"].Value?.ToString();
                txt_age.Text =  dataGridView1.CurrentRow.Cells["age"].Value?.ToString();


            } }

        private void but_S_Click(object sender, EventArgs e)
        {

            
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "SELECT * FROM orphan";

                        // إذا كان هناك نص في مربع البحث، أضف شرط WHERE
                        if (!string.IsNullOrWhiteSpace(txt_Name.Text))
                        {
                            query += " WHERE orphan_name LIKE @search";
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                        if (!string.IsNullOrWhiteSpace(txt_Name.Text))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txt_Name.Text + "%");
                        }

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ في البحث: " + ex.Message);
                }
            

        }

        private void but_R_Click(object sender, EventArgs e)
        {
            LoadOrphans();
        }

        private void but_print_Click(object sender, EventArgs e)
        {
           
       
        }
    }
}
