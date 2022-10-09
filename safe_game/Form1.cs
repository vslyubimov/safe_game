using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safe_game
{
    public partial class Form1 : Form
    {
        Random random = new Random();


        string[] boolTypes =
        {
            "|", "--"
        };

        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();

            // use to check win status
            //MakeWin();
            
            CheckForWinner();
        }


        private void AssignIconsToSquares()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(boolTypes.Length);
                    iconLabel.Text = boolTypes[randomNumber];
                }
            }
        }



        private static string ChangeRotation(Label clickedLabel)
        {
            if (clickedLabel.Text == "|")
            {
                return clickedLabel.Text = "--";
            }
            else if (clickedLabel.Text == "--")
            {
                return clickedLabel.Text = "|";
            }
            return clickedLabel.Text;
        }


        private void MakeWin()
        {

            label1.Text = "|";
            label2.Text = "|";
            label3.Text = "|";
            label4.Text = "|";
            label5.Text = "|";
            label6.Text = "|";
            label7.Text = "|";
            label8.Text = "|";
            label9.Text = "|";
            label10.Text = "|";
            label11.Text = "|";
            label12.Text = "|";
            label13.Text = "|";
            label14.Text = "|";
            label15.Text = "|";
            label16.Text = "|";
            return;
        }




        private void CheckForWinner()
        {

            string winnerWithUp = "|";
            int upCounter = 0;
            string winnerWithDown = "--";
            int downCounter = 0;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel.Text == winnerWithUp)
                {
                    upCounter++;
                }

                if (iconLabel.Text == winnerWithDown)
                {
                    downCounter++;
                }


            }

            if (upCounter == 16 | downCounter == 16)
            {
                MessageBox.Show("You Won!", "Congratulations");
                //Close();
            }

            return;

        }


     
        /// <summary>
        /// Clicks on icons
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label2);
                ChangeRotation(label3);
                ChangeRotation(label4);
                ChangeRotation(label5);
                ChangeRotation(label9);
                ChangeRotation(label13);
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label1);
                ChangeRotation(label3);
                ChangeRotation(label4);
                ChangeRotation(label6);
                ChangeRotation(label10);
                ChangeRotation(label14);
            }

        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label1);
                ChangeRotation(label2);
                ChangeRotation(label4);
                ChangeRotation(label7);
                ChangeRotation(label11);
                ChangeRotation(label15);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label1);
                ChangeRotation(label2);
                ChangeRotation(label3);
                ChangeRotation(label8);
                ChangeRotation(label12);
                ChangeRotation(label16);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label1);
                ChangeRotation(label9);
                ChangeRotation(label13);
                ChangeRotation(label6);
                ChangeRotation(label7);
                ChangeRotation(label8);
            }
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label2);
                ChangeRotation(label10);
                ChangeRotation(label14);
                ChangeRotation(label5);
                ChangeRotation(label7);
                ChangeRotation(label8);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label3);
                ChangeRotation(label11);
                ChangeRotation(label15);
                ChangeRotation(label5);
                ChangeRotation(label6);
                ChangeRotation(label8);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label4);
                ChangeRotation(label12);
                ChangeRotation(label16);
                ChangeRotation(label5);
                ChangeRotation(label6);
                ChangeRotation(label7);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label1);
                ChangeRotation(label5);
                ChangeRotation(label13);
                ChangeRotation(label10);
                ChangeRotation(label11);
                ChangeRotation(label12);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label2);
                ChangeRotation(label6);
                ChangeRotation(label14);
                ChangeRotation(label9);
                ChangeRotation(label11);
                ChangeRotation(label12);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label3);
                ChangeRotation(label7);
                ChangeRotation(label15);
                ChangeRotation(label9);
                ChangeRotation(label10);
                ChangeRotation(label12);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label4);
                ChangeRotation(label8);
                ChangeRotation(label16);
                ChangeRotation(label9);
                ChangeRotation(label10);
                ChangeRotation(label11);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label1);
                ChangeRotation(label5);
                ChangeRotation(label9);
                ChangeRotation(label14);
                ChangeRotation(label15);
                ChangeRotation(label16);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label2);
                ChangeRotation(label6);
                ChangeRotation(label10);
                ChangeRotation(label13);
                ChangeRotation(label15);
                ChangeRotation(label16);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label3);
                ChangeRotation(label7);
                ChangeRotation(label11);
                ChangeRotation(label13);
                ChangeRotation(label14);
                ChangeRotation(label16);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                ChangeRotation(clickedLabel);
                ChangeRotation(label4);
                ChangeRotation(label5);
                ChangeRotation(label12);
                ChangeRotation(label13);
                ChangeRotation(label14);
                ChangeRotation(label15);
            }
        }








    }
}



