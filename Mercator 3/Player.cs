using System.Collections.Generic;

namespace Mercator_3
{
    class Player {

        private Dictionary<string, int> bag;
        Item gold, silk, dye, oil, wine, spice, leather, grain;

        public Player(int cash, int debt)
        {
            Cash = cash;
            Debt = debt;
            bag = new Dictionary<string, int>();
            gold = new Item("gold");
            silk = new Item("silk");
            dye = new Item("dye");
            oil = new Item("oil");
            wine = new Item("wine");
            spice = new Item("spice");
            leather = new Item("leather");
            grain = new Item("grain");
            InitFillBag();
        }        

        public int Cash { get; set; }

        public int Debt { get; set; }

        private void InitFillBag()
        {
            bag.Add(gold.Name, 0);
            bag.Add(silk.Name, 0);
            bag.Add(dye.Name, 0);
            bag.Add(oil.Name, 0);
            bag.Add(wine.Name, 0);
            bag.Add(spice.Name, 0);
            bag.Add(leather.Name, 0);
            bag.Add(grain.Name, 0);
        }

        public void AddItem(string item, int num)
        {
            bag[item] += num;
        }

        public int GetItemQuantity(string item)
        {
            return bag[item];
        }

        public void RemoveItem(string item, int num)
        {
            bag[item] -= num;
        }

        public void AddCash(int amount)
        {
            Cash += amount;
        }

        public void RemoveCash(int amount)
        {
            Cash -= amount;
        }

        public bool CanPurchase(int amount)
        {
            if (Cash - amount >= 0)
            {
                return true;
            }

            return false;
        }

        public bool CanSell(string item, int amount)
        {
            if ((bag[item] - amount) >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
