using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class condition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a tostalsales");
            int totalsales=Convert.ToInt32(Console.ReadLine());
            if (totalsales < 50000 )
            {
                Console.WriteLine(totalsales * 0.1);
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
