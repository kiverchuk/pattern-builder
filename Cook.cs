using System;

namespace Builder
{
    internal class Cook
    {
        internal void createEggFried(FoodBuilder builder)
        {
            builder.setType("eggs");
            builder.setName("fried eggs");
            builder.setPrice("3$");
        }

        internal void createEggOmelette(FoodBuilder builder)
        {
            builder.setType("eggs");
            builder.setName("Egg Omlet");
            builder.setPrice("5$");
        }
    }
}