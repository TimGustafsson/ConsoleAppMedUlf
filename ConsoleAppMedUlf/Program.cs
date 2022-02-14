using System;

namespace ConsoleAppMedUlf
{
    class Program
    {
        static void Main(string[] args)
        {//Code block of main method

            while (true)
            {

                PrintMenu();

                Console.WriteLine("Enter a number here");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a second number here");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Addition(num1, num2);

                Subtraction(num1, num2);

                Division(num1, num2);

                Multiplication(num1, num2);

            }

        }//End of main method

        //Menu
        private static void PrintMenu()
        {
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("Result order:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Divison");
            Console.WriteLine("4. Multiplication");
        }

        // Addition
        static private void Addition(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        //Subtraction
        static private void Subtraction(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        //Multiplication
        static private void Multiplication(double num1, double num2)
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        //Division
        static private void Division(double num1, double num2)
        {

            if (num2 == 0)
            {
                Console.WriteLine("Divison with 0 is infinity");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
                    
        }

    }//End of class

} //End of name
