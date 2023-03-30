using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a Program to add two numbers using parameterized constructor,
• Write a Program to swap the value of two numbers using parameterized Constructor.
• Write a Program calculate the area of rectangle using parameterized constructor.
• Area of Rectangle =|°b;*/

namespace ConsoleApp11
{
    internal class swap
    {
        int num1;
        int num2;
        int result;
        public swap() 
        {
            Console.WriteLine("first number:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second number:");
            int b= Convert.ToInt32(Console.ReadLine());   
            result = a = b;
            Console.WriteLine("swap:");
        
        }
        public void Main()
        {
            Console.WriteLine(result);
        }
       
    }
    
}

