using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orphan_System
{
    public partial class Orphane : Form
    {
        public Orphane()
        {
            InitializeComponent();
        }

        private void AddAbuser_Click(object sender, EventArgs e)
        {
            Add_carehouse nextForm = new Add_carehouse();

            nextForm.Show();

            this.Hide();
        }

        private void SearchAbuser_Click(object sender, EventArgs e)
        {
            
        }

        private void AddCrimnal_Click(object sender, EventArgs e)
        {
            Add_Crimnal_Kids nextForm= new Add_Crimnal_Kids();

            nextForm.Show();

            this.Hide();
        }

        private void AddLost_Click(object sender, EventArgs e)
        {
            Add_lost nextForm = new Add_lost();

            nextForm.Show();

            this.Hide();
        }

        private void AddOrphan_Click(object sender, EventArgs e)
        {
            Add_orphan nextForm = new Add_orphan();

            nextForm.Show();

            this.Hide();
        }

        private void Orphane_Load(object sender, EventArgs e)
        {
           label7.Text = "Welcome,"+ sign_in.user_v;

        }

        private void SearchOrphan_Click(object sender, EventArgs e)
        {

        }

        private void SearchLost_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add_orphan nextForm = new Add_orphan();

            nextForm.Show();

            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_lost nextForm = new Add_lost();

            nextForm.Show();

            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Add_Crimnal_Kids nextForm = new Add_Crimnal_Kids();

            nextForm.Show();

            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Add_carehouse nextForm = new Add_carehouse();

            nextForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supervisor supervisor = new supervisor();
            supervisor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sherif sherif = new sherif();   
            sherif.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cop cop = new cop();
            cop.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            supervisor supervisor = new supervisor();
            supervisor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sherif sherif = new sherif();
            sherif.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cop cop = new cop();
            cop.Show();
            this.Hide();

        }
    }
}
