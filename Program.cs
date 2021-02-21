using System;

namespace ChooseYourStory
{
    public static class Game
    {
        static string CharacterName = "blank";
        
        public static void Start()
        {
            Console.WriteLine("Welcome to the Choose Your own Story Game!");
            NameCharacter();
        }
        static void NameCharacter()
        {
            Console.WriteLine("First, what is your Character's name?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Your name is " + CharacterName + "? Oh... great name... It's uh, very creative.");
        }

    }
    class Program
    {
        static void Main()
        {
            Game.Start();
            Console.ReadKey();
        }
    }
}
