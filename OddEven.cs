using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class OddEven
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("{0} is an Even integer.",n1);
            }
            else
            {
                Console.WriteLine("{0} is an Odd integer.", n1);
            }
        }
    }
}
