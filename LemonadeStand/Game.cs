using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        public int gameLength;
        public Player playerOne;

        //constructor
        public Game()
        {
            gameLength = 7;
            playerOne = new Player();

        }

        //member methods
        public void RunGame()
        {
            Messages.DisplayRules();
            playerOne.NameYourPlayer();
            Weather weather = new Weather();
            Day day = new Day();
            Messages.PressEnterToContinue();
        }

        public void GamePlayLoop()
        {
            while(gameLength != 0)
            {

                gameLength--;
            }
        }

    }
}
