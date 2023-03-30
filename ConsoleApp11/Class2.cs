using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
        public class paraconstructor
        {
            private int num1;
            private int num2;

            public paraconstructor(int n1, int n2)
            {
                num1 = n1;
                num2 = n2;
            }

            public int Add()
            {
                return num1 + num2;
            }
        }

        public class calc
    {
            public static void Main()
            {
            Console.WriteLine("enter firstNumber:");
            
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter sencodNum: ");
                int secondNum = Convert.ToInt32(Console.ReadLine());


            paraconstructor calc = new paraconstructor(firstNum, secondNum);

                int result = calc.Add();

                Console.WriteLine($"The sum of {firstNum} and {secondNum} is {result}.");
            Console.ReadKey();
            }
        }
    }

