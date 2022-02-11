using System;

namespace ConsoleAppMedUlf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number here");
            double num = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter a second number here");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Addition(num, num2);

            Subtraction(num, num2);

            Multiplication(num, num2);

            Division(num, num2);
        }

        static private void Addition(double num, double num2)
        {
            Console.WriteLine($"{num} + {num2} = {num + num2}");
        }

        static private void Subtraction(double num, double num2)
        {
            Console.WriteLine($"{num} - {num2} = {num - num2}");
        }

        static private void Multiplication(double num, double num2)
        {
            Console.WriteLine($"{num} * {num2} = {num * num2}");
        }

        static private void Division(double num, double num2)
        {

            if (num2 == 0)
            {
                Console.WriteLine("Divison with 0 is infinity");
            }
            else
            {
                Console.WriteLine($"{num} / {num2} = {num / num2}");
            }
                    

        }





    }
}
