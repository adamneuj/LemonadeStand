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
            gameLength = 1;
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
            GamePlayLoop(day, weather, playerOne, store);
            Messages.PressEnterToContinue();
        }

        public void GamePlayLoop(Day day, Weather weather, Player player, Store store)
        {
            while(gameLength != 0)
            {
                MainMenu.CallMenu(day, weather, player, store);
                //Messages.DisplayDay(day, weather);
                //CheckInventory(playerOne, store);
                //store.BuyFromStore(playerOne);
                //Messages.ShowInventory(playerOne);
                gameLength--;
            }
        }

        public Player CheckInventory(Player player, Store store)
        {
            if(player.inventory.lemons.Count == 0)
            {
                Messages.DisplayNeedToGoToStore();
                Messages.ShowInventory(player);
                return store.BuyFromStore(player);
            }
            else if(player.inventory.sugar.Count == 0)
            {
                Messages.DisplayNeedToGoToStore();
                Messages.ShowInventory(player);
                return store.BuyFromStore(player);
            }
            else if(player.inventory.iceCubes.Count == 0)
            {
                Messages.DisplayNeedToGoToStore();
                Messages.ShowInventory(player);
                return store.BuyFromStore(player);
            }
            else if(player.inventory.cups.Count == 0)
            {
                Messages.DisplayNeedToGoToStore();
                Messages.ShowInventory(player);
                return store.BuyFromStore(player);
            }
            else
            {
                return player;
            }
        }

    }
}
