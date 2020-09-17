using System;

namespace Choose_Your_Own_Adventure
{
    class Program
    {
        static Random randomObject = new Random();
        static void Main(string[] args)
        {

           




            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();
            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
            Console.WriteLine("It Started on a cloudy night. Your with the boys, playing games, vibin and having fun, and you see something down the hall. Do you go investigate");

            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();

            if (noiseChoice == "NO")
            {
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                Console.WriteLine("what, are you scared or something, go check it out.");
                Console.WriteLine("THE END.");
            }
            else if (noiseChoice == "YES")
            {
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                Console.WriteLine("You walk into the hallway and see a figure standing at end of it.");
                Console.WriteLine("You think your eyes are deceving you, do you tell the boys?");

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                Console.Write("Type YES or NO: ");
                string choice1 = Console.ReadLine();
                choice1 = choice1.ToUpper();
                Console.WriteLine(choice1);

                if (choice1 == "YES")
                {
                    Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                    Console.WriteLine("Boys, i think i saw something down the hall.");
                    Console.WriteLine("-Nervously you sit down and proceed to say-");
                    Console.WriteLine("It sorta looked like a figure, like someone was standing their.");
                    Console.WriteLine("-Boys continue to game, thinking about what i had said-");

                }
                else if (choice1 == "NO")
                {
                    Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                    Console.WriteLine("Sorry about that boys, Thought i saw something, anyways pass me the controller.");
                    Console.WriteLine("THE END");
                }

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                Console.WriteLine("Yo boys");
                Console.Write("Pick a number (1-3): ");
                string keyChoice = Console.ReadLine();
                keyChoice = keyChoice.ToUpper();

                switch (keyChoice)
                {
                    case "1":
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("Were gonna play a little game, let's see whos up first, pick another number.");
                        break;
                    case "2":
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("That means we gotta switch this to Modern Warfare and run this 1v1");
                        Console.WriteLine("-Tristian Whoops their ...-");
                        Console.WriteLine("THE END");
                        break;
                    case "3":
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("3 Means, were going to PopEyes to pick up 8 original sandwhiches");
                        Console.WriteLine("-The Boys Say-");
                        Console.WriteLine("Why original the spicy is wayyyyy better");
                        Console.WriteLine("THE END");
                        break;

                    case "default":
                        Console.WriteLine("THE END");
                        break;
                }

                string one = "jacob";
                string two = "keith";
                string three = "bobby";
                string four = "jamagiae";

                

                Console.Write("this time one, two, three or four: ");
                string theBoys = Console.ReadLine();


                switch (theBoys)
                {
                    case "one":
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("Looks like your up Jacob");
                        break;

                    case "two":
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("Looks like your up Keith");
                        break;

                        
                    case "three":
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("Looks like your up Bobby");
                        break;

                    case "four":
                        Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                        Console.WriteLine("Looks like your up Jamagiae");
                        break;

                    case "default":
                        Console.WriteLine("THE END.");
                            break;
                }
               
            }
        }
    }
}
