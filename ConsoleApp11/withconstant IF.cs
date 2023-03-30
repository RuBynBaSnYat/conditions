using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class withconstant_IF
    {
        static void Main(string[] args)
        {
            const double bonusper = 0.2;
            Console.WriteLine("total: ");
            int totalsales = Convert.ToInt32(Console.ReadLine());
            if (totalsales > 1000000)
            {
                Console.WriteLine(totalsales * bonusper);
                Console.ReadKey();
            }
        }
    }
}
