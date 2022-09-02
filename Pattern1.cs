using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Pattern1
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt16(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
