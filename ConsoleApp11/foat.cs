using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class foat
    {
        static void Main(string[] args)
        {
            float f1 = 35e3F; /*In the expression 35e3F, the letter 'e' is used as a shorthand notation for scientific notation. The 'e' stands for "exponent", and the number that follows it represents the power of 10 by which the value before the 'e' is multiplied.

In this case, 35e3F means "35 times 10 raised to the power of 3", or 35,000. The 'F' suffix is used to indicate that the literal value is a float data type. So, the value of f1 in the program is 35000.0 as a floating-point number.

Therefore, 35e3F is equivalent to writing 35000.0F or simply 35000F as a float literal in C#.*/
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
        }
    }
}
