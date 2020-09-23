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
        public bool buying = true;
        public item[] _Inventory;

        
        

        public Player()
        {
            _coins = 200;
            _Inventory = new item[3];


        }

        public item[] GetInventory()
        {
            return _Inventory;
            
        }

       
        public void Buy(item[] items, int cost)
        {
            if (_coins > cost)
            {
                Console.WriteLine("Are you sure you want to buy this item?");

            }
        }



    }
}
