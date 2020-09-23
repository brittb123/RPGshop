using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HelloWorld
{

    public struct item
    {
        public int cost;
        public string name;
    }

   public class Shop
    {
        public string[] itemname = { "Arrows", "Shield", "Healing Gem" };
        private int ShopCoins;
        private item[] ShopInventory;
        private item Shield;
        private item healingGem;
        private item arrows;

      
        Shop()
        {
            int coins = 0;
            ShopInventory = new item[3];
          
        }
        Shop(item[] items)
        {
            for (int i = 0; i < 3; i++)
            {
                ShopInventory[i] = items[i];
            }

            
        }
    }
}
