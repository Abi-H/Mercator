namespace Mercator_3
{
    class Message
    {
        private string openingMessage;

        public Message()
        {
            openingMessage = "You are 50000 aurea in debt to Atticus the loan shark. You have 21 days to trade items and pay back the loan. Buy and sell items in different cities to increase your cash";
            Text = openingMessage;
        }

        public string Text { get; set; }

        public string GameOverText { get; set; }

        public void SetMessage(int n)
        {
            switch(n)
            {
                case 1:
                    Text = "Carthagian gold mines were captured by the Gauls. Gold prices are through the roof!";
                    break;
                case 2:
                    Text = "The emperor conquered Egypt and gold is in abundance. Gold prices have plummeted";
                    break;
                case 3:
                    Text = "Bandits are terrorising the silk trade routes. Silk prices are outrageous!";
                    break;
                case 4:
                    Text = "A new bridge has been built over the Bosporus and the market is flooded. Silk is going cheap!";
                    break;
                case 5:
                    Text = "It's been a slow year for shellfish in the Mediterannean. Dye is scarce and people will pay a fortune!";
                    break;
                case 6:
                    Text = "A cheaper way of making oil has hit the market. Oil prices have bottomed out!";
                    break;
                case 7:
                    Text = "It's a bad season for olives. Oil prices have skyrocketed!";
                    break;
                case 8:
                    Text = "The market has been flooded with cheap low quality oil. Oil prices are at an all time low";
                    break;
                case 9:
                    Text = "Frost destroyed most of the grape vines. Wine is expensive and hard to come by";
                    break;
                case 10:
                    Text = "The emperor has won the Gallic war and is supplying the city with wine. Get it while it's cheap!";
                    break;
                case 11:
                    Text = "The East has been conquered by foreign invaders. No spices are coming in and prices are outrageous";
                    break;
                case 12:
                    Text = "A new trade route has opened with the East. The market is flooded with cheap spices";
                    break;
                case 13:
                    Text = "It's a hard winter and leather is in high demand. Leather prices are at an all time high";
                    break;
                case 14:
                    Text = "Hundreds of bulls have been sacrificed to Neptune. Cheap leather is in abundance";
                    break;
                case 15:
                    Text = "A famine has broken out in the city. Grain prices are through the roof!";
                    break;
                case 16:
                    Text = "The emperor is refilling the grain stores. Grain is going cheap!";
                    break;
                case 17 :
                    Text = "The market district is bustling today";
                    break;
                case 18:
                    Text = "Atticus is displeased with how long you are taking. He has added 500 aurea to your debt.";
                    break;
                case 19:
                    Text = "You are robbed by bandits on the way to the market and lose 200 aurea.";
                    break;
                case 20:
                    Text = "You happen upon an unattended bag of 200 aurea. You've lucked out!";
                    break;
                case 21:
                    Text = "You are out of time. You must pay Atticus.";
                    break;
            }
        }

        public void SetGameOverMessage(int n)
        {
            switch(n)
            {
                case 1:
                    GameOverText = "Congratulations! You have successfully paid back Atticus and are no longer in danger of being sold as a slave. Enjoy your freedom.";
                    break;
                case 2:
                    GameOverText = "You did not manage to pay back Atticus. As punishment you will be sold as a slave to work off your remaining debt";
                    break;
            }
        }
    }
}
