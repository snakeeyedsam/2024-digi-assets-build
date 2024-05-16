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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void aboutvision_Click(object sender, EventArgs e)
        {
            ourvision f2 = new ourvision();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void abouthome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void aboutsubmit_Click(object sender, EventArgs e)
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
    }
}
