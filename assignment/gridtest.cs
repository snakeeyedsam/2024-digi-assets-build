using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace assignment
{
    public partial class gridtest : Form
    {
        //Size holds how big our table is, x y holds our player position 

        int size = 15;

        int x = 0;

        int y = 2;



        //Generating a 2D array of picture boxes

        PictureBox[,] pictures = new PictureBox[15, 15];



        //Picture resources to simplify use later

        string picCheck = Directory.GetCurrentDirectory() + "/images/192.jpg";

        string picHand = Directory.GetCurrentDirectory() + "/images/astron.png";
        public gridtest()
        {
            InitializeComponent();



            //Loop for rows

            for (int i = 0; i < size; i++)

            {

                //Loop for columns

                for (int j = 0; j < size; j++)

                {

                    //Set up our picturebox to have a check mark

                    pictures[i, j] = new PictureBox();

                    pictures[i, j].Image = Image.FromFile(picCheck);

                    pictures[i, j].SizeMode = PictureBoxSizeMode.StretchImage;



                    //Add the picturebox to our table

                    table.Controls.Add(pictures[i, j]);

                }

            }

            //Starting position of our hand

            pictures[y, x].Image = Image.FromFile(picHand);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void gridtest_KeyDown(object sender, KeyEventArgs e)
        {
            //Check if it's a key right

            if (e.KeyCode == Keys.Right)

            {

                //Check if we can move there, we need to be at size - 1 to move (e.g 2 so we can go to the max size of 3)

                if (x < size - 1)

                {

                    //Set our old position to be a check

                    pictures[y, x].Image = Image.FromFile(picCheck);



                    //Increment our position then set it to a hand

                    x++;

                    pictures[y, x].Image = Image.FromFile(picHand);

                }

            }



            //Check all the other things similarly

            if (e.KeyCode == Keys.Left)

            {

                if (x > 0)

                {

                    pictures[y, x].Image = Image.FromFile(picCheck);

                    x--;

                    pictures[y, x].Image = Image.FromFile(picHand);

                }

            }



            if (e.KeyCode == Keys.Up)

            {

                if (y > 0)

                {

                    pictures[y, x].Image = Image.FromFile(picCheck);

                    y--;

                    pictures[y, x].Image = Image.FromFile(picHand);

                }

            }



            if (e.KeyCode == Keys.Down)

            {

                if (y < size - 1)

                {

                    pictures[y, x].Image = Image.FromFile(picCheck);

                    y++;

                    pictures[y, x].Image = Image.FromFile(picHand);

                }

            }






        }

        private void table_Click(object sender, EventArgs e)
        {
            finishgrid f2 = new finishgrid();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}
