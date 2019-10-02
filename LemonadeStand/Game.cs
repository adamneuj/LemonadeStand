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
            Store store = new Store();
            weather.GenerateWeather();
            GamePlayLoop(day, weather, store);
            Messages.PressEnterToContinue();
        }

        public void GamePlayLoop(Day day, Weather weather, Store store)
        {
            while(gameLength != 0)
            {
                Messages.DisplayDay(day, weather);
                store.BuyFromStore(playerOne);
                Messages.ShowInventory(playerOne);
                gameLength--;
            }
        }

    }
}
