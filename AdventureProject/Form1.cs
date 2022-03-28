using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AdventureProject
{ 
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
           
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 99)
            {
                page = 1;
            }

            DisplayPage();

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 1;
            }

            DisplayPage();

        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "Welcome to the Stratford VIA/GO Train Station. Ready for an adventure? Which provider?";
                    option1Button.Text = "VIA Rail";
                    option2Button.Text = "GO Transit";
                    imageBox.Image = Properties.Resources.StratfordVIAStation;
                    break;
                case 2:
                    outputLabel.Text = "You just boarded VIA Rail. Which driection?";
                    option1Button.Text = "Westbound towards Sarnia";
                    option2Button.Text = "Eastbound towards Toronto";

                    imageBox.Image = Properties.Resources.StratfordVIATrain;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Horn);
                    player2.Play();
                    break;
                case 3:
                    outputLabel.Text = "Which Class?";
                    option1Button.Text = "Business";
                    option2Button.Text = "Economy";
                    break;
                case 4:
                    outputLabel.Text = "Enjoy the trip!";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "Enjoy the trip!";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "You made it to your destination. Return trip?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "You made it!";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You just boarded GO Transit. Which direction?";
                    option1Button.Text = "Westbound towards London";
                    option2Button.Text = "Eastbound towards Toronto";
                    imageBox.Image = Properties.Resources.StratfordGOTrain;
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.Horn);
                    player3.Play();
                    break;
                
                
                case 99:
                    outputLabel.Text = "Thank you for playing. Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                default:
                    break;
            }
        }
    }
}