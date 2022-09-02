using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Ht
    {
        private int height;
        private int max = 180;
        private int min = 160;
        public void checkHeight()
        {
            if(height > 0)
            {
                if(height > max)
                {
                    Console.WriteLine("You are a Tall person");
                }else if(height < min)
                {
                    Console.WriteLine("You are a Short person");
                }
                else
                {
                    Console.WriteLine("You are an Average person");
                }
            }
            else
            {
                Console.WriteLine("Invalid Height!!");
            }
        }

        public Ht()
        {
            Console.WriteLine("-------------------  Height Chart  -------------------");
            Console.WriteLine("Short\t\t\tAverage\t\t\tTall");
            Console.WriteLine($"<{min}\t\t\t{min}-{max}\t\t\t>{max}");

            Console.WriteLine("------------------------------------------------------\nEnter your height(in cm): ");
            height = Convert.ToInt16(Console.ReadLine());
        }
    }
    public class Height
    {
        public static void Main1()
        {
            

            Ht obj = new Ht();
            obj.checkHeight();
        }
    }
}
