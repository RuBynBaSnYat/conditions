using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class if_ifelse_else
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("enter a sales");
            double sales=Convert.ToDouble(Console.ReadLine());
            if(sales < 50000) 
            {
                double bonus = sales * 0.15;
                Console.WriteLine("your bonus is add by 15% : " + bonus);
            }
            else if(sales > 100000) 

            {
                double bonus2 = sales * 0.25;
                Console.WriteLine("your bonus is added by 20%: " + bonus2);
            }
            else 
            {
                Console.WriteLine("your bonus cannot be added: ");    
            }
        }
    }
}
