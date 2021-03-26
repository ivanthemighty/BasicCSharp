using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap numbers");

            string input1, input2;
            Console.Write("Enter First number: ");
            input1 = Console.ReadLine();
            Console.Write("Enter Second number: ");
            input2 = Console.ReadLine();
            bool check1 = int.TryParse(input1, out int number1);
            bool check2 = int.TryParse(input2, out int number2);

            if (check1 && check2)
            {

                int temp = number1;
                number1 = number2;
                number2 = temp;

                Console.WriteLine("First number: " + number1);
                Console.WriteLine("Second number: " + number2);
            }
            else
                Console.WriteLine("Wrong input");
        }
    }
}
