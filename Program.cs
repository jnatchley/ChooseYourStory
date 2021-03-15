using System;
using System.Collections.Generic;

namespace ChooseYourStory
{
    /*figure out how to include this list*/
    public class Items 
    {        
        List<string> items = new List<string>();
    
    }
    public static class Game
    {
        static string CharacterName = "blank";
        
        public static void Start()
        {
             /*Fix this line later, add more info about the story and make it interesting and give instructions*/
            Console.WriteLine("Welcome to the Choose Your own Story Game!");
            NameCharacter();
            Options();
            /*I need to break this off and end it, something like End(), and the option to finish earlier?*/
        }
        static void NameCharacter()
        {
            Console.WriteLine("First, what is your Character's name?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Your character's name is " + CharacterName + "? Oh... great name... It's uh, very creative.");
            Console.WriteLine("It's {0} characters long. Yes, that's right. I can count.", CharacterName.Length);
            /*Maybe analyze the text(name) here in some way?*/
        }
        /*Pick up a random object here? From a list?*/
        static void Options()
        {
            string input = "";
            /*Fix this line later, make it interesting*/
            Console.WriteLine("You gotta go to either A, B, C, D. Choose one.");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Console.WriteLine ("Blah Blah Good ending");
            }
            else if (input == "B")
            {
                Console.WriteLine ("Blah blah Good Ending 2");
            }
            else if (input == "C")
            {
                Console.WriteLine ("Weird Ending");
                /*This pulls a quote from quote.txt file*/
                string text = System.IO.File.ReadAllText(@"quote.txt");
                Console.WriteLine("{0}", text);
            }
            else if (input == "D")
            {
                Console.WriteLine ("Bad Ending");
            }
            else
            {
                Console.WriteLine ("What are you doing ending");
            }

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
