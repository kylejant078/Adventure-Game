using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Adventure_Game
{
    public partial class AdventureGame : Form
    {
        //Global variables
        //Set up soundplayer
        //Set up random number generator for random outcome event used later
        int page = 1;
        SoundPlayer musicPlayer;
        Random randGen = new Random();

        public AdventureGame()
        {
            InitializeComponent();
            //Display initial labels, buttons, imageboxes and sounds when program first starts
            imageBox.Image = Properties.Resources.amazing_race_logo;
            outputLabel.Text = "The final leg of the Amazing Race has begun!";
            option1Label.Text = "Do you take a taxi";
            option2Label.Text = "Do you take the subway";
            option3Label.Text = "Do you go for it";
            musicPlayer = new SoundPlayer(Properties.Resources.amazing_race_sound);
            musicPlayer.Play();
            //Hide option 3 label and option 3 button as they are not needed until later
            option3Label.Visible = false;
            option3Button.Visible = false;
        }
        private void option1Button_Click(object sender, EventArgs e)
        //When option 1 button is clicked then navigate to the appropriate page number
        {
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 3; }
            else if (page == 3)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "Your acting performance was not good enough to earn your next clue. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 4)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "The other team betrays you and leaves you in their dust. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 5) { page = 6; }
            else if (page == 6)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "You were unable to remember the location of your next clue and are now lost. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
                option3Label.Visible = false;
                option3Button.Visible = false;
            }
            else if (page == 7)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "You turned to sharp and crashed the golf cart into a tree. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 8)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "You chickened out and took a 3 hour penalty. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 9)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "You didn't take your time and twisted your ankle on a stump. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 10)
            {
                //Display winning image and sound and set the text for page 99 to relate to the next options
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.amazing_race_sound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.amazing_race_end;
                outputLabel.Text = "Congratulations! You have won the Amazing Race! Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            //If option 1 is clicked on page 99 then nagivate back to page one which is set up in the Display Page public void
            else if (page == 99) { page = 1; }
            //Update the screen display to whatever the new page number is
            DisplayPage();
        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            //Set up random number variable so that every time option 2 button is clicked a new number will be chosen
            //This results in a rnadom sequence of successes and failures at the random event
            //Set the range so only numbers "1" and "2" are included so the chance of success or failure is 50%
            int randomNumber; randGen.Next(1, 3);
            //When option 2 button is clicked then navigate to the appropriate page number
            if (page == 1)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "You were late to the subway station and missed you flight. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 2)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "Your knowledge of Stratford history is lacking tremendously and you fail the challenge. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 3) { page = 4; }
            else if (page == 4) { page = 5; }
            else if (page == 5) 
            {                     
                //Every time option 2 button is clicked on page 5 a random number either 1 or 2 is chosen
                randomNumber = randGen.Next(1, 3);
                if (randomNumber == 1)
                {
                    //Every time number 1 is the result of the random event. . .
                    //Display losing image and sound and set the text for page 99 to relate to the previous event
                    page = 99;
                    musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.lose;
                    outputLabel.Text = "You mistakenly go to the wrong destination. You Lose. Do you want to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                }
                //If the number is 2 then procede to nagivate to page 7 which iis set up in the Display Page public void
                else page = 7;
            }
            else if (page == 6)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "The swans get angry and bite our fingers and rip up you clue. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
                option3Button.Visible = false;
                option3Label.Visible = false;
            }
            else if (page == 7) { page = 9; }
            else if (page == 8) { page = 10; }
            else if (page == 9)
            {
                //Display winning image and sound and set the text for page 99 to relate to the next options
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.amazing_race_sound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.amazing_race_end;
                outputLabel.Text = "Congratulations! You have won the Amazing Race! Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 10)
            {
                //Display losing image and sound and set the text for page 99 to relate to the previous event
                page = 99;
                musicPlayer = new SoundPlayer(Properties.Resources.losesound);
                musicPlayer.Play();
                imageBox.Image = Properties.Resources.lose;
                outputLabel.Text = "Your taxi gets caught in heavy traffic and your progress is slowed to a halt. You Lose. Do you want to play again?";
                option1Label.Text = "Yes";
                option2Label.Text = "No";
            }
            else if (page == 99)
            {
                //If option 2 button is clicked on page 99 then procede to shut down the program
                //Hide buttons and labels to prevent the user from re-entering the program
                outputLabel.Text = "Thanks for Playing!";
                option1Button.Visible = false;
                option2Button.Visible = false;
                option3Button.Visible = false;
                option1Label.Visible = false;
                option2Label.Visible = false;
                option3Label.Visible = false;
                imageBox.Image = Properties.Resources.race_end;
                //Wait for 2 seconds and then close the program
                Refresh();
                Thread.Sleep(2000);
                Application.Exit();
            }
            //Update the screen display to whatever the new page number is
            DisplayPage();
        }
        private void option3Button_Click(object sender, EventArgs e)
        {
            //This event is only used for page 6 when there are 3 options
            //If option 3 button is clicked then navigate to the corresponding page (page 8)
            if (page == 6)
            {
                page = 8;
            }
            //Update the screen display to whatever the new page number is
            DisplayPage();
        }
        public void DisplayPage()
            //Use this public void to create the desired layout for each page number
        {
            //Use a switch statement and the page number variable and display the images, sounds and texts associated with each page number
            switch (page)
            {
                case 1:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.amazing_race_sound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.amazing_race_logo;
                    //text
                    outputLabel.Text = "The final leg of the Amazing Race has begun!";
                    option1Label.Text = "Do you take a taxi";
                    option2Label.Text = "Do you take the subway";
                    break;
                case 2:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.planesound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.stratford;
                    //text
                    outputLabel.Text = "You were on time for you flight to Stratford and you open your first clue";
                    option1Label.Text = "Do you try the act challenge";
                    option2Label.Text = "Do you try the fact challenge";
                    break;
                case 3:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.entrancesound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.festival_theatre;
                    //text
                    outputLabel.Text = "You arrive at the Festival theatre for your next challenge";
                    option1Label.Text = "Do you recreate Romeo and Juliet?";
                    option2Label.Text = "Do you recreate Pirates of the Caribbean?";
                    break;
                case 4:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.suspensesound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.play;
                    //text
                    outputLabel.Text = "Your performance was spot on and you got your next clue, but the race is close, do you make an alliance with the other team?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.forgotcluesound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.path;
                    //text
                    outputLabel.Text = "You forgot your clue at the last challenge";
                    option1Label.Text = "Do you go back and get it";
                    option2Label.Text = "Do you go on without it";
                    break;
                case 6:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.swansound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.swans;
                    //text
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "A family of swans is guarding your clue, what do you do?";
                    option1Label.Text = "Forget about it";
                    option2Label.Text = "Bribe the swans with bread";
                    option3Label.Text = "Go for it";
                    break;
                case 7:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.carsound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.golf;
                    //text
                    outputLabel.Text = "Luckily you make it to your next destination. The Stratford Country Club";
                    option1Label.Text = "Do you play a hole";
                    option2Label.Text = "Do you chose the driving range";
                    break;
                case 8:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.runsound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.water_tower;
                    //text
                    outputLabel.Text = "You somehow managed to get your clue but your next clue is at the top of a water tower. Will you climb?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";
                    //Hide option 3 label and option 3 button since they are no longer required
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 9:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.golfsound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.shortcut;
                    //text
                    outputLabel.Text = "You completed the driving range challenge and are on your way to the finish!";
                    option1Label.Text = "Do you take the shortcut";
                    option2Label.Text = "Do you take the slightly longer route";
                    break;
                case 10:
                    //sounds and images
                    musicPlayer = new SoundPlayer(Properties.Resources.birdsound);
                    musicPlayer.Play();
                    imageBox.Image = Properties.Resources.cityhall;
                    //text
                    outputLabel.Text = "You are able to see the finish mat from the top, you're so close!";
                    option1Label.Text = "Do you sprint to the mat";
                    option2Label.Text = "Do you take a taxi to the mat";
                    break;
            }
        }   
    }
}
