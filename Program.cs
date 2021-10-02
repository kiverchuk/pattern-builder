using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook();
            FoodBuilder builder = new FoodBuilder();

            cook.createEggFried(builder);
            Food eggFried = builder.getResalt();

            cook.createEggOmelette(builder);
            Food eggOmelette = builder.getResalt();

            Console.WriteLine(eggFried);
            Console.WriteLine(eggOmelette);
        }
    }
}
