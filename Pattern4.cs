using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Pattern4
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the no. of rows: ");
            int n = Convert.ToInt16(Console.ReadLine());

            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count++ + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
