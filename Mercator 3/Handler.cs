using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Mercator_3
{
    class Handler : INotifyPropertyChanged
    {       
        private ItemToBuy gold, silk, dye, oil, wine, spice, leather, grain;
        private Dictionary<string, ItemToBuy> items;     

        public enum City { Rome = 0, Ostia = 1, Capua = 2, Herculaneum = 3, Pompeii = 4 };

        private City city;
        private Player player;
        private Timer timer;
        private Message message;
        private Random random;

        public Handler()
        {
            player = new Player(50, 50000);
            items = new Dictionary<string, ItemToBuy>();
            gold = new ItemToBuy(100, 200, 10, "gold");
            items.Add(gold.Name, gold);
            silk= new ItemToBuy(60, 160, 30, "silk");
            items.Add(silk.Name, silk);
            dye = new ItemToBuy(45, 180, 50, "dye");
            items.Add(dye.Name, dye);
            oil = new ItemToBuy(30, 90, 100, "oil");
            items.Add(oil.Name, oil);
            wine = new ItemToBuy(5, 35, 150, "wine");
            items.Add(wine.Name, wine);
            spice = new ItemToBuy(8, 60, 100, "spice");
            items.Add(spice.Name, spice);
            leather = new ItemToBuy(3, 20, 80, "leather");
            items.Add(leather.Name, leather);
            grain = new ItemToBuy(2, 10, 200, "grain");
            items.Add(grain.Name, grain);
            message = new Message();
            city = City.Rome;
            random = new Random();
            timer = new Timer(21);
        }

        struct Timer
        {
            private int days;

            public Timer(int days)
            {
                this.days = days;
            }

            public int GetDaysLeft()
            {
                return this.days;
            }

            public void NextDay()
            {
                this.days -= 1;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public City CurrentCity
        {
            get { return city; }
            set
            {
                city = value;
                this.OnPropertyChanged(nameof(CurrentCity));
            }
        }

        public string Message
        {
            get { return message.Text; }
            set { this.OnPropertyChanged(nameof(Message)); }
        }

        public string GameOverMessage
        {
            get { return message.GameOverText; }
            set { this.OnPropertyChanged(nameof(GameOverMessage)); }
        }

        public int Days
        {
            get { return timer.GetDaysLeft(); }
            set { this.OnPropertyChanged(nameof(Days)); }
        }

        public int Cash
        {
            get { return player.Cash; }
            set { this.OnPropertyChanged(nameof(Cash)); }
        }

        public int Debt
        {
            get { return player.Debt; }
            set
            {
                player.Debt = value;
                this.OnPropertyChanged(nameof(Debt));
            }
        }
     
        public int GoldPrice
        {
            get { return gold.Price; }
            set
            {
                gold.Price = value;
                this.OnPropertyChanged(nameof(GoldPrice)); 
            }
        }

        public int GoldQuantity
        {
            get { return gold.Quantity; }
            set
            {
                gold.Quantity = value;
                this.OnPropertyChanged(nameof(GoldQuantity));
            }
        }

        public int SilkPrice
        {
            get { return silk.Price; }
            set
            {
                silk.Price = value;
                this.OnPropertyChanged(nameof(SilkPrice));
            }
        }

        public int SilkQuantity
        {
            get { return silk.Quantity; }
            set
            {
                silk.Quantity = value;
                this.OnPropertyChanged(nameof(SilkQuantity));
            }
        }

        public int DyePrice
        {
            get { return dye.Price; }
            set
            {
                dye.Price = value;
                this.OnPropertyChanged(nameof(DyePrice));
            }
        }

        public int DyeQuantity
        {
            get { return dye.Quantity; }
            set
            {
                dye.Quantity = value;
                this.OnPropertyChanged(nameof(DyeQuantity));
            }
        }

        public int OilPrice
        {
            get { return oil.Price; }
            set
            {
                oil.Price = value;
                this.OnPropertyChanged(nameof(OilPrice));
            }
        }

        public int OilQuantity
        {
            get { return oil.Quantity; }
            set
            {
                oil.Quantity = value;
                this.OnPropertyChanged(nameof(OilQuantity));
            }
        }

        public int WinePrice
        {
            get { return wine.Price; }
            set
            {
                wine.Price = value;
                this.OnPropertyChanged(nameof(WinePrice));
            }
        }

        public int WineQuantity
        {
            get { return wine.Quantity; }
            set
            {
                wine.Quantity = value;
                this.OnPropertyChanged(nameof(WineQuantity));
            }
        }

        public int SpicePrice
        {
            get { return spice.Price; }
            set
            {
                spice.Price = value;
                this.OnPropertyChanged(nameof(SpicePrice));
            }
        }

        public int SpiceQuantity
        {
            get { return spice.Quantity; }
            set
            {
                spice.Quantity = value;
                this.OnPropertyChanged(nameof(SpiceQuantity));
            }
        }

        public int LeatherPrice
        {
            get { return leather.Price; }
            set
            {
                leather.Price = value;
                this.OnPropertyChanged(nameof(LeatherPrice));
            }
        }

        public int LeatherQuantity
        {
            get { return leather.Quantity; }
            set
            {
                leather.Quantity = value;
                this.OnPropertyChanged(nameof(LeatherQuantity));
            }
        }

        public int GrainPrice
        {
            get { return grain.Price; }
            set
            {
                grain.Price = value;
                this.OnPropertyChanged(nameof(GrainPrice));
            }
        }

        public int GrainQuantity
        {
            get { return grain.Quantity; }
            set
            {
                grain.Quantity = value;
                this.OnPropertyChanged(nameof(GrainQuantity));
            }
        }

        public int GoldBag
        {
            get { return player.GetItemQuantity("gold"); }
            set { this.OnPropertyChanged(nameof(GoldBag)); }
        }

        public int SilkBag
        {
            get { return player.GetItemQuantity("silk"); }
            set { this.OnPropertyChanged(nameof(SilkBag)); }

        }

        public int DyeBag
        {
            get { return player.GetItemQuantity("dye"); }
            set { this.OnPropertyChanged(nameof(DyeBag)); }

        }

        public int OilBag
        {
            get { return player.GetItemQuantity("oil"); }
            set { this.OnPropertyChanged(nameof(OilBag)); }

        }

        public int WineBag
        {
            get { return player.GetItemQuantity("wine"); }
            set { this.OnPropertyChanged(nameof(WineBag)); }

        }

        public int SpiceBag
        {
            get { return player.GetItemQuantity("spice"); }
            set { this.OnPropertyChanged(nameof(SpiceBag)); }
        }

        public int LeatherBag
        {
            get { return player.GetItemQuantity("leather"); }
            set { this.OnPropertyChanged(nameof(LeatherBag)); }
        }

        public int GrainBag
        {
            get { return player.GetItemQuantity("grain"); }
            set { this.OnPropertyChanged(nameof(GrainBag)); }
        }

        public void UpdateGame()
        {
            foreach (ItemToBuy item in items.Values)
            {
                item.SetRandomPrice();
                item.SetRandomQuantity();
            }

            GoldPrice = gold.Price;
            SilkPrice = silk.Price;
            DyePrice = dye.Price;
            OilPrice = oil.Price;
            WinePrice = wine.Price;
            SpicePrice = spice.Price;
            LeatherPrice = leather.Price;
            GrainPrice = grain.Price;

            GoldQuantity = gold.Quantity;
            SilkQuantity = silk.Quantity;
            DyeQuantity = dye.Quantity;
            OilQuantity = oil.Quantity;
            WineQuantity = wine.Quantity;
            SpiceQuantity = spice.Quantity;
            LeatherQuantity = leather.Quantity;
            GrainQuantity = grain.Quantity;

            CreateEvent();

            if(CurrentCity == City.Rome)
            {
                GoldPrice = gold.Price / 2;
                GrainPrice = grain.Price * 2;
            }
            else if(CurrentCity == City.Capua)
            {
                SilkPrice = silk.Price * 2;
                LeatherPrice = leather.Price / 2;
            }
            else if(CurrentCity == City.Ostia)
            {
                GrainPrice = grain.Price / 2;
                SpicePrice = spice.Price / 2;
                DyePrice = dye.Price / 2;
                GoldPrice = gold.Price * 2;
                SilkPrice = silk.Price * 2;
            }
            else if(CurrentCity == City.Pompeii)
            {
                OilPrice = oil.Price / 2;
                WinePrice = wine.Price / 2;
                GoldPrice = gold.Price * 2;
            }
            else
            {
                SilkPrice = silk.Price / 2;
                LeatherPrice = leather.Price * 2;
            }
        }

        private void UpdateBag()
        {
            GoldBag = player.GetItemQuantity("gold");
            SilkBag = player.GetItemQuantity("silk");
            DyeBag = player.GetItemQuantity("dye");
            OilBag = player.GetItemQuantity("oil");
            WineBag = player.GetItemQuantity("wine");
            SpiceBag = player.GetItemQuantity("spice");
            LeatherBag = player.GetItemQuantity("leather");
            GrainBag = player.GetItemQuantity("grain");
        }

        private void UpdateQuantities(string item)
        {
            switch (item)
            {
                case "gold":
                    GoldQuantity = items[item].Quantity;
                    break;
                case "silk":
                    SilkQuantity = items[item].Quantity;
                    break;
                case "dye":
                    DyeQuantity = items[item].Quantity;
                    break;
                case "oil":
                    OilQuantity = items[item].Quantity;
                    break;
                case "wine":
                    WineQuantity = items[item].Quantity;
                    break;
                case "spice":
                    SpiceQuantity = items[item].Quantity;
                    break;
                case "leather":
                    LeatherQuantity = items[item].Quantity;
                    break;
                case "grain":
                    GrainQuantity = items[item].Quantity;
                    break;
            }
        }

        public void nextTurn(int city)
        {
            if (timer.GetDaysLeft() == 0)
            {
                message.SetMessage(21);
                Message = message.Text;
                GameOver();
            }
            else
            {
                CurrentCity = (City)city;
                timer.NextDay();
                Days = timer.GetDaysLeft();
                UpdateGame();
            }
        }

        public void BuyItem(string item, int amount, int price)
        {
            if ((player.CanPurchase(price * amount)) && (items[item].Quantity - amount >= 0))
            {
                player.RemoveCash(price * amount);
                player.AddItem(item, amount);
                Cash = player.Cash;
                items[item].Quantity -= amount;
                UpdateQuantities(item);
                UpdateBag();
            }
        }

        public void SellItem(string item, int amount, int price)
        {
            if (player.CanSell(item, amount))
            {
                player.AddCash(price * amount);
                player.RemoveItem(item, amount);
                Cash = player.Cash;
                UpdateBag();
            }
        }

        public void GameOver()
        {
            if (HasWon())
            {
                message.SetGameOverMessage(1);
            }
            else
            {
                message.SetGameOverMessage(2);               
            }

            GameOverMessage = message.GameOverText;
        }

        public bool HasWon()
        {
            if (Cash >= Debt)
            {
                return true;
            }

            return false;
        }

        private void CreateEvent()
        {
            int eventType = random.Next(1, 21);

            switch(eventType)
            {
                case 1:
                    GoldPrice = gold.HighPrice;
                    message.SetMessage(1);
                    Message = message.Text;
                    GoldPrice = gold.HighPrice;
                    break;
                case 2:
                    GoldPrice = gold.LowPrice;
                    message.SetMessage(2);
                    Message = message.Text;
                    break;
                case 3:
                    SilkPrice = silk.HighPrice;
                    message.SetMessage(3);
                    Message = message.Text;
                    break;
                case 4:
                    SilkPrice = silk.LowPrice;
                    message.SetMessage(4);
                    Message = message.Text;
                    break;
                case 5:
                    DyePrice = dye.HighPrice;
                    message.SetMessage(5);
                    Message = message.Text;
                    break;
                case 6:
                    DyePrice = dye.LowPrice;
                    message.SetMessage(6);
                    Message = message.Text;
                    break;
                case 7:
                    OilPrice = oil.HighPrice; ;
                    message.SetMessage(7);
                    Message = message.Text;
                    break;
                case 8:
                    OilPrice = oil.LowPrice;
                    message.SetMessage(8);
                    Message = message.Text;
                    break;
                case 9:
                    WinePrice = wine.HighPrice;
                    message.SetMessage(9);
                    Message = message.Text;
                    break;
                case 10:
                    WinePrice = wine.LowPrice;
                    message.SetMessage(10);
                    Message = message.Text;
                    break;
                case 11:
                    SpicePrice = spice.HighPrice;
                    message.SetMessage(11);
                    Message = message.Text;
                    break;
                case 12:
                    SpicePrice = spice.LowPrice;
                    message.SetMessage(12);
                    Message = message.Text;
                    break;
                case 13:
                    LeatherPrice = leather.HighPrice;
                    message.SetMessage(13);
                    Message = message.Text;
                    break;
                case 14:
                    LeatherPrice = leather.LowPrice;
                    message.SetMessage(14);
                    Message = message.Text;
                    break;
                case 15:
                    GrainPrice = grain.HighPrice;
                    message.SetMessage(15);
                    Message = message.Text;
                    break;
                case 16:
                    GrainPrice = grain.LowPrice;
                    message.SetMessage(16);
                    Message = message.Text;
                    break;
                case 17:
                    message.SetMessage(17);
                    Message = message.Text;
                    break;
                case 18:
                    message.SetMessage(18);
                    Message = message.Text;
                    player.Debt += 500;
                    Debt = player.Debt;
                    break;
                case 19:
                    message.SetMessage(19);
                    Message = message.Text;
                    player.Cash -= 200;
                    Cash = player.Cash;

                    if(player.Cash < 0)
                    {
                        player.Cash = 0;
                        Cash = player.Cash;
                    }

                    break;
                case 20:
                    message.SetMessage(20);
                    Message = message.Text;
                    player.Cash += 200;
                    Cash = player.Cash;
                    break;
            }
        }        
    }
}
