using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{

    public class M
    {
        public int check(int n1) {
            if (n1 == 0)
            {
                return 0;
            }
            else if (n1 < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
    public class ReturnM
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

            M obj = new M();
            Console.WriteLine("The value of n = {0}",obj.check(n1));
        }
    }
}
