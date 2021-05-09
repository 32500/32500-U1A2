using System;
using System.Linq;

namespace Textgame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 1;
            string[] inventory = {"blank"};
            bool dead = false;


            Console.WriteLine("Welcome to this text based adventure!");
            Console.WriteLine("");
            Console.WriteLine("In this game, you will be presented with a scenario, and then you");
            Console.WriteLine("will be given three options, A, B, And C. to select an option, type");
            Console.WriteLine("the corresponding letter, then press enter!");
            Console.WriteLine("");
            Console.WriteLine("If the program stops at any point and there are no options provided,");
            Console.WriteLine("please press the enter key to continue.");
            Console.WriteLine("");
            Console.WriteLine("When you are ready to begin, press the enter key.");
            Console.ReadLine();

            while (health <= 1)
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
                        Console.ReadLine();
                        Console.WriteLine("Zombies! there are zombies running around causing the panic and munching");
                        Console.WriteLine("on your neighbours!");
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
                        Console.WriteLine("You're not concerned by alarming noises outside, your neighbours have always");
                        Console.WriteLine("been a rowdy bunch, but it is time you got out of bed.");
                        Console.WriteLine("");
                        Console.WriteLine("You groggily drag yourself out of bed and shamble into the kitchen so you can");
                        Console.WriteLine("start your day out the right way, with a lovely cup of tea. You begin to prepare");
                        Console.WriteLine("your beverage when you hear a knock at the door.");
                        Console.ReadLine();
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
                if (health == 0) 
                {
                    break;
                }
                /*End of mr1*/
                /*Start of tr1 - Tea Route 1*/
                while (tr1 == true)
                {
                    Console.Clear();
                    Console.WriteLine("Who could be knocking at a time like this? surely no one would");
                    Console.WriteLine("be making a social call at a time like this. Maybe you should");
                    Console.WriteLine("answer it and give this fool a piece of your mind.");
                    Console.WriteLine("");
                    Console.WriteLine("|========================================================");
                    Console.WriteLine("| What do you do?");
                    Console.WriteLine("|========================================================");
                    Console.WriteLine("| A: I'm going to see who is at the door.");
                    Console.WriteLine("| B: They'll go away eventually, time to enjoy my tea.");
                    Console.WriteLine("| C: I'll give them a talking to from in here.");
                    Console.WriteLine("|========================================================");
                    Console.Write("| Please select an option: ");
                    input = Console.ReadLine();
                    choice = input.ToUpper();
                    while (tr1 == true)
                    {
                        if (choice == "A")
                        {
                            Console.Clear();
                            Console.WriteLine("Well if someone is knocking at the door it would be rude to");
                            Console.WriteLine("ignore them, even if they are being foolish.");
                            Console.WriteLine("");
                            Console.WriteLine("You put down your tea and open the door to see a door to door");
                            Console.WriteLine("vacuume salesman, you didn't think that they actually existed.");
                            Console.WriteLine("");
                            Console.WriteLine("After greeting the salesman, you quickly realise that this");
                            Console.WriteLine("salesman is of the undead variety, and sadly he attacks you");
                            Console.WriteLine("before you can slam the door. And even more unfortunately, you");
                            Console.WriteLine("never got to finish your tea, and it is doomed to go cold and");
                            Console.WriteLine("un-drunk on your kitchen counter for the rest of time.");
                            Console.ReadLine();
                            dead = true;
                            health = 0;
                            tr1 = false;
                        }
                        else if (choice == "B")
                        {
                            Console.Clear();
                            Console.WriteLine("There's no point in answering the door, it's probably a zombie");
                            Console.WriteLine("anyway. You decide to ignore the banging and enjoy your freshly");
                            Console.WriteLine("brewed tea.");
                            Console.WriteLine("");
                            Console.WriteLine("However this turned out to be the wrong decision as a particularly");
                            Console.WriteLine("angry looking zombie eventually bursts through the door and lurches");
                            Console.WriteLine("at you. The zombie did not like being ignored for so long and bites");
                            Console.WriteLine("you with malice. At least you managed to enjoy your tea before you");
                            Console.WriteLine("joined the undead.");
                            dead = true;
                            health = 0;
                            tr1 = false;
                        }
                        else if (choice == "C")
                        {
                            /*yell at zombies, win*/
                            Console.Clear();
                            Console.WriteLine("Some people have no sense and it angers you that someone would venture");
                            Console.WriteLine("out in a zombie invasion to interupt your tea time. You angrilly walk");
                            Console.WriteLine("up to the front door and yell many harsh words at this idiotic invader.");
                            Console.WriteLine("");
                            Console.WriteLine("You have no time to deal with whatever nonsense they want right now and");
                            Console.WriteLine("quite frankly, they have better things to be doing right now than popping");
                            Console.WriteLine("over for a chat.");
                            Console.WriteLine("");
                            Console.WriteLine("After a long and angry rant, you hear some rather disheartened sounding");
                            Console.WriteLine("footsteps echoing throughout your driveway. You get a glimpse of who it");
                            Console.WriteLine("was as they pass a nearby window and you see a zombie sulking away with");
                            Console.WriteLine("what appears to be tears running down its face. You feel slightly guilty");
                            Console.WriteLine("about making a zombie cry.");
                            health = 0;
                            tr1 = false;
                        }
                        else
                        {
                            Console.Write(choice + " is not a valid option, please try again: ");
                            input = Console.ReadLine();
                            choice = input.ToUpper();
                        }
                    }

                    Console.ReadLine();
                    tr1 = false;
                }
                if (health == 0) 
                {
                    break;
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
                    Console.Write("| Please select an option: ");
                    input = Console.ReadLine();
                    choice = input.ToUpper();
                        
                    if (choice == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("You decide that there's nothing you can do, and you were");
                        Console.WriteLine("enjoying your sleep. You decide to go back to bed and have");
                        Console.WriteLine("a peaceful sleep.");
                        Console.WriteLine("");
                        Console.WriteLine("However, because you were sleeping so soundly, you didn't");
                        Console.WriteLine("hear the zombies break in! you awake to the sight of a");
                        Console.WriteLine("terifying zombie looming above you, and it's too late to run");
                        Console.WriteLine("away.");
                        Console.ReadLine();
                        dead = true;
                        health = 0;
                        mr2 = true;
                    } 
                    else if (choice == "B")
                    {
                        Console.Clear();
                        Console.WriteLine("You can't survive the apocalypse in your pyjamas! it's time to");
                        Console.WriteLine("search for supplies.");
                        Console.ReadLine();
                        mr2 = true;
                    }
                    else if (choice == "C")
                    {
                        Console.Clear();
                        Console.WriteLine("All of these zombies are making you nostalgic for zombie movies.");
                        Console.WriteLine("Going outside seems like a bad idea so you decide to get out");
                        Console.WriteLine("your film collection from storage and have an old fashioned");
                        Console.WriteLine("movie day.");
                        Console.WriteLine("");
                        Console.WriteLine("You make yourself comfortable on the sofa and settle down to");
                        Console.WriteLine("enjoy this golden opportunity, if only the apocalypse outside");
                        Console.WriteLine("would keep it down a bit.");
                        Console.WriteLine("");
                        Console.WriteLine("The occasional banging at the door inturupts your film day but");
                        Console.WriteLine("simply telling the zombies to go away seems to work for some");
                        Console.WriteLine("reason. Eventually after a full day of binging movies you feel");
                        Console.WriteLine("slightly disgusting from not moving all day. As you get up to");
                        Console.WriteLine("prepare for sleep, you see that the military has shown up to");
                        Console.WriteLine("deal with this zombie nonsense. Seems like you'll have to go to");
                        Console.WriteLine("work tomorrow after all.");
                        Console.ReadLine();
                        health = 0;
                        mr2 = true;
                    }
                    else
                    {
                        Console.Write(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                }
                if (health == 0)
                {
                    break;
                }
                /*End of mr2*/
                /*Start of mr3*/
                bool mr3 = false;
                while (mr3 == false)
                {
                    Console.Clear();
                    Console.WriteLine("You scramble to take stock of what supplies you have available.");
                    Console.WriteLine("Barricading the house and laying low seems like the best idea");
                    Console.WriteLine("but you've been putting off food shopping for a week and you have");
                    Console.WriteLine("no food! If you stay here you'll starve before help arrives.");
                    Console.WriteLine("");
                    Console.WriteLine("There's no doubt about it, you'll have to brave the horde and");
                    Console.WriteLine("gather supplies. But you don't have time to plan an expedition,");
                    Console.WriteLine("you need to be quick, and focus on what kind of equiptment you need.");
                    Console.WriteLine("");
                    Console.WriteLine("|====================================================================");
                    Console.WriteLine("| What do you do?");
                    Console.WriteLine("|====================================================================");
                    Console.WriteLine("| A: I'll have to fight through the zombies, I need combat gear.");
                    Console.WriteLine("| B: I'll have to be smart, I need survival equiptment.");
                    Console.WriteLine("| C: I'm just popping to the shops, keys and wallet are all I need.");
                    Console.WriteLine("|====================================================================");
                    Console.Write("| Please select and option: ");
                    input = Console.ReadLine();
                    choice = input.ToUpper();
                    if (choice == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("If TV has taught you anything, it's how to take down a zombie!");
                        Console.WriteLine("You decide that the best way to deal with this problem is");
                        Console.WriteLine("through brute force and head straight for your gun collection.");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("....Or at least you would, if you had one, but this is Britain");
                        Console.WriteLine("so you'll have to improvise.");
                        Console.WriteLine("");
                        Console.WriteLine("After a quick brainstorming session you manage to cobble together");
                        Console.WriteLine("the best combat equipment 15 minutes and a roll of duct tape");
                        Console.WriteLine("can buy. You have creatively crafted a sort of plate armour out of");
                        Console.WriteLine("baking trays and cooking pans, and you have armed yourself with a");
                        Console.WriteLine("pitchfork you had lying around, if it worked for medieval peasants");
                        Console.WriteLine(" it will work for you.... you hope.");
                        Console.WriteLine("");
                        Console.WriteLine("With this gear and as much false confidence you can muster, you");
                        Console.WriteLine("feel prepared to brave the horde.");
                        Console.WriteLine("");
                        inventory = new string[] { "combat gear" };
                        Console.WriteLine("'Combat Gear' has been added to your inventory!");
                        Console.ReadLine();
                        mr3 = true;
                    }
                    else if (choice == "B")
                    {
                        Console.Clear();
                        Console.WriteLine("Zombie infested streets are a dangerous environment, and what you");
                        Console.WriteLine("remember from that one episode of Bear Grylls that you watched a");
                        Console.WriteLine("few years back, having good equiptment is vital for your survival!");
                        Console.WriteLine("");
                        Console.WriteLine("Quickly searching through some old camping equipment you have");
                        Console.WriteLine("stored away, you manage to grab a quality back pack and stuff");
                        Console.WriteLine("it full of various survival supplies including a tent, some water,");
                        Console.WriteLine("the last of your food, lots of rope, and a pen knife. These");
                        Console.WriteLine("zombies won't be able to get to you now, and you're ready for your");
                        Console.WriteLine("trip to the shops.");
                        Console.WriteLine("");
                        inventory = new string[] { "survival gear" };
                        Console.WriteLine("'Survival Gear' has been added to your inventory!");
                        Console.ReadLine();
                        mr3 = true;
                    }
                    else if (choice == "C")
                    {
                        Console.Clear();
                        Console.WriteLine("These zombies can't be any worse than black Friday shoppers, and");
                        Console.WriteLine("you didn't need to dress for the apocalypse to snag a discounted");
                        Console.WriteLine("TV, so why would you need it now? You pick up your wallet, keys,");
                        Console.WriteLine("and a re-usable shopping bag. You now feel sufficiently prepared");
                        Console.WriteLine("for a trip to the shops.");
                        Console.WriteLine("");
                        inventory = new string[] { "shopping gear" };
                        Console.WriteLine("'Shopping Gear' has been added to your inventory!");
                        Console.ReadLine();
                        mr3 = true;
                    }
                    else
                    {
                        Console.WriteLine(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                }
                /*End of mr3*/
                if (health == 0)
                {
                    break;
                }
                /*Start of mr4*/
                bool mr4 = false;
                while (mr4 == false)
                {
                    Console.Clear();
                    Console.WriteLine("With all the gear you need at the ready, you head out on your quest");
                    Console.WriteLine("to do a food shop. You lock up the house and take a quick peak into");
                    Console.WriteLine("the street.");
                    Console.WriteLine("");
                    Console.WriteLine("Thankfully most of the zombies appear to have wandered off to greener");
                    Console.WriteLine("pastures. However upon spotting your car parked out front, you see that");
                    Console.WriteLine("your neighbor, Greg, seems to have joined in on the zombie trend and is");
                    Console.WriteLine("currently gnawing on your wing mirror with an unhealthy looking green");
                    Console.WriteLine("complection. Poor Greg, he was a good neighbour.");
                    Console.WriteLine("");
                    Console.WriteLine("|=================================================================");
                    Console.WriteLine("| What do you do?");
                    Console.WriteLine("|=================================================================");
                    Console.WriteLine("| A: Greg seems to be distracted, I think I'll just walk.");
                    Console.WriteLine("| B: I need my car, I'll have to fight.");
                    Console.WriteLine("| C: It would be rude to ignore Greg, I'll pop over and say hi.");
                    Console.WriteLine("|=================================================================");
                    Console.Write("| Please select and option: ");
                    input = Console.ReadLine();
                    choice = input.ToUpper();
                    if (choice == "A")
                    {
                        /*Walk to shop option*/
                        Console.Clear();
                        Console.WriteLine("Greg seems to be the only zombie around and he looks pretty");
                        Console.WriteLine("distracted. Fighting the undead doesn't appeal to you right");
                        Console.WriteLine("now so you decide to leave Greg be and walk to the shops.");
                        Console.WriteLine("They're not that far away and a car will probably just draw");
                        Console.WriteLine("attention to yourself anyway.");
                        Console.WriteLine("");
                        Console.WriteLine("After walking for a little bit, you realise that this was the");
                        Console.WriteLine("best option as the road is blocked up with other cars that have");
                        Console.WriteLine("crashed into eachother. It seems like the apocalypse made");
                        Console.WriteLine("everyone forget how to drive.");
                        Console.ReadLine();
                        mr4 = true;
                    }
                    else if (choice == "B")
                    {
                        /*Fight zombie option*/
                        Console.Clear();
                        Console.WriteLine("You're not walking through a zombie infestation, and Greg isn't");
                        Console.WriteLine("your neighbour any more, he's a minion of the undead now. Sorry");
                        Console.WriteLine("Greg, but it's time to fight!");
                        Console.WriteLine("");
                        if (inventory.Contains("combat gear"))
                        {
                            Console.WriteLine("Picking up combat gear was a good idea. You grip tightly on your");
                            Console.WriteLine("pitchfork and prepare for battle!");
                            Console.WriteLine("");
                            Console.WriteLine("As you approach the undead fiend Greg takes notice of you and");
                            Console.WriteLine("begins to hobble towards you with villainous intent. Thankfully");
                            Console.WriteLine("you are prepared for this and charge Greg with all of your might");
                            Console.WriteLine("taking him down easily in one well placed strike.");
                            Console.ReadLine();
                            Console.WriteLine("You feel bad for ending Greg, but he probably wasn't enjoying");
                            Console.WriteLine("zombification and you have now secured a safe transport to the");
                            Console.WriteLine("shops. You turn the keys and your car roars into life, you prepare");
                            Console.WriteLine("to set off, however you quickly stop as the street is blocked with");
                            Console.WriteLine("other cars that have somehow all crashed into eachother. Driving");
                            Console.WriteLine("through this is impossible, it looks like you'll have to walk after");
                            Console.WriteLine("all. This was a waste of time.");
                            Console.ReadLine();
                            mr4 = true;
                        }
                        else if (inventory.Contains("survival gear"))
                        {
                            Console.WriteLine("It's a good think you picked up a survival knife, normally a knife");
                            Console.WriteLine("should never be used on another person, but Greg isn't really a");
                            Console.WriteLine("person any more so it should be okay.");
                            Console.WriteLine("");
                            Console.WriteLine("Being smart is important here, so you decide to distract Greg by");
                            Console.WriteLine("throwing a small rock at another car, causing Greg to turn away from");
                            Console.WriteLine("you and shuffle away. You slowly sneak up behind Greg and use this");
                            Console.WriteLine("opportunity to strike!");
                            Console.WriteLine("");
                            Console.WriteLine("Turns out that knife fighting is harder than you thought as your first");
                            Console.WriteLine("attack seems to do nothing but gain Greg's attention, you think you're a");
                            Console.WriteLine("gonner as Greg manages to grab your arm. Thankfully you manage to get in");
                            Console.WriteLine("a quick second strike before Greg can get his jaws on you and he goes down");
                            Console.WriteLine("making you the victor!");
                            Console.ReadLine();
                            Console.WriteLine("You feel bad for ending Greg, but he probably wasn't enjoying");
                            Console.WriteLine("zombification and you have now secured a safe transport to the");
                            Console.WriteLine("shops. You turn the keys and your car roars into life, you prepare");
                            Console.WriteLine("to set off, however you quickly stop as the street is blocked with");
                            Console.WriteLine("other cars that have somehow all crashed into eachother. Driving");
                            Console.WriteLine("through this is impossible, it looks like you'll have to walk after");
                            Console.WriteLine("all. This was a waste of time.");
                            Console.ReadLine();
                            mr4 = true;
                        }
                        else
                        {
                            Console.WriteLine("You weren't really expecting to actually fight anyone but it looks like");
                            Console.WriteLine("you have no choice. You ready your fists and run towards Greg hoping to");
                            Console.WriteLine("take him down with one punch. When you're in range you charge up as much");
                            Console.WriteLine("power as you can and launch a punch straight into Greg's face!");
                            Console.ReadLine();
                            Console.WriteLine("...Which turned out to be a terrible idea since your fist is now practically");
                            Console.WriteLine("in a zombies mouth. As you can imagine, Greg takes advantage of this and is");
                            Console.WriteLine("now enjoying some literal finger food. It doesn't take long for things to");
                            Console.WriteLine("get worse and you soon become a zombie yourself, and decide to join Greg in");
                            Console.WriteLine("trying to eat your own car for the rest of time.");
                            Console.ReadLine();
                            dead = true;
                            health = 0;
                            mr4 = true;
                        }
                    }
                    else if (choice == "C")
                    {
                        Console.Clear();
                        Console.WriteLine("Greg has always been a friendly neighbour, ignoring him would be rude,");
                        Console.WriteLine("even if he is a zombie now. You decide to casually saunter over to");
                        Console.WriteLine("Greg and say hello, exclaiming how crazy it is that there are zombies");
                        Console.WriteLine("running around. Greg simply responds with some groaning and a vaugley");
                        Console.WriteLine("audiable \"brainzzzz\" before promptly pouncing on you in a zombie");
                        Console.WriteLine("like way.");
                        Console.WriteLine("");
                        Console.WriteLine("Perhaps trying to be friendly with a zombie was a bad idea.");
                        Console.ReadLine();
                        dead = true;
                        health = 0;
                        mr4 = true;
                    }
                    else
                    {
                        Console.WriteLine(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                }
                if (health == 0)
                {
                    break;
                }
                /*End of mr4*/
                /*Start of mr5*/
                bool mr5 = false;
                while (mr5 == false)
                {
                    Console.Clear();
                    Console.WriteLine("You continue on your journey to the shop, dipping into neighbouring");
                    Console.WriteLine("gardens to hide from clusters of zombies along the way.");
                    Console.WriteLine("");
                    Console.WriteLine("Eventually you manage to get to the shop with relative ease and");
                    Console.WriteLine("catiously enter the building. Looking around and moving stealthily");
                    Console.WriteLine("you see a handful of zombies shambling around aimlessly through the");
                    Console.WriteLine("isles.");
                    Console.WriteLine("");
                    Console.WriteLine("You also spot a single cashier still working behind the till and");
                    Console.WriteLine("approach him carefully.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("After approaching the cashier, you see that he is not looking well,");
                    Console.WriteLine("he is sweating exessively and is looking rather pale, he also appears");
                    Console.WriteLine("to have several bite marks on his arms. After noticing you approach");
                    Console.WriteLine("he greats you in the most cheerful voice he can muster.");
                    Console.WriteLine("");
                    Console.WriteLine("\"Hello and welcome to Shop Mart, how can I serve you today?\"");
                    Console.WriteLine("");
                    Console.WriteLine("The cashier notes the concern in your expression and waves it off");
                    Console.WriteLine("with a smile.");
                    Console.WriteLine("");
                    Console.WriteLine("\"Don't worry about these bites, I can't afford to be ill so as");
                    Console.WriteLine("long as I'm on the clock, I won't turn into a zombie. I don't");
                    Console.WriteLine("think the govenrment will accept becoming undead as a valid excuse");
                    Console.WriteLine("for skipping payments on my student loan\" the cashier laughs");
                    Console.WriteLine("weakly and holds his smile.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You explain that you want to buy some food so you can wait out the");
                    Console.WriteLine("zombies at home");
                    Console.WriteLine("");
                    Console.WriteLine("\"I can help with that, in fact, another shopper left their food here");
                    Console.WriteLine("after getting jumpped by a zombie, I can sell you this stuff if you can");
                    Console.WriteLine("pay for it\"");
                    Console.WriteLine("");
                    Console.WriteLine("The cashier shows you several bags of food that are available for purchase.");
                    Console.WriteLine("|==================================================================");
                    Console.WriteLine("| What do you do?");
                    Console.WriteLine("|==================================================================");
                    Console.WriteLine("| A: I would like to buy that food shopkeep!");
                    Console.WriteLine("| B: You should really see a doctor kid.");
                    Console.WriteLine("| C: Why do I need to pay for it? there's an apocalypse going on.");
                    Console.WriteLine("|==================================================================");
                    Console.Write("| Please select and option: ");

                    input = Console.ReadLine();
                    choice = input.ToUpper();
                    if (choice == "A")
                    {
                        Console.Clear();
                        if (inventory.Contains("shopping gear"))
                        {
                            Console.WriteLine("This is perfect! you don't even need to browse around looking for");
                            Console.WriteLine("what you want. You pull out your wallet and skillfully use it to");
                            Console.WriteLine("purchase the bags of food.");
                            Console.WriteLine("");
                            Console.WriteLine("After thanking the cashier and wishing him a good day, you return");
                            Console.WriteLine("home and unpack the impressive supply of food. Feeling confident in");
                            Console.WriteLine("you ability to survive this disaster, you secure the house and relax,");
                            Console.WriteLine("The government will sort this out eventually, you can focus on having");
                            Console.WriteLine("a much deserved break.");
                            Console.ReadLine();
                            health = 0;

                        }
                        else 
                        {
                            Console.WriteLine("This is perfect! you don't even need to browse around looking for");
                            Console.WriteLine("what you want. You reach for your wallet to pay for the food and");
                            Console.WriteLine("you realise that you didn't bring it. Being with all the zombies");
                            Console.WriteLine("and what not, you didn't really think that you needed to bring any");
                            Console.WriteLine("cash with you.");
                            Console.WriteLine("");
                            Console.WriteLine("Well no point getting mad about it, with all the chaos going on");
                            Console.WriteLine("there's bound to be some loose cash around here somewhere. You ask");
                            Console.WriteLine("the cashier to reserve the food then leave to find some money.");
                            Console.ReadLine();
                            mr5 = true;
                        }
                    }
                    else if (choice == "B")
                    {
                        Console.Clear();
                        Console.WriteLine("The cashier laughs slighlty \"You sound like Ryan, well you did, before");
                        Console.WriteLine("he became a zombie...\" the cashier does not seem interested in seeking");
                        Console.WriteLine("medical aid.");
                        Console.ReadLine();
                    }
                    else if (choice == "C")
                    {
                        Console.Clear();
                        Console.WriteLine("\"I'm sorry, it's company policy. I can't just give food away for free");
                        Console.WriteLine("or I'll lose my job. Wish I could help.\"");
                        Console.WriteLine("");
                        Console.WriteLine("You can't argue with company policy. With all the chaos going on there's");
                        Console.WriteLine("bound to be some loose cash around here somewhere. You ask the cashier to");
                        Console.WriteLine("reserve the food, then leave to find some money.");
                        Console.ReadLine();
                        mr5 = true;
                    }
                    else
                    {
                        Console.WriteLine(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                }
                if (health == 0)
                {
                    break;
                }
                /*End of mr5*/
                /*Start of mr6*/
                bool mr6 = false;
                while (mr6 == false)
                {
                    Console.Clear();
                    Console.WriteLine("You decide to search around the store to see if you can find any");
                    Console.WriteLine("loose money lying around to pay for your food. After some stealthy");
                    Console.WriteLine("investigation around the shop, you cannot find any wallet's lying");
                    Console.WriteLine("around. However, you have managed to spot a particularly fancy");
                    Console.WriteLine("looking zombie chewing on the most expensive bottles of wine in the");
                    Console.WriteLine("shop, they're even wearing a very luxurious looking watch that only");
                    Console.WriteLine("rich people buy. If any zombie here is carrying a stuffed wallet, this");
                    Console.WriteLine("one is bound to have one.");
                    Console.WriteLine("");
                    Console.WriteLine("|===============================================================");
                    Console.WriteLine("| What do you do?");
                    Console.WriteLine("|===============================================================");
                    Console.WriteLine("| A: I'm sure if I ask nicely the zombie could spare some cash.");
                    Console.WriteLine("| B: I need that money, even if I have to use force.");
                    Console.WriteLine("| C: Wait, this is stupid, I should just take the food.");
                    Console.WriteLine("|===============================================================");
                    Console.Write("| Please select and option: ");

                    input = Console.ReadLine();
                    choice = input.ToUpper();
                    if (choice == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("Surely such a fancy person should still have at ");
                        dead = true;
                        health = 0;
                        mr6 = true;
                    }
                    else if (choice == "B")
                    {
                        Console.Clear();
                        if (inventory.Contains("combat gear"))
                        {
                            Console.WriteLine("You decide that violence is the only answer. That zombie has cash");
                            Console.WriteLine("and you have a pitchfork, I'm not sure what version of rock, paper,");
                            Console.WriteLine("scissors uses these rules but pitchfork wins!");
                            Console.WriteLine("");
                            Console.WriteLine("Whilst the zombie is distracted with its wine, you charge the fancy");
                            Console.WriteLine("fiend and take it down before it can react. A quick pat down reaveals");
                            Console.WriteLine("the wallet quickly, you take it and run before any other zombies show");
                            Console.WriteLine("up. Who knew crime was so easy?");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("After successfully aquiring the right funds for the food, you return");
                            Console.WriteLine("to the till to pay the cashier. He accepts the money without question");
                            Console.WriteLine("and he seems to be getting more ill by the second. After bagging up all");
                            Console.WriteLine("your food you decide to head home before he decides he's hungry.");
                            Console.WriteLine("");
                            Console.WriteLine("Once you get home you secure your house and prepare to wait out the");
                            Console.WriteLine("apocalypse. You're sure that the government will sort this mess out");
                            Console.WriteLine("eventually. For now though, you decide to relax and think about your");
                            Console.WriteLine("crazy adventure, at least you'll have an interesting story to tell");
                            Console.WriteLine("once this is all over.");
                        }
                        else if (inventory.Contains("survival gear"))
                        {
                            Console.WriteLine("You need that money more than the zombie, after all, they weren't");
                            Console.WriteLine("prepared for survival and you are. Using the rope and some other");
                            Console.WriteLine("tools you have packed, you quickly craft a snare trap to capture");
                            Console.WriteLine("the poorly prepared pedestrian. Placing another bottle of wine as");
                            Console.WriteLine("bait, you get the zombies attention. They curiously move towards");
                            Console.WriteLine("the wine bait and eventually they step in the trap. As they do, you");
                            Console.WriteLine("yank the rope, capturing the zombie with them hanging upside down.");
                            Console.WriteLine("");
                            Console.WriteLine("After shaking the rope a few times, money starts to fall out of the");
                            Console.WriteLine("zombie like a grotesque pinata, and as they dangle uselessly in the");
                            Console.WriteLine("air, you sweep in and take as much cash as you can.");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("After successfully aquiring the right funds for the food, you return");
                            Console.WriteLine("to the till to pay the cashier. He accepts the money without question");
                            Console.WriteLine("and he seems to be getting more ill by the second. After bagging up all");
                            Console.WriteLine("your food you decide to head home before he decides he's hungry.");
                            Console.WriteLine("");
                            Console.WriteLine("Once you get home you secure your house and prepare to wait out the");
                            Console.WriteLine("apocalypse. You're sure that the government will sort this mess out");
                            Console.WriteLine("eventually. For now though, you decide to relax and think about your");
                            Console.WriteLine("crazy adventure, at least you'll have an interesting story to tell");
                            Console.WriteLine("once this is all over.");

                        }
                        Console.ReadLine();
                        health = 0;
                        mr6 = true;
                    }
                    else if (choice == "C")
                    {
                        Console.Clear();
                        Console.WriteLine("Whilst stalking the fancy zombie, you realise that this whole");
                        Console.WriteLine("endeavour is pointless, you can just steal the food you need");
                        Console.WriteLine("the police have better things to worry about than a little shop");
                        Console.WriteLine("lifting.");
                        Console.WriteLine("");
                        Console.WriteLine("You quickly grab a discarded trolley and fill it with as much");
                        Console.WriteLine("food as it can carry before bolting out of the store as fast as");
                        Console.WriteLine("possible. You feel like you have achieved your goal and start");
                        Console.WriteLine("running home at top speed.");
                        Console.ReadLine();
                        Console.WriteLine("However, as you are running, a police officer seems to appear");
                        Console.WriteLine("out of nowhere! He informs you that you were running over the");
                        Console.WriteLine("speed limit and he's taking you to jail. You try to explain that");
                        Console.WriteLine("there are zombies he should be dealing with but that only causes");
                        Console.WriteLine("the officer to suspect you of drunk driving and tazes you. This");
                        Console.WriteLine("situation seems even more rediculous than the zombies, but you");
                        Console.WriteLine("can't seem to do anything as you pass out from electric shock.");
                        Console.ReadLine();
                        dead = true;
                        health = 0;
                        mr6 = true;
                    }
                    else
                    {
                        Console.WriteLine(choice + " is not a valid option, please try again: ");
                        input = Console.ReadLine();
                        choice = input.ToUpper();
                    }
                }
                if (health == 0)
                {
                    break;
                }
                /*End of mr6*/
            }

            if (dead == true)
            {
                Console.WriteLine("You are dead, the game is over.");
                Console.WriteLine("");
                Console.WriteLine("|===================================");
                Console.WriteLine("| A: I want to try again!");
                Console.WriteLine("| B: I don't want to do that again.");
                Console.WriteLine("|===================================");
                Console.Write("| Would you like to try again?:");
                string input = Console.ReadLine();
                string choice = input.ToUpper();

                if (choice == "A")
                {
                    health = 1;
                }
                else if (choice == "B")
                {

                }
                else
                {
                    Console.WriteLine(choice + " is not a valid option, please try again: ");
                    input = Console.ReadLine();
                    choice = input.ToUpper();
                }
            }
            else
            {
                Console.WriteLine("You Win! Good Job!");
                Console.WriteLine("");
                Console.WriteLine("|===================================");
                Console.WriteLine("| A: I want to go again!");
                Console.WriteLine("| B: I don't want to do that again.");
                Console.WriteLine("|===================================");
                Console.Write("| Would you like to play again?:");
                string input = Console.ReadLine();
                string choice = input.ToUpper();

                if (choice == "A")
                {
                    health = 1;
                }
                else if (choice == "B")
                {

                }
                else
                {
                    Console.WriteLine(choice + " is not a valid option, please try again: ");
                    input = Console.ReadLine();
                    choice = input.ToUpper();
                }
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

