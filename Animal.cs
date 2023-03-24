namespace Virtual_Pet
{
    internal abstract class Animal
    {
        protected string Name;
        protected string FavFood;

        public Animal(string food)
        {
            FavFood = food;
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
