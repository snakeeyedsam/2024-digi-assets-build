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
    public partial class booleans : Form
    {
        public booleans()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] allLines = txtMultiLine.Text.Split('\n');

            int count = 1;

            lblOutput.Text = "";

            foreach (string text in allLines)

            {

                lblOutput.Text = String.Format("{0}{1} {2}\n", lblOutput.Text, count, text);

                count++;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            II f2 = new II();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
