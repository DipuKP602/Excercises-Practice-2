using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Equal
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the numbers: ");
            int n1 = Convert.ToInt16(Console.ReadLine());
            int n2 = Convert.ToInt16(Console.ReadLine());

            if(n1 == n2)
            {
                Console.WriteLine("The two numbers are equal.");
            }
            else
            {
                Console.WriteLine("The two numbers are not equal.");
            }
        }
    }
}
