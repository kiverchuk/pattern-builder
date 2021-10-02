using System;

namespace Builder
{
    internal class FoodBuilder : Builder
    {
        private string type;
        private string name;
        private string price;
        private int volume;
        public void setName(string name)
        {
            this.name = name;
        }

        public void setPrice(string price)
        {
            this.price = price;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setVolume(int volume)
        {
            this.volume = volume;
        }

        internal Food getResalt()
        {
            Food food = new Food(type, name, price);
            if (volume != null)
            {
                food._volume = volume;
            }
            return food;
        }
    }
}