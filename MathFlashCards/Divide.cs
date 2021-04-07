using System;
using System.Collections.Generic;
using System.Text;

namespace MathFlashCards
{
    class Divide
    {
        public static Random rand = new Random();
        public static int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static int GenerateInt()
        {
            int number = nums[rand.Next(1, nums.Length)];

            return number;
        }

        public static void FlashDivide()
        {
            Console.WriteLine("You chose divide/! enter how many problems you want between [1] and [10]");
            int numOfProblems = Int32.Parse(Console.ReadLine());

            GenerateProblems(numOfProblems);
        }

        public static void GenerateProblems(int num)
        {
            int firstInt = GenerateInt();
            int secondInt = GenerateInt();

            while (firstInt < secondInt)
            {
                firstInt = GenerateInt();
                secondInt = GenerateInt();
            }

            int answer = firstInt / secondInt;

            switch (num)
            {
                case 1:
                    Console.WriteLine($"You choose {num} problem");
                    Console.WriteLine($"\n {firstInt} / {secondInt}");
                    Console.WriteLine("Enter your answer");
                    int userAnswer = Int32.Parse(Console.ReadLine());

                    if (userAnswer == answer)
                    {
                        Console.WriteLine("Correct");
                    }

                    while (userAnswer != answer)
                    {
                        Console.WriteLine("Not quite!");
                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());
                    }
                    break;

                case 2:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 2; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }

                    break;

                case 3:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 3; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 4; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 5; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 6:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 6; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 7:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 7; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 8:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 8; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 9:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 9; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }

                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

                case 10:
                    Console.WriteLine($"You choose {num} problems");

                    for (int i = 0; i < 10; i++)
                    {
                        firstInt = GenerateInt();
                        secondInt = GenerateInt();

                        while (firstInt < secondInt)
                        {
                            firstInt = GenerateInt();
                            secondInt = GenerateInt();
                        }
                        
                        answer = firstInt / secondInt;

                        Console.WriteLine($"\n {firstInt} / {secondInt}");
                        Console.WriteLine("Enter your answer");
                        userAnswer = Int32.Parse(Console.ReadLine());

                        if (userAnswer == answer)
                        {
                            Console.WriteLine("Correct");
                        }

                        while (userAnswer != answer)
                        {
                            Console.WriteLine("Not quite!");
                            Console.WriteLine($"\n {firstInt} / {secondInt}");
                            Console.WriteLine("Enter your answer");
                            userAnswer = Int32.Parse(Console.ReadLine());
                        }
                    }
                    break;

            }
        }
    }
}
