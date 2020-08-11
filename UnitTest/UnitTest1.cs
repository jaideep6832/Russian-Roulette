using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_Roulette;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        GameRepository grClass = new GameRepository();

        //Check if the gun is loaded
        [TestMethod]
        public void IsGunLoaded()
        {
            grClass.LoadBullet();
          
           Assert.AreEqual(grClass.chambers[0], "BANG!");
        }

        //Check if the bullet is in the gun
        [TestMethod]
        public void IsBulletInGun()
        {
            grClass.SpinChambers();
           
            Assert.AreEqual(grClass.chambers.Contains("BANG!"), true);
        }

        //Check if their is more then one bullet in the gun
        [TestMethod]
        public void HowManyBulletsInGun()
        {
            grClass.SpinChambers();
            
            int count = 0; // count the number of bullets in gun

            for (int i = 0; i < grClass.chambers.Length; i++)
            {
                if (grClass.chambers[i] == "BANG!") { count++; }
            }
            Assert.AreEqual(count, 1);
        }


    }
}
