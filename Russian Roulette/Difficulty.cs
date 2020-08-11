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
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }
        
        // with the new public static instance of the "GameRepository" class we can make the values stored globle accessable with this 
        // class instance
        public static GameRepository repositoryClass = new GameRepository();

        PlayerName pnForm = new PlayerName(); //declare an form called PlayerName as pnForm
                                              // use pnForm to show PlayerName Form

        

        // Store all values inside of class instance (repositoryClass) 
        private void btnEasy_Click(object sender, EventArgs e)
        {
            repositoryClass.SetDifficulty("Easy");
            repositoryClass.DucksLeft = 3;
            pnForm.Show();
            this.Hide(); // Hide current Form
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            repositoryClass.SetDifficulty("Normal");
            repositoryClass.DucksLeft = 2;
            pnForm.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            repositoryClass.SetDifficulty("Hard");
            repositoryClass.DucksLeft = 1;
            pnForm.Show();
            this.Hide();
        }

        // Close the entire Programe 
        private void Difficulty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
