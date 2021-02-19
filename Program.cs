using System;

namespace ChooseYourStory
{
    class Program
    {
        static void Main()
        {
            string CharacterName = "";

            Console.WriteLine("Welcome to the Choose Your own Story Game!");
            Console.WriteLine("First, what is your Character's name?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Your name is " + CharacterName + "? Oh... great name... It's uh, very creative.");
            Console.Read();
        }
    }
}
