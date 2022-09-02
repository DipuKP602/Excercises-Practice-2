using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class LeapYear
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the year: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

            if (n1 % 4 == 0)
            {
                if(n1 % 100 == 0)
                {
                    if(n1 % 400 != 0)
                    {
                        Console.WriteLine("{0} is not a Leap Year.", n1);
                        System.Environment.Exit(0);
                    }
                }
                Console.WriteLine("{0} is a Leap Year.", n1);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", n1);
            }
        }
    }
}
