using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public class GameRepository
    {

        private string level; 

        // Geter seter methods to get and store values
        public string PlayerName { get; set; } 

        public int ShotsLeft { get; set; }

        public int DucksLeft { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public string[] chambers; // the chamber is a String Array to store the bullet

        public void SetDifficulty(string levelname)
        {
            level = levelname;
        }

        public string GetDifficulty()
        {
            return level;
        }

        //Load the bullet in to the first chamber (chamber 0)
        public void LoadBullet() {

            string bullet = "BANG!";
            string noBullet = "Click!";

            // chamber range of index value is 0 to 5
            chambers = new string[6] { bullet, noBullet, noBullet, noBullet, noBullet, noBullet};
        }

        // "spin the chamber:" randomly select where the bullet will be in the chamber
        public void SpinChambers()
        {
            LoadBullet();

            Random rnd = new Random();

            int spin = rnd.Next(0, 6); // possible values are 0 to 5

            chambers[0] = "Click!";

            chambers[spin] = "BANG!";
        }
    }

}
