namespace Virtual_Pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animalList = new Animals();
            MainMenu(animalList);
        }

        private static void MainMenu(Animals animalList)
        {
            bool typeIsValid;
            do
            {
                typeIsValid = true;
                Console.Clear();
                Console.WriteLine(
                    "Hva slags dyr vil du ha?\nGyldige valg er:\n\nKatt\nHund\nSlange\nElefant\n\nSkriv typen i konsollen og trykk Enter");
                var type = Console.ReadLine().ToLower();
                switch (type)
                {
                    case "katt":
                        {
                            Console.Write("Hva skal katten din hete?\n:> ");
                            var name = Console.ReadLine();
                            animalList.AddAnimal(new Cat(name));
                            break;
                        }
                    case "hund":
                        {
                            Console.Write("Hva skal hunden din hete?\n:> ");
                            var name = Console.ReadLine();
                            animalList.AddAnimal(new Dog(name));
                            break;
                        }
                    case "slange":
                        {
                            Console.Write("Hva skal slangen din hete?\n:> ");
                            var name = Console.ReadLine();
                            animalList.AddAnimal(new Snake(name));
                            break;
                        }
                    case "elefant":
                        {
                            Console.Write("Hva skal elefanten din hete?\n:> ");
                            var name = Console.ReadLine();
                            animalList.AddAnimal(new Elephant(name));
                            break;
                        }
                    default:
                        {
                            Common.Pause("Ugyldig valg!");
                            typeIsValid = false;
                            break;
                        }
                }
                Console.Clear();
                Console.WriteLine("Vil du legge til flere dyr?(j/n)");
                var moreAnimals = Console.ReadLine();
                if (moreAnimals.ToLower() == "j") typeIsValid = false;
            } while (!typeIsValid);

            animalListMenu(animalList);
        }

        private static void animalListMenu(Animals animalList)
        {
            bool listSelection;
            do
            {
                listSelection = false;
                Console.Clear();
                Console.WriteLine(
                    "Hva vil du gjøre nå?\n\n1: Se alle dyr jeg har.\n2: Mate et dyr\n3: Legge til flere dyr\n0: Avslutte");
                var listChoice = Console.ReadLine();
                switch (listChoice)
                {
                    case "1":
                        ListAnimals(animalList);
                        break;
                    case "2":
                        FeedAnimals(animalList);
                        break;
                    case "3":
                        MainMenu(animalList);
                        break;
                    case "0":
                        listSelection = true;
                        break;
                    default:
                    {
                        Common.Pause("Ugyldig valg!");
                        break;
                    }
                }
            }while (!listSelection);
        }
        private static void ListAnimals(Animals animalList)
        {
            Console.Clear();
            Console.WriteLine("Dyr du har:\n");
            animalList.ListOfAnimals();
            Common.Pause();
        }
        private static void FeedAnimals(Animals animalList)
        {
            Console.Clear();
            Console.WriteLine("Hvilket dyr vil du mate?\n");
            animalList.ListOfAnimals();
            var animalToFeed = Convert.ToInt32(Console.ReadLine());
            var animalIndex = animalToFeed - 1;
            Console.WriteLine($"Hva vil du mate {animalList.GetNameInIndex(animalIndex)} med? (Trykk enter for tørrfor)");
            var foodToFeed = Console.ReadLine();
            if (foodToFeed.Length == 0)
            {
                animalList.FeedInList(animalIndex);
            }
            else animalList.FeedInList(animalIndex, foodToFeed);
            Common.Pause();
        }

       
    }
}