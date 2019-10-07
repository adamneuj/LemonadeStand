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
        public bool loseCondition;


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
                Messages.DisplayDailyProfit(player);
                day.CycleDay();
                gameLength--;
                CheckLoseCondition(player);
            }
            if (loseCondition)
            {
                Console.WriteLine("I'm sorry " + player.name + "your lemonade stand has closed shop for good.\n" +
                    "Better luck next time.");
            }
            else
            {

            }
        }
        public void GenerateTraffic(Weather weather, Player player)
        {
            player.lemonadeStand.GenerateFootTraffic(weather);
            player.lemonadeStand.GeneratePasserbys(weather);
        }

        public void CheckLoseCondition(Player player)
        {
            if(player.wallet.money <= 0)
            {
                Console.Clear();
                loseCondition = true;
                gameLength = 0;
            }
        }
    }
}
