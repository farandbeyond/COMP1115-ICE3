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
            string Career = "Unknown";
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

            //take the users input and choose their job
            int careerChoice = Convert.ToInt32(Console.ReadLine());
            if(careerChoice == 1)
            {
                Career = "Army";

                Agility = 20;
                Strength = 50;
                Vigour = 40;
                Perception = 30;
                Intellect = 5;
                Will = 10;

                HasChosenCareer = true;
            }else if(careerChoice == 2)
            {
                Career = "Psion";

                Agility = 30;
                Strength = 5;
                Vigour = 10;
                Perception = 20;
                Intellect = 40;
                Will = 50;

                HasChosenCareer = true;
            }
            else if(careerChoice == 3)
            {
                Career = "Telepath";

                Agility = 5;
                Strength = 10;
                Vigour = 30;
                Perception = 50;
                Intellect = 20;
                Will = 40;

                HasChosenCareer = true;
            }
            else if(careerChoice == 4)
            {
                Career = "Rogue";

                Agility = 50;
                Strength = 30;
                Vigour = 20;
                Perception = 40;
                Intellect = 10;
                Will = 5;

                HasChosenCareer = true;
            }
            else if(careerChoice == 5)
            {
                Career = "Tinker";

                Agility = 40;
                Strength = 10;
                Vigour = 30;
                Perception = 5;
                Intellect = 50;
                Will = 20;

                HasChosenCareer = true;
            }
            else
            {
                //if users choice is invalid, tell them
                Console.WriteLine("That is not a valid job option.");
            }

            //determine secondary attributes
            Awareness = Agility + Perception;
            Toughness = Strength + Vigour;
            Resolve = Intellect + Will;

            Console.ReadKey(true);

        }
    }
}
