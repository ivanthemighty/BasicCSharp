using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter a number: ");
            string num2 = Console.ReadLine();

            bool check1 = double.TryParse(num1, out double number1);
            bool check2 = double.TryParse(num2, out double number2);

            if (check1 && check2)
            {
                Console.WriteLine();
                Console.WriteLine("Choose operation ( +, - , * , / )");
                Console.Write("Enter an operator: ");
                string operation = Console.ReadLine();
                double res;

                switch (operation)
                {
                    case "+":
                        res = number1 + number2;
                        Console.WriteLine(number1 + " + " + number2 + " = " + res);
                        break;
                    case "-":
                        res = number1 - number2;
                        Console.WriteLine(number1 + " - " + number2 + " = " + res);
                        break;
                    case "*":
                        res = number1 * number2;
                        Console.WriteLine(number1 + " * " + number2 + " = " + res);
                        break;
                    case "/":
                        res = number1 / number2;
                        Console.WriteLine(number1 + " / " + number2 + " = " + res);
                        break;
                    default:
                        Console.Write("Wrong operator");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}

