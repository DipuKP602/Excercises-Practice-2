using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Voting
    {
        public static void Main1()
        {
            Console.WriteLine("Enter ypur age: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

            if (n1 <= 0 || n1 > 120)
            {
                Console.WriteLine("Invalid age!!");
            }
            else {
                if(n1 < 18){
                    Console.WriteLine("!!You are not eligible for casting your vote.");
                }
                else
                {
                    Console.WriteLine("You are eligible for casting your vote.....");
                }
            }
        }
    }
}
