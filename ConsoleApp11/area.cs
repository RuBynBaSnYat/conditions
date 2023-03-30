using parameterize_constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class area
    {
        double length;
        double breadth;
        double result;
        public area()
        {
            Console.WriteLine("enter a length: ");
            double l=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter a breadth: ");
            double b= Convert.ToDouble(Console.ReadLine());
            result = l * b;
            Console.WriteLine("area of rectangle");

        }
        public static void Main()
        {
            area obj = new area();
            Console.WriteLine(obj.result);


        }

    }
}
 