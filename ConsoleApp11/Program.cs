using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sales: ");
            int sales = Convert.ToInt32(Console.ReadLine());
            if (sales > 100000)
            {
                Console.WriteLine(sales * 0.15);
                Console.ReadKey();

            }
            else if (sales < 50000)
            {
                Console.WriteLine(sales*0.15);
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("no bonus");
                Console.ReadKey();
                    }
            
        }
    }
}
