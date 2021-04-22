using System;
using System.Collections.Generic;
using System.Text;

namespace clickeropgrade
{
    class UpgradeUpgrade : ICommand
    {
        public void Run()
        {
            if (ClickerGame.points >= 100)
            {
                ClickerGame.points -= 100;
                ClickerGame.pointsPerClickIncrease++;
                ClickerGame.UpgradeUpgradeCounter++;
            }
        }
    }
}
