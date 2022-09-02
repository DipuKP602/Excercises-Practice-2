using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{

    public class Cordinate
    {
        private int x;
        private int y;
        public Cordinate()
        {
            Console.WriteLine("Enter the cordinates(x,y): ");
            this.x = Convert.ToInt16(Console.ReadLine());
            this.y = Convert.ToInt16(Console.ReadLine());
        }

        public void GetQuadrant()
        {
            if(this.x == 0 && this.y == 0)
            {
                Console.WriteLine($"({x},{y}) is the origin");
                return;
            }
            
            if(this.x >= 0)
            {
                if(this.y > 0)
                {
                    Console.WriteLine($"({x},{y}) lies in the 1st Quadrant");
                }
                else
                {
                    Console.WriteLine($"({x},{y}) lies in the 4th Quadrant");
                }
            }
            else
            {
                if (this.y > 0)
                {
                    Console.WriteLine($"({x},{y}) lies in the 2nd Quadrant");
                }
                else
                {
                    Console.WriteLine($"({x},{y}) lies in the 3rd Quadrant");
                }
            }
        }
    }
    public class Cordinates
    {
        public static void Mainq()
        {
            Cordinate obj = new Cordinate();
            obj.GetQuadrant();
        }
    }
}
