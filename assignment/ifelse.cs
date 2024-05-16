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
    public partial class ifelse : Form
    {
        public ifelse()
        {
            InitializeComponent();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            I f2 = new I();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void txtMultiLine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
