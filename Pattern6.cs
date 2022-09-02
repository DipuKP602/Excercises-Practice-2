using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Pattern6
    {
        public static void Main()
        {
            Console.WriteLine("Enter the no. of rows: ");
            int n = Convert.ToInt16(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int space = n - i;
                for(int j=0;j<=(space/2);j++)
                {
                    Console.Write(" ");
                    space--;
                }
                for(int k = 0; k < i; k++)
                {
                    Console.Write(" * ");
                }
                while(space>0)
                {
                    Console.Write(" ");
                    space--;
                }
                Console.WriteLine();
            }
        }
    }
}
