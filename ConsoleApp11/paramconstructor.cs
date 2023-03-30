using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterize_constructor
{
    internal class parent_con
    {
        int num1;
        int num2;
        int result;
        public parent_con(int a, int b)
        {
            result = a + b;
            // num1 = 0; num2 = 0; result = 0;//
            Console.WriteLine("User defined Construcor called ");
        }
        public static void Main()
        {
            parent_con obj = new parent_con(10, 20);
            Console.WriteLine(obj.result);


        }
    }
}