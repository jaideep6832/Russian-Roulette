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
    public partial class GameMenu : Form
    {
        
        public GameMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Difficulty diffFrom = new Difficulty();
            diffFrom.Show();
            this.Hide();
        }

        // Close the entire Programe 
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Close the entire Programe 
        private void GameMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
