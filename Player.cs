using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace HelloWorld
{


    public class Player
    {

        private int _coins;
       
        public item[] _Inventory;

  
        public Player()
        {
            _coins = 200;
            //Creates new item array for inventory
            _Inventory = new item[3];


        }


        public bool Buy(item item, int inventoryIndex)
        {
           if(_coins >= item.cost)
           {
                //Pays for item
                _coins -= item.cost;
                //Places the item in inventory
                _Inventory[inventoryIndex] = item;

                return true;
           }

            return false;
        }

        public int GetCoins()
        {
            return _coins;
        }

        public item[] GetInventory()
        {
            return _Inventory;
        }

    }
}
