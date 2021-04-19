using System;

namespace Textgame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 1;
            string[] inventory;
            bool dead = false;

            Console.WriteLine("Welcome to this text based adventure ADD INSTRUCTIONS HERE!!!!");

            while (health >= 1)
            {
                Console.Clear();
                Console.WriteLine("You wake up one morning to the sounds of a commotion outside.");
                Console.WriteLine("People are screaming, running and generally causing a fuss.");
                Console.WriteLine("You however, are in your comfortable bed, unsure of what's going on.");
                Console.WriteLine();
                Console.WriteLine("|=================================================================");
                Console.WriteLine("| What do you do?");
                Console.WriteLine("|=================================================================");
                Console.WriteLine("| A: Get up and see what all the fuss is about.");
                Console.WriteLine("| B: Go back to bed, it's too early for this.");
                Console.WriteLine("| C: Make a cup of tea, no point worrying about all that noise.");
                Console.WriteLine("|=================================================================");
                Console.Write("| Please select and option: ");
                string input = Console.ReadLine();
                string choice = input.ToUpper();

                /* These bools are flags that indicate when a certain scenario is finished.
                 once the scenario is complete, the bool will change to true. 
                mr 1 stands for Main Route 1, as these indicate the main route*/
                bool mr1 = false;
                bool tr1 = false;
                /*Start of mr1 - Main Route 1*/
                while (mr1 == false)
                {
                    if (choice == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("You begrudgingly decide to get up and see what all the fuss is about.");
                        Console.WriteLine("After dragging yourself out of your comfortable and warm bed, you");
                        Console.WriteLine("look out of the window to see what's happening.....");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("Zombies! there are zombies running around causing the panic and munching");
                        Console.WriteLine("on your neighbors!");
                        Console.WriteLine("");
                        Console.WriteLine("....how rude of them. There goes your plans for a relaxing day at home.");
                        Console.ReadLine();
                        mr1 = true;
                        
                    }
                    else if (choice == "B")
                    {
                        Console.Clear();
                        Console.WriteLine("You're curious about all the noise, but your bed is just way too comfortable.");
                        Console.WriteLine("You relax into a cosy position and decide to go back to sleep, what ever is");
                        Console.WriteLine("is going on out there simply isn't your problem........ zzz.....");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("It later turned out that it was your problem, as you are rudely awakened a few");
                        Console.WriteLine("hours later, by a horrifying zombie wanting to eat your brains. In your sleepy");
                        Console.WriteLine("state of mind, you have no hope of defending yourself and quickly enter the");
                        Console.WriteLine("deepest sleep of them all.");
                        Console.ReadLine();
                        dead = true;
                        health = 0;
                        mr1 = true;
                    }
                    else if (choice == "C")
                    {
                        Console.Clear();
                        Console.WriteLine("You're not concerned by alarming noises outside, your neighbors have always");
                        Console.WriteLine("been a rowdy bunch, but it is time you got out of bed.");
                        Console.WriteLine("");
                        Console.WriteLine("You groggily drag yourself out of bed and shamble into the kitchen so you can");
                        Console.WriteLine("start your day out the right way, with a lovely cup of tea. You begin to prepare");
                        Console.WriteLine("your beverage when you hear a knock at the door.");
                        /*breaking out of the loop doesn't work, it breaks out of all loops if I do that and breaks the program
                         I instead need to set the subroute flags to true, then activate the scenatios with an if true statement, 
                        rather than breaking out of this loop*/
                        tr1 = true;
                        mr1 = true;
                    }
                    else
                    {
                        Console.Write(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                    
                }
                /*End of mr1*/
                /*Start of tr1 - Tea Route 1*/
                while (tr1 == true)
                {
                    Console.Clear();
                    Console.WriteLine("This is a test to see if the Tea route works.");
                    tr1 = false;
                }
                /*End of tr1*/
                /*Start of mr2*/
                bool mr2 = false;
                while (mr2 == false)
                {
                    Console.Clear();
                    Console.WriteLine("You can't believe it, zombies running around attacking people?");
                    Console.WriteLine("no point trying to figure out how this happened. You need to");
                    Console.WriteLine("do something about this or you'll end up as a zombie's lunch!");
                    Console.WriteLine("");
                    Console.WriteLine("|=======================================================================");
                    Console.WriteLine("| What do you do?");
                    Console.WriteLine("|=======================================================================");
                    Console.WriteLine("| A: There's nothing I can do, I'm going back to sleep.");
                    Console.WriteLine("| B: If there are zombies, then I'm going to need supplies.");
                    Console.WriteLine("| C: Eh, the police will deal with this, I'll just sit down and watch");
                    Console.WriteLine("|    Sean of the dead and wait for this to blow over.");
                    Console.WriteLine("|=======================================================================");
                    Console.Write("| Please select an option:");
                    input = Console.ReadLine();
                    choice = input.ToUpper();
                        
                    if (choice == "A")
                    {

                    } 
                    else if (choice == "B")
                    {

                    }
                    else if (choice == "C")
                    {

                    }
                    else
                    {
                        Console.Write(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                }
                /*End of mr2*/

                health = 0;
            }

            if (dead == true)
            {
                Console.WriteLine("You are dead, the game is over");
            }
            else
            {
                Console.WriteLine("You Win! Good Job!");
            }

            Console.WriteLine("This is the end of the program.");
            Console.ReadLine();
        }
    }
}


/* CODE CLIPBOARD
 
 Here is the code for the option list:
while (mr2 == false)
                {                   
                    if (choice == "A")
                    {

                    } 
                    else if (choice == "B")
                    {

                    }
                    else if (choice == "C")
                    {

                    }
                    else
                    {
                        Console.Write(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                }*/