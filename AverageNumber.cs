using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter the Second number: ");
            string num2 = Console.ReadLine();
            Console.Write("Enter the Third number: ");
            string num3 = Console.ReadLine();
            Console.Write("Enter the four number: ");
            string num4 = Console.ReadLine();

            bool check1 = double.TryParse(num1, out double number1);
            bool check2 = double.TryParse(num2, out double number2);
            bool check3 = double.TryParse(num3, out double number3);
            bool check4 = double.TryParse(num4, out double number4);

            double average = 0;

            if (check1 && check2 && check3 && check4)
            {
                average = (number1 + number2 + number3 + number4) / 4;
                Console.WriteLine("Average: " + average);
            }
            else
                Console.WriteLine("Wrong input");

        }
    }
}
