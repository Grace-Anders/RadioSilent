using System;
using System.Collections.Generic;

namespace RadioSilent
{
    public class Player
    {
        public int PlayerStamina;
        Item item = new Item();

        public Player() { }
        public Player(int playerstamina)
        {
            PlayerStamina = playerstamina;
        }

        public List<Item> Inventory = new List<Item>();
    }
}
