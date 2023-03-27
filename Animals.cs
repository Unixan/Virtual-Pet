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
        public void ListOfAnimals()
        {
            for (var i = 0; i < _animals.Count; i++)
            {
                var menuChoice = i + 1;
                var animal = _animals[i];
                Console.WriteLine($"{menuChoice}\nNavn: {animal.GetName()}\nRase: {animal.GetRace()}\nElsker {animal.GetFavFood()}\n\n");
            }
        }

        public void FeedInList(int animalIndex)
        {
            _animals[animalIndex].Feed();
        }
        public void FeedInList(int animalIndex, string food)
        {
            _animals[animalIndex].Feed(food);
        }

        public string GetNameInIndex(int index)
        {
            return _animals[index].GetName();
        }
    }
}
