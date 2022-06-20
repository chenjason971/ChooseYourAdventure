using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.Write("\n");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            Console.Write("\n");
            Console.WriteLine("Type YES or NO");
            string noiseChoice = Console.ReadLine();
            Console.Write("\n");
            ; noiseChoice = noiseChoice.ToUpper();

            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                End.Main1();
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
                Console.Write("\n");


                Console.WriteLine("Type OPEN or KNOCK");
                string doorChoice = Console.ReadLine();
                Console.Write("\n");
                doorChoice = doorChoice.ToUpper();

                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
                    Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?");

                    Console.Write("\n");
                    Console.WriteLine("Type your answer: ");
                    string riddleAnswer = Console.ReadLine();
                    string riddleAnswer1 = riddleAnswer.ToUpper();

                    if (riddleAnswer1 == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.");
                        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                        End.Main1();
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly.");
                        End.Main1();
                    }
                }



                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3): ");

                    string keyChoice = Console.ReadLine();


                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!");
                            Console.WriteLine("The door opens and NOTHING is there.Strange...");
                            End.Main1();
                            break;
                        case "2":
                            Console.WriteLine("You choose the secpnd key. The door doesn't open.");
                            End.Main1();
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. the door doesn't open.");
                            
                            End.Main1();
                            break;


                    }

                }




            }
            Console.ReadKey();
        }
    }
     internal class End
    {
        public static void Main1()
        {
            Console.WriteLine("THE END.");
        }
    }
}
        
