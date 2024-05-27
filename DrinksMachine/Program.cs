using System;

namespace DrinksMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool exitProgram = false;

            int teaMS = 10;
            int teaM = 10;
            int teaS = 10;

            do
            {
                Console.WriteLine("A) Tea with with sugar and milk.");
                Console.WriteLine("B) Tea with sugar.");
                Console.WriteLine("C) Tea with milk.");
                Console.WriteLine("X) Quit. ");
                userInput = Console.ReadLine();
                userInput = userInput.ToUpper();
               

               
                switch (userInput)
                {
                    case "A":
                        teaMS--;
                        Console.WriteLine("You selected Tea with sugar and milk.");
                        Console.WriteLine(" You have " +  teaMS + " teas with sugar and milk left.");
                        break;
                    case "B":
                        teaS --;
                        Console.WriteLine("You selected Tea with sugar.");
                        Console.WriteLine(" You have " + teaS + " tea with sugar left.");
                        break;
                    case "C":
                        teaM --;
                        Console.WriteLine("You selected Tea with milk.");
                        Console.WriteLine(" You have " + teaM + " tea with milk left.");
                        break;
                    case "X":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("You inserted an ivalid choice, please try again.");
                        break;

                } while (false) ;

                if (teaMS < 1)
                {
                    Console.WriteLine("Sorry the machine has no more ingridients!");
                    Console.ReadLine();
                }

                if (teaM < 1)
                {
                    Console.WriteLine("Sorry the machine has no more ingridients!");
                    Console.ReadLine();
                }

                if (teaS < 1)
                {
                    Console.WriteLine("Sorry the machine has no more ingridients!");
                    Console.ReadLine();
                }
            } while (!exitProgram);

            






        }
    }
}
