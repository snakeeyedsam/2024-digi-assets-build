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
    public partial class II : Form
    {
        public II()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Incorrect f2 = new Incorrect();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            finish2 f2 = new finish2();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Incorrect f2 = new Incorrect();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
