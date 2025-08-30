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
            Add_Abuser nextForm = new Add_Abuser();

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
    }
}
