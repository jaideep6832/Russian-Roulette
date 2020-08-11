using System;
using System.Media;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Russian_Roulette
{
    public partial class RussianRouletteUI : Form
    {
        

        // use the stored values in the GameRepository class and the two instances of this class
        GameRepository repositoryClass = new GameRepository();


        public RussianRouletteUI()
        {
            InitializeComponent();   
        }

        // first time loading this Form 
        // Preparing the form for the player
        private void RussianRoulette_Load(object sender, EventArgs e)
        {
            // seting values 
            btnFire.Enabled = false;
            btnSpinChambers.Enabled = false;
            rbtnDuck.Enabled = false;
            rbtnPointAtHead.Enabled = false;
            btnReload.Enabled = false;

            //display set values 
            tbxDucksLeftDisplay.Text = Difficulty.repositoryClass.DucksLeft.ToString();
            lblDisplayPlayerName.Text = PlayerName.repositoryClass.PlayerName;
        }

        // Close the entire Programe 
        private void RussianRoulette_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // player Choose to Duck on Checking radio button 
        private void rbtnDuck_CheckedChanged(object sender, EventArgs e)
        {
            btnFire.Enabled = true;
        }

        // player Choose to Point Gun At Their Head on Checking radio button
        private void rbtnPointAtHead_CheckedChanged(object sender, EventArgs e)
        {
            if (repositoryClass.ShotsLeft >= 0)
            {
                btnFire.Enabled = true;
            }else {
                btnFire.Enabled = false;
            }
        }

        // fire the gun on clicking the button
        private void btnFire_Click(object sender, EventArgs e)
        {
            //string[] spinChambers = repositoryClass.chambers;

            // check if player ducked 
            if (rbtnDuck.Checked == true) {

                // decrease amount of ducks and update value for player to see
                Difficulty.repositoryClass.DucksLeft--;
                tbxDucksLeftDisplay.Text = Difficulty.repositoryClass.DucksLeft.ToString();

                //Check: if player is out of ducks player dies
                if (Difficulty.repositoryClass.DucksLeft == 0)
                {
                    // play the sound effect
                    SoundPlayer playMedia = new SoundPlayer(GamesResources.shoot);
                    playMedia.Play();

                    // display results 
                    lblDispalyResults.Text = repositoryClass.chambers[repositoryClass.ShotsLeft] + "....." + "you have died " + " Game difficulty:" + Difficulty.repositoryClass.GetDifficulty();
                   
                    //disabling buttons
                    btnFire.Enabled = false;
                    rbtnDuck.Enabled = false;
                    rbtnPointAtHead.Enabled = false;
                    btnLoadBullet.Enabled = false;
                    btnSpinChambers.Enabled = false;

                    //Enabling a button
                    btnReload.Enabled = true;

                    // update the losses for the Player to see
                    repositoryClass.Losses++;
                    tbxLossesDisplay.Text = repositoryClass.Losses.ToString();
                }else{
                    rbtnDuck.Enabled = true;

                    // play the sound effect
                    SoundPlayer playMedia = new SoundPlayer(GamesResources.gunEmpty);
                    playMedia.Play();

                    // display results 
                    lblDispalyResults.Text = repositoryClass.chambers[repositoryClass.ShotsLeft] + "....." + "you live " + " Game difficulty:" + repositoryClass.ShotsLeft;
                }
            }

            if (repositoryClass.ShotsLeft != 0) // (check if gun is not out of ammo) Shotsleft must not be equal to 0
            {
                if (rbtnPointAtHead.Checked == true) // if gun is pointed at your head then valided if person lives or dies
                {
                    //Check: if gun fires bullet or player runs out of ducks the player dies
                    if (repositoryClass.chambers[repositoryClass.ShotsLeft] == "BANG!" || Difficulty.repositoryClass.DucksLeft == 0)
                    {
                        // play the sound effect
                        SoundPlayer playMedia = new SoundPlayer(GamesResources.shoot);
                        playMedia.Play();

                        // display results 
                        lblDispalyResults.Text = repositoryClass.chambers[repositoryClass.ShotsLeft] + "....." + "you have died " + " Game difficulty:" + Difficulty.repositoryClass.GetDifficulty();

                        //disabling buttons
                        btnFire.Enabled = false;
                        rbtnDuck.Enabled = false;
                        rbtnPointAtHead.Enabled = false;
                        btnLoadBullet.Enabled = false;
                        btnSpinChambers.Enabled = false;

                        //Enabling a button
                        btnReload.Enabled = true;

                        // update the losses for the Player to see
                        repositoryClass.Losses++;
                        tbxLossesDisplay.Text = repositoryClass.Losses.ToString();
                    } else { // Player is not shot or not out of Ducks 

                        // play the sound effect
                        SoundPlayer playMedia = new SoundPlayer(GamesResources.gunEmpty);
                        playMedia.Play();

                        // display results 
                        lblDispalyResults.Text = repositoryClass.chambers[repositoryClass.ShotsLeft] + "....." + "you live " + " Game difficulty:" + repositoryClass.ShotsLeft;
                    }
                } 
            }  else { // gun is out of ammo 
                    //Enabling a button and disabling buttons
                    rbtnDuck.Enabled = false;
                    rbtnPointAtHead.Enabled = false;
                    btnReload.Enabled = true;
                    btnFire.Enabled = false;
                    
                    // play the sound effect
                    SoundPlayer playMedia = new SoundPlayer(GamesResources.gunEmpty);
                    playMedia.Play();

                    // display results 
                    lblDispalyResults.Text = repositoryClass.chambers[repositoryClass.ShotsLeft] + "....." + "you have Won the Game " + " Game difficulty:" + Difficulty.repositoryClass.GetDifficulty();

                    // update the Wins for the Player to see
                    repositoryClass.Wins++;
                    tbxWinsDisplay.Text = repositoryClass.Wins.ToString();
            }

            // decrease the shots fired and display new amount to player
            repositoryClass.ShotsLeft--; 
            tbxShotsLeftDisplay.Text = (Convert.ToInt32(tbxShotsLeftDisplay.Text) - 1).ToString();
        }

        // on button click load bullet in gun
        private void btnLoadBullet_Click(object sender, EventArgs e)
        {
            // play the sound effect
            SoundPlayer playMedia = new SoundPlayer(GamesResources.load);
            playMedia.Play();

            //set or reset values (depending if player is playing again)
            repositoryClass.ShotsLeft = 5;
            repositoryClass.LoadBullet();
            tbxShotsLeftDisplay.Text = "6";
            btnSpinChambers.Enabled = true;
            btnLoadBullet.Enabled = false;
        }

        // on button click spin the chambers 
        private void btnSpinChambers_Click(object sender, EventArgs e)
        {
            // play the sound effect
            SoundPlayer playMedia = new SoundPlayer(GamesResources.spin);
            playMedia.Play();

            btnSpinChambers.Enabled = false;
            rbtnDuck.Enabled = true;
            rbtnPointAtHead.Enabled = true;
            repositoryClass.SpinChambers();
        }

        //play the game again on button click
        private void btnReload_Click(object sender, EventArgs e)
        {
            // play the sound effect
            SoundPlayer playMedia = new SoundPlayer(GamesResources.reload);
            playMedia.Play();

            rbtnDuck.Checked = false;
            rbtnDuck.Enabled = false;
            rbtnPointAtHead.Checked = false;
            rbtnPointAtHead.Enabled = false;

            btnFire.Enabled = false;
            btnSpinChambers.Enabled = false;
            btnReload.Enabled = false;
            
            btnLoadBullet.Enabled = true;
           
            // reseting Duck values 
            if (Difficulty.repositoryClass.GetDifficulty() == "Easy"){
                Difficulty.repositoryClass.DucksLeft = 3;
                tbxDucksLeftDisplay.Text = "3";
            }else if (Difficulty.repositoryClass.GetDifficulty() == "Normal"){
                Difficulty.repositoryClass.DucksLeft = 2;
                tbxDucksLeftDisplay.Text = "2";
            } else if (Difficulty.repositoryClass.GetDifficulty() == "Hard"){
                Difficulty.repositoryClass.DucksLeft = 1;
                tbxDucksLeftDisplay.Text = "1";
            }
            
            lblDispalyResults.Text = "Results";
        }
    }
}
