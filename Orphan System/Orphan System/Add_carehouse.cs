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
    public partial class Add_carehouse : Form
    {
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
    }
}
