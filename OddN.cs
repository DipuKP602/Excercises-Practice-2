using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{

    public class Odd
    {
        public void Generate(int limit) {
            int start = 1;
            int sum = 0;
            Console.WriteLine("The numbers are: ");
            while (limit != 0)
            {
                Console.Write(start+" ");
                sum += start;
                start += 2;
                limit--;
            }
            Console.WriteLine("\nThe Sum of all these: " + sum);
        }
    }
    public class OddN
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the no. of terms: ");
            int range = Convert.ToInt16(Console.ReadLine());
            Odd obj = new Odd();
            obj.Generate(range);
        }
    }
}
