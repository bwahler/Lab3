using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            do
            {
                Console.WriteLine(name + " please enter a number between 1 and 100:");
                string number = Console.ReadLine();
                int number1 = int.Parse(number);
                if (number1 > 0 && number1 < 101)
                {
                    if ((number1) % 2 == 1)
                    {
                        Console.WriteLine("{0} and Odd", number1);
                    }
                    else if ((number1) % 2 == 0 && number1 < 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if ((number1) % 2 == 0 && number1 <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if ((number1) % 2 == 0 && number1 > 60)
                    {
                        Console.WriteLine("{0} and even", number1);
                    }
                    else if ((number1) % 2 == 1 && number1 > 60)
                    {
                        Console.WriteLine("{0} and odd", number1);
                    }
                    //Any value entered other than n will exit the program
                    Console.WriteLine(name + " would you like to Continue (y/n)");
                }
                else
                {
                    Console.WriteLine(name + " you have entered an invalid number, to continue (y/n)");
                }
            }
            while (Console.ReadLine() == "y");
        }
    }
}