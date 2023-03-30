using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class examplecalcu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0.0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
