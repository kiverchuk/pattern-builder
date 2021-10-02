namespace Builder
{
    internal class Food
    {
        protected string type;
        protected string name;
        protected string price;
        protected int volume;

        public Food(string type, string name, string price)
        {
            this.type = type;
            this.name = name;
            this.price = price;
        }
        public string _type
        {
            get => type;
            set { type = value; }
        }
        public string _name
        {
            get => name;
            set { name = value; }
        }
        public string _price
        {
            get => price;
            set { price = value; }
        }
        public int _volume
        {
            get => volume;
            set { volume = value; }
        }

        public override string ToString()
        {
           return $"Food{{name='{name}',type='{type}',price='{price}',volume='{volume}'}}";
        }
    }
}