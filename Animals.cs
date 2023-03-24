namespace Virtual_Pet
{
    internal class Animals
    {
        private List<Animal> _animals;

        public Animals()
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }
    }
}
