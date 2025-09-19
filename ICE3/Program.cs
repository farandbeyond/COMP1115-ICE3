namespace ICE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //name
            string CharacterName = "";
            //primary attributes
            int Agility = 0, Strength = 0, Vigour = 0, Perception = 0, Intellect = 0, Will = 0;
            //secondary attributes
            int Awareness = 0, Toughness = 0, Resolve = 0;
            //career variables
            string Career = "";
            bool HasChosenCareer = false;

            //setup career selection
            //prompt user for the character name
            Console.WriteLine("What is your Name?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Now, choose your Career:");
            Console.WriteLine("1: Army");
            Console.WriteLine("2: Psion");
            Console.WriteLine("3: Telepath");
            Console.WriteLine("4: Rogue");
            Console.WriteLine("5: Tinker");

            Console.ReadKey(true);

        }
    }
}
