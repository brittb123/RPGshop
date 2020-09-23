using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;





namespace HelloWorld
{

    class Game
    {
        public Player player;
        public Shop shop;
        public bool _gameOver = false;
        public bool buying = true;
        public bool selling = false;

        public Player player1;
        private Shop WinkingWarrior;


        private int[] Item = new int[3];
        private item[] name;
        private item arrow;
        private item shield;
        private item healingGem;
        private string[] itemnames = { "Arrows", "Shield", "Healing Gem" };


        public void InitialItems()
        {
            player.GetInventory();
            arrow.name = "Arrow";
            shield.name = "Shield";
            healingGem.name = "Healing Sapphire";
            arrow.cost = 5;
            shield.cost = 25;
            healingGem.cost = 50;

        }

        //Opens the shop menu for purchase or selling
        public void OpenShopMenu()
        {
            Console.WriteLine("What would you like to buy");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + ". " + itemnames[i]);
            }
            char input;
            input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                
               
            }
        }
        //Prints inventory on screen
        public void PrintInventory(item[] _Inventory)
        {

            for (int i = 0; i < _Inventory.Length; i++)
            {
                
                Console.WriteLine(_Inventory[i]);
                
            }
          
        }




        //Run the game
        public void Run()
        {
            Start();
            while (_gameOver = false)
            {
                Update();
            }
            End();

        }

        //Performed once when the game begins
        public void Start()
        {

            PrintInventory(player._Inventory);


        }

        //Repeated until the game ends
        public void Update()
        {
            OpenShopMenu();

        }

        //Performed once when the game ends
        public void End()
        {

        }
    }
}
