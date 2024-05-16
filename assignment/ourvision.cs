using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class ourvision : Form
    {
        public ourvision()
        {
            InitializeComponent();
        }

        private void visionhome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void visionabout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void visionsubmit_Click(object sender, EventArgs e)
        {
            submitcourse f2 = new submitcourse();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
