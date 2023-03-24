namespace Virtual_Pet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animalList = new Animals();
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
                            break;
                        }
                    case "hund":
                        {
                            break;
                        }
                    case "slange":
                        {
                            break;
                        }
                    case "elefant":
                        {
                            break;
                        }
                    default:
                        {
                            Common.Pause("Ugyldig valg!");
                            typeIsValid = false;
                            break;
                        }
                }
            }
            while (!typeIsValid);
            //Console.Clear();
            //Console.WriteLine("Hva skal dyret ditt hete?: ");
            //var name = Console.ReadLine();
        }

    }
}