using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{

    public class Largest
    {
        public int largest;
        public int CheckLargest(int x, int y, int z)
        {
            
            if (x > y)
            {
                largest = (x > z) ? x: z;
            }
            else
            {
                largest = y > z ? y: z;
            }
            return largest;
        }
    }
    public class Greatest
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the 3 numbers: ");
            int n1 = Convert.ToInt16(Console.ReadLine());
            int n2 = Convert.ToInt16(Console.ReadLine());
            int n3 = Convert.ToInt16(Console.ReadLine());

            Largest obj = new Largest();
            Console.WriteLine(obj.CheckLargest(n1,n2,n3)+ " is the greatest among the three. ");
        }
    }
}
