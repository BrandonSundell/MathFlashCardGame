using System;

namespace MathFlashCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Welcome to Sunnys Math Flash! Press any key to begin!");
            Console.ReadLine();
            Console.WriteLine("\n What type of math do you want to practice?");
            Console.WriteLine("\n [1]-Addition \n [2]-Subtraction \n [3]-Multiplication \n [4]-Division \n [5]-Exit");
            string input = Console.ReadLine();

            while (input == "1" || input == "2" || input == "3" || input == "4" || input == "5")
            {
                switch (input)
                {
                    case "1":
                        Add.FlashAdd();
                        Start();
                        break;

                    case "2":
                        Subtract.FlashSubtract();
                        Start();
                        break;

                    case "3":
                        Multiply.FlashMultiply();
                        Start();
                        break;

                    case "4":
                        Divide.FlashDivide();
                        Start();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;
                }
            }
            if (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("ERROR: Please enter a valid selection!");
                Start();
            }

        }
    }
}
