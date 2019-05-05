using System;

namespace Mercator_3
{
    class ItemToBuy : Item
    {
        private Random random;

        public ItemToBuy(int lowPrice, int highPrice, int maxQuantity, string name) : base(name)
        {
            LowPrice = lowPrice;
            HighPrice = highPrice;
            MaxQuantity = maxQuantity;
            s
            random = new Random();

            SetRandomPrice();
            SetRandomQuantity();
        }

        public int LowPrice { get; set; }

        public int HighPrice { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }        

        public int MaxQuantity { get; set; }

        public void SetRandomPrice()
        {
            Price = random.Next(LowPrice, HighPrice);
        }

        public void SetRandomQuantity()
        {
            Quantity = random.Next(0, MaxQuantity);
        }

        public bool CanPurchase(int quantity)
        {
            if(Quantity - quantity >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
