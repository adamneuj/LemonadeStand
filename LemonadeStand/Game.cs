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
        public Weather weather;
        public Day day;
        public Store store;


        //constructor
        public Game()
        {
            gameLength = 7;
            playerOne = new Player();
            weather = new Weather();
            day = new Day();
            store = new Store();
        }

        //member methods
        public void RunGame()
        {
            Messages.DisplayRules();
            playerOne.NameYourPlayer();
            GamePlayLoop(day, weather, playerOne, store);
            Messages.PressEnterToContinue();
        }

        public void GamePlayLoop(Day day, Weather weather, Player player, Store store)
        {
            while(gameLength != 0)
            {
                weather.GenerateWeather();
                MainMenu.CallMenu(day, weather, player, store);
                GenerateTraffic(weather, player);
                player.lemonadeStand.ServeCustomers(player);
                Console.Clear();
                gameLength--;
            }
        }
        public void GenerateTraffic(Weather weather, Player player)
        {
            player.lemonadeStand.GenerateFootTraffic(weather);
            player.lemonadeStand.GeneratePasserbys(weather);
        }
    }
}
