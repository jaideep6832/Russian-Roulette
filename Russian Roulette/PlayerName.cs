using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Russian_Roulette
{
    public partial class PlayerName : Form
    {
        public PlayerName()
        {
            InitializeComponent();
        }

        // with the new public static instance of the "GameRepository" class we can make the values stored globle accessable with this 
        // class instance
        public static GameRepository repositoryClass = new GameRepository();

        // Store most values inside of class instance (repositoryClass) 

        // check the lenght of the player's name as they type in the textbox
        private void tbxPlayerName_TextChanged(object sender, EventArgs e) 
        {
            if (!String.IsNullOrEmpty(tbxPlayerName.Text))
            {
                // player must have a name length of 3 letter or greater inorder to create player
                if (tbxPlayerName.Text.Length >= 3) 
                {
                    btnCreatePlayer.Enabled = true;
                } else{
                    if (tbxPlayerName.Text.Length <= 3)
                    {
                        btnCreatePlayer.Enabled = false;
                    }
                }
            } else if (String.IsNullOrEmpty(tbxPlayerName.Text)) {
                btnCreatePlayer.Enabled = false;
            }
        }

        // Close the entire Programe 
        private void PlayerName_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Store player name and hide current form while showing the Russian Roulette form
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            repositoryClass.PlayerName = tbxPlayerName.Text;

            //declare an form called RussianRoulette as russRlttFrom
            RussianRouletteUI russRlttFrom = new RussianRouletteUI();// use russRlttFrom to show RussianRoulette Form
                                                                 
            russRlttFrom.Show();
            this.Hide();
        }
    }
}
