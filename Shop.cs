using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    public class Shop
    {
        public List<GameItem> ShoppingCart { get; set; }
        public StoreInventory Inventory { get; set; }

        public Shop()
        {
            ShoppingCart = new List<GameItem>();
            Inventory = new StoreInventory();

            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");

                HandleCommand();
            }
        }

        private void HandleCommand()
        {
            var command = Console.ReadLine();
            Inventory.PrintInventory(command);

            Console.WriteLine("input the ID of game you want to buy");
            var gameID = Console.ReadLine();
            var gameToBuy = Inventory.InventoryList.Find(x => x.Id == gameID);
            ShoppingCart.Add(gameToBuy);
           
            if(gameToBuy is IPhysicalCopy && !(gameToBuy is IDownloadable))
            {
                PrintShippingMessage(gameToBuy.GameName);
            }
            else if(gameToBuy is IDownloadable && !(gameToBuy is IPhysicalCopy))
            {
                PrintDownloadMessage(gameToBuy.GameName);
            }
            else
            {
                ChooseShippingOrDownLoad(gameToBuy.GameName);
            }
        }

        private void ChooseShippingOrDownLoad(string gameName)
        {
            Console.WriteLine("Do you wish to download this game? Y/N");
            var reply = Console.ReadLine();
            if (reply.ToUpper() == "Y")
            {
                PrintDownloadMessage(gameName);
            }
            else
            {
                PrintShippingMessage(gameName);
            }
        }

        private void PrintDownloadMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will now be downloaded..");            
        }
        private void PrintShippingMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will be shipped shortly..");
        }
    }
}
