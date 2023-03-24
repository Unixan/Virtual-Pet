namespace Virtual_Pet
{
    internal abstract class Animal
    {
        protected string Name;
        internal string FavFood;

        public Animal(string favFood)
        {
            FavFood = favFood;
        }
        public void Feed(string food)
        {
            if (FavFood == food)
            {

            }
            else
            {

            }
        }
    }
}
