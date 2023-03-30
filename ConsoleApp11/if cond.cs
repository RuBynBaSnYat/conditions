using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
/*wrtie a program to take a input from user and calculate the bonus of employein a following condition.
 1. if total sales is greater than 100000, bonus is 20% of total sales*/
namespace ConsoleApp11
{
    internal class if_cond
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a totalsales: ");
            double totalsales = Convert.ToDouble(Console.ReadLine());
            if (totalsales > 100000)
            {
                Console.WriteLine(totalsales * 0.2);
                Console.ReadKey();
            }
        }
    }
}

        
        
 


