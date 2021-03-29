using System;
using System.Collections.Generic;

namespace ChooseYourStory
{
    public class Items 
    {        
        // Class not needed for now, can be used for the inventory later if desired
    }
    public class Game
    {
        string CharacterName = "blank";
        List<string> Inventory = new List<string>();
        public void Start()
        {
             /*Here add more info about the story and make it interesting and give instructions*/
            Console.WriteLine("Welcome to the Choose Your own Story Game!");
            NameCharacter();
        
            Options();
            EndGame();
        }
        void NameCharacter()
        {
            Console.WriteLine("First, what is your Character's name?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Your character's name is " + CharacterName + "? Oh... great name... It's uh, very creative.");
            Console.WriteLine("It's {0} characters long. Yes, that's right. I can count.", CharacterName.Length);
            Console.WriteLine("Alright! Let's get started. You are walking down a long path in the woods. \nWhy are you in the woods? I don't know. It just seems like the place where you can usually find stuff.");
        }

        int DoingSomeMath(int x, int y)
        {
            return x + y;
        }
        void Options()
        {
            Console.WriteLine("Press Q to quit! Or anything else to continue. ");
            var option = Console.ReadLine(); 
            while (option != "Q") /*Find a way to make it so that the q can be upper or lower case*/
            {
            string input = "";
            /*Fix this line later, make it interesting*/
            Console.WriteLine("You come across a big lake with a bridge. Which way will you go? \nYou can go east, which is towards the sun. It might hurt your eyes, but you get some uh points for being brave. \nYou can go across the bridge, which is old but theres a tree on the other side that looks rather normal. \nYou can go west, which has some mushrooms. That could be cool. \nOr you can go backwards. I don't know what's back there but you were just there so you know. \nChoose one. Type A for eAst, Type B for Bridge. Type C for westC and type D for backwarDs.");
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "A")
            {
                Console.WriteLine ("You go east, wow that sun is bright. You lose your vision but you walk into a treasure chest. \nUsing your now heightened sense of touch, you open it. Congrats, you found the Holy Grail!");
                Inventory.Add("Holy Grail");
                Console.WriteLine ("Good job!");
            }
            else if (input == "B")
            {
                Console.WriteLine ("You cross the bridge. The tree is indeed just a normal tree. \nIt has an apple though. Congrats, you get an apple!");
                Inventory.Add("apple");
                Console.WriteLine ("Not bad!");
            }
            else if (input == "C")
            {
                Console.WriteLine ("You go west near the mushrooms.");
                Console.WriteLine ("Uhh, you found nothing. But, don't give up. Remember that LOTR quote?");
                Inventory.Add("Nothing");
                /*This pulls a quote from quote.txt file*/
                string text = System.IO.File.ReadAllText(@"quote.txt");
                Console.WriteLine("{0}", text);
                Console.WriteLine("Yeah, that one. You can be like that.");
            }
            else if (input == "D")
            {
                Console.WriteLine ("You go backwards. Congrats, you found a dragon that wants to eat your face!");
                Inventory.Add("Face eating dragon.");
                Console.WriteLine ("Yikes.");
            }
            else
            {
                Console.WriteLine ("Dude, that wasn't one of the options. Fine. You found a piece of paper that says that you are an idiot");
                Inventory.Add("piece of paper that says you are an idiot");
                Console.WriteLine ("Idiot. Also, here's a number because I'm just trying out some code stuff. You can ignore it.");
                Console.WriteLine(DoingSomeMath(5,3));
            }
        Console.WriteLine("Do you want to continue? Press any key to continue or Q to quit.");
        option = Console.ReadLine();
            }
        }
        public void EndGame()
        {
            Console.WriteLine("Well, this is the end. It wasn't very long but hopefully you learned something.");
            Console.WriteLine("Here is what you discovered on your journey:");

            foreach (string item in Inventory)
            {
                Console.WriteLine(item);
            }
            
        }
  
    }
    class Program
    {
        static void Main()
        {
            var Game = new Game();
            Game.Start();
            Console.ReadKey();
        }
    }
}
