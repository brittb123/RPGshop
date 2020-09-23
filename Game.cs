using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;





namespace HelloWorld
{

    public struct item
    {
        public int cost;
        public string name;
    }

    class Game
    {
        private Player _player;
        private Shop _shop;
        public bool _gameOver = false;
       

        public Player player1;
        private Shop WinkingWarrior;


        private int[] Item = new int[3];
        private item[] name;
        private item arrow;
        private item shield;
        private item healingGem;
        private item[] shopInventory;
        private string[] itemnames = { "Arrows", "Shield", "Healing Gem" };


        public void InitialItems()
        {
            _player.GetInventory();
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
            PrintInventory(shopInventory);
            char input = Console.ReadKey().KeyChar;
            int playerIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        playerIndex = 0;
                        break;
                    }

                case '2':
                    {
                        playerIndex = 1;
                        break;
                    }

                case '3':
                    {
                        playerIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            if (_player.GetCoins() < shopInventory[playerIndex].cost)
            {
                Console.WriteLine("Can not afford this item");
                return;
            }
          

        }
        //Prints inventory on screen
        public void PrintInventory(item[] inventory)
        {

            for (int i = 0; i < inventory.Length; i++)
            {

                Console.WriteLine((i + 1) + inventory[i].name + inventory[i].cost) ;
                
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
            _player = new Player();
            PrintInventory(_player._Inventory);
            InitialItems();
            shopInventory = new item[] { arrow, shield, healingGem };
            _shop = new Shop(shopInventory);

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
