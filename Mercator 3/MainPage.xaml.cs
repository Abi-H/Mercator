using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mercator_3
{
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();           
            this.DataContext = handler;
            
        }

        Handler handler = new Handler();

        private void romeBtn_Click(object sender, RoutedEventArgs e)
        {
            handler.nextTurn(0);
        }

        private void ostiaBtn_Click(object sender, RoutedEventArgs e)
        {
            handler.nextTurn(1);
        }

        private void capuaBtn_Click(object sender, RoutedEventArgs e)
        {
            handler.nextTurn(2);
        }

        private void hercBtn_Click(object sender, RoutedEventArgs e)
        {
            handler.nextTurn(3);
        }

        private void pompeiiBtn_Click(object sender, RoutedEventArgs e)
        {
            handler.nextTurn(4);
        }

        private void restBtn_Click(object sender, RoutedEventArgs e)
        {
            handler.GameOver();
            pop.IsOpen = true;
        }

        private void goldBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = goldBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(goldPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("gold", n, price);
            }

            goldBuyBox.Text = "0";
        }

        private void silkBuyBtn1_Click(object sender, RoutedEventArgs e)
        {
            string input = silkBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(silkPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("silk", n, price);
            }

            silkBuyBox.Text = "0";
        }

        private void dyeBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = dyeBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(dyePriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("dye", n, price);
            }

            dyeBuyBox.Text = "0";
        }

        private void oilBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = oilBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(oilPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("oil", n, price);
            }

            oilBuyBox.Text = "0";
        }

        private void wineBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = wineBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(winePriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("wine", n, price);
            }

            wineBuyBox.Text = "0";
        }

        private void spiceBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = spiceBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(spicePriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("spice", n, price);
            }

            spiceBuyBox.Text = "0";
        }

        private void leatherBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = leatherBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(leatherPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("leather", n, price);
            }

            leatherBuyBox.Text = "0";
        }

        private void grainBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = grainBuyBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(grainPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.BuyItem("grain", n, price);
            }

            grainBuyBox.Text = "0";
        }

        private void goldSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = goldSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(goldPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("gold", n, price);
            }

            goldSellBox.Text = "0";
        }

        private void silkSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = silkSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(silkPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("silk", n, price);
            }

            silkSellBox.Text = "0";
        }

        private void dyeSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = dyeSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(dyePriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("dye", n, price);
            }

            dyeSellBox.Text = "0";
        }

        private void oilSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = oilSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(oilPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("oil", n, price);
            }

            oilSellBox.Text = "0";
        }

        private void wineSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = wineSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(winePriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("wine", n, price);
            }

            wineSellBox.Text = "0";
        }

        private void spiceSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = spiceSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(spicePriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("spice", n, price);
            }

            spiceSellBox.Text = "0";
        }

        private void leatherSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = leatherSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(leatherPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("leather", n, price);
            }

            leatherSellBox.Text = "0";
        }

        private void grainSellBtn_Click(object sender, RoutedEventArgs e)
        {
            string input = grainSellBox.Text;
            int number;
            bool result = Int32.TryParse(input, out number);
            int price = Int32.Parse(grainPriceBlock.Text);

            if (result)
            {
                int n = Int32.Parse(input);
                handler.SellItem("grain", n, price);
            }

            grainSellBox.Text = "0";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
