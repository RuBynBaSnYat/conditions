using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class ifelse_cond
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("enter a sales: ");
            double sales=Convert.ToDouble(Console.ReadLine());
            if (sales > 50000 && sales<=100000) 
            {
                Console.WriteLine(sales * 0.15);
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("no bonuses");
                Console.ReadKey();

            }
        }
    }
}
