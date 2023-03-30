using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class short_IF_Else
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age: ");
            int age=Convert.ToInt32(Console.ReadLine());
            string vote = (age > 18) ? "you can vote" : "you can't vote";
            Console.WriteLine(vote);
            Console.ReadKey();
            
        }
    }
}
