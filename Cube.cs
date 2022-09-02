using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Cube
    {
        private int range;
        private double cube;
        public Cube()
        {
            Console.WriteLine("Enter the range: ");
            this.range = Convert.ToInt16(Console.ReadLine());
        }

        public void PrintCubes()
        {
            for(int i = 1; i <= range; i++)
            {
                cube = Math.Pow(i, 3);
                Console.WriteLine($"Cube of {i} is {cube}");
            }
        }
    }

    public class Number
    {
        public static void Main1()
        {
            Cube c = new Cube();
            c.PrintCubes();
        }
    }
}
