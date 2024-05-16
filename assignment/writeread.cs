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
    public partial class writeread : Form
    {
        public writeread()
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

        private void button2_Click(object sender, EventArgs e)
        {
            III f2 = new III();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
