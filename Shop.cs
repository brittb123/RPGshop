using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HelloWorld
{

   

   public class Shop
    {
        public string[] itemname = { "Arrows", "Shield", "Healing Gem" };
        private int _coins;
        private int ShopCoins;
        private item[] _inventory;
        private item Shield;
        private item healingGem;
        private item arrows;

      
       public Shop()
        {
            int _coins = 100;
            _inventory = new item[3];
          
        }
       public Shop(item[] items)
        {
            _coins = 100;
            //Sets inventory to be equal to amount of items
            _inventory = items;
            
        }

        public bool Sell(Player player, int ItemIndex, int playerIndex)
        {
            item itemTobuy = _inventory[ItemIndex];
            //Checks if the item bought correctly
           if(player.Buy(itemTobuy, playerIndex))
           {
                _coins += itemTobuy.cost;
                return true;
           }
            return false;
        }

    }
}
