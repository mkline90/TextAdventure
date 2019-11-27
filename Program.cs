using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace textAdventure
{
    class MainClass
    {
        static void Slow_It(int milsec_delay, string str)
        {
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(milsec_delay);

            }
        }

        public static void Main(string[] args)
        {
            GameTitle();
        }

        public static void GameTitle()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Slow_It(40, "Welcome to Santa's Christmas Adventure!\nPress 'Enter' to begin");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            First();
        }

        public static void First()
        {
            string choice;
            string cookie;
            string action;
            
            Slow_It(40,"Good morning Santa! You have a big day ahead of you...\n" +
                "It's Christmas Eve, what would you like to do first?\n" +
                "1. Feed the Reindeers\n" +
                "2. Mess with Elves\n" +
                "3. Sleigh Ride\n" +
                "Choice: ");

            Console.WriteLine();
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "feed":
                case "feed the reindeers":
                    {
                        Slow_It(40,"You walk outside where all of your reindeer run joyfully towards you\n" +
                            "Dancer, Prancer, Vixen.... uh what's his name....\n" +
                            "RUDOLPH!\n" +
                            "Yeah, all the reindeers love Santa...\n" +
                            "Their love doesn't last long \nThey soon discover that Santa has eaten all their treats\n" +
                            "Their eyes begin to fill with bloodthirsty rage\n" +
                            "Santa can either run to his sleigh, or fight them off\n" +
                            "1. Run\n" +
                            "2. Fight\n" +
                            "Choice: ");
                        Console.WriteLine();
                        action = Console.ReadLine().ToLower();
                        switch (action)
                        {
                            case "1":
                            case "run":
                                Slow_It(40,"Santa escapes the vicious reindeer and heads towards the North Pole Bar\n" +
                                    "Press 'Enter' to continue");
                                Console.WriteLine();
                                Console.ReadLine();
                                Console.Clear();
                                Second();
                                break;

                            case "2":
                            case "fight":
                                Slow_It(40,"Santa is pummeled to near death by the only creatures he ever truly loved\n" +
                                    "Press 'Enter' to continue");
                                Console.WriteLine();
                                Console.ReadLine();
                                Console.Clear();
                                GameOver();
                                break;

                            default:

                                Slow_It(40,"I dont understand that command.\n" +
                                    "Press 'Enter' to try again");
                                Console.WriteLine();
                                Console.ReadLine();
                                Console.Clear();
                                First();
                                break;
                        }
                        Console.ReadLine();
                        Second();
                        break;

                    }

                case "2":
                case "mess":
                    {

                        Slow_It(40,"Santa walks to the toy factory where all the elves are hard at work.\n" +
                            "Santa sees a plate of cookies sitting unattended on a nearby table\n" +
                            "There's only two things Santa can think of doing with them\n" +
                            "Which does Santa choose?\n" +
                            "1. Eat the Cookies\n" +
                            "2. Chuck cookies at the elves\n" +
                            "Choice: ");
                        Console.WriteLine();
                        cookie = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (cookie)
                        {
                            case "1":
                            case "eat":
                            case "eat the cookies":
                                Slow_It(40,"Santa eats some cookies\n" +
                                    "Santa eats ALL the cookies\n" +
                                    "Santa is thirsty..\n" +
                                    "Santa decides to let the elves finish their work\n" +
                                    "He heads to the North Pole Bar\n" +
                                    "Press 'Enter' to continue");
                                Console.WriteLine();
                                Console.ReadLine();
                                Console.Clear();
                                Second();
                                break;

                            case "2":
                            case "chuck cookies":
                            case "chuck":

                                Slow_It(40,"The elves are mercilessly pelted by cookies\n" +
                                    "The elves cry out 'Please stop Santa... please!!!'\n" +
                                    "Press 'Enter' to continue");
                                Console.WriteLine();
                                Console.ReadLine();
                                Console.Clear();
                                GameOver();
                                break;

                            default:

                                Slow_It(40,"I dont understand that command.\n" +
                                    "Press 'Enter' to try again");
                                Console.WriteLine();
                                Console.ReadLine();
                                Console.Clear();
                                First();
                                break;

                        }

                    }
                        Console.ReadLine();
                        Second();
                        break;
                case "3":
                case "sleigh":
                case "sleigh ride":
                    {
                        Slow_It(40,"Santa hops on his sleigh and takes a leisurely flight around the North Pole\n" +
                            "Everything seems to be in tip-top shape!\n" +
                            "Press 'Enter' to continue");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        Second();
                        break;
                    }
                default:
                    {
                        Slow_It(40,"I dont understand that command.\n" +
                            "Press 'Enter' to try again");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        First();
                        break;
                    }
            }
        }

        public static void Second()
        {
            // Created an arrray with 3 different options
            // Random pull of index from array
            Random rnd = new Random();
            string[] secOptions = {"Santa is feeling parched.. what would quench his thirst..",
            "The reindeers do most of the navigating anyways.. a cocktail wouldn't hurt", "Santa needs something to take the edge off.."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            // Output what is in secText variable
            Console.WriteLine(secText);
            Slow_It(40,"Would you like to drink some spiked eggnog:\n" +
                "Yes (y)\n" +
                "No (n)\n" +
                "Choice: ");
            Console.WriteLine();
            secChoice = Console.ReadLine().ToLower();

            // Conditional for yes/no or if they dont enter either
            if (secChoice == "yes" || secChoice == "y")
            {
                Third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Slow_It(40,"That's probably a good decison\n" +
                    "Press 'Enter' to continue");
                Console.WriteLine();
                Console.ReadLine();
                YouWin();
            }
            else
            {
                Slow_It(40,"I dont understand that command.\n" +
                    "Press 'Enter' to try again");
                Console.WriteLine();
                Console.ReadLine();
                Second();
            }
        }

        public static void Third()
        {
            string deliver;
            int eggnog;
            Slow_It(40,"Santa joyfully cozy ups to the Bar\n" +
                "He orders an Eggnog on the rocks\n" +
                "Suddenly, the door opens.\n" +
                "UH-OH... Mrs. Clause does not look happy\n" +
                "'It's Christmas Eve for heaven's sake!' Santa's wife exclaims\n" +
                "How many drinks have you had today, Santa?\n" +
                "Drinks: ");
            Console.WriteLine();
            int.TryParse(Console.ReadLine(), out eggnog);

            while (eggnog < 10)
            {
                Slow_It(40,"Seriously? There's a lot of empty bottles on the floor\n" +
                    "How many have you really drank?\n" +
                    "Drinks: ");
                int.TryParse(Console.ReadLine(), out eggnog);
            }
            Slow_It(40,"Wow! Maybe you should slow down!\n" +
             "It's time to deliver those presents\n" +
             "What do you think?\n" +
             "1. Deliver Presents\n" +
             "2. Keep Drinking");
            Console.WriteLine();
            deliver = Console.ReadLine().ToLower();
            Console.Clear();

            switch (deliver)
            {
                case "1":
                case "deliver":
                    Slow_It(40,"Santa finishes his drink and walks to the sleigh\n" +
                    "Santa has a long night ahead of him of delivering toys across the world\n" +
                    "Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.WriteLine();
                    YouWin();
                    break;

                case "2":
                case "drink":
                    Slow_It(40, "Santa orders up another round of eggnog\n" +
                        "There's no telling when he'll stop now\n" +
                        "Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.WriteLine();
                    GameOver();
                    break;

            }
        }

        public static void GameOver()
        {
            Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.BackgroundColor = ConsoleColor.Green;
            Slow_It(40, "You've ruined Christmas!\n" +
                "We'll have to find a better Santa next year!\n" +
                "Press 'Enter' to try again");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
            GameTitle();
        }

        public static void YouWin()
        {
            Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.BackgroundColor = ConsoleColor.Green;
           Slow_It(40,"All the presents were delivered on time\n" +
                "Great Job Santa! Christmas was a huge success!\n" +
                "Press 'Enter' to play again");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
            GameTitle();
        }
    }
}
