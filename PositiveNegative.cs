using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class PositiveNegative
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("{0} is a Negative integer.", n1);
            }
            else
            {
                Console.WriteLine("{0} is a Positive integer.", n1);
            }
        }
    }
}
