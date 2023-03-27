namespace Virtual_Pet
{
    internal abstract class Animal
    {
        protected string Name;
        protected string FavFood;
        protected string Race;

        public Animal(string food)
        {
            FavFood = food;
        }
        public void Feed(string food = "tørrfor")
        {
            if (FavFood == food)
            {
                Console.WriteLine($"{Name} elsker jo {food} og spiser opp rubbel og bit!");
            }
            else
            {
                Console.WriteLine($"{Name} sniffer litt på {food}, men er ikke veldig begeistret");
            }
        }

        public string GetName()
        {
            return Name;
        }

        public string GetRace()
        {
            return Race;
        }

        public string GetFavFood()
        {
            return FavFood;
        }
    }
}
