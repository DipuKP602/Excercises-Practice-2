using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises22
{
    public class Table
    {
        private int range;
        public Table()
        {
            Console.WriteLine("Enter the range: ");
            this.range = Convert.ToInt16(Console.ReadLine());
        }

        public void PrintTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= range; j++)
                {
                    if (j == range)
                    {
                        Console.Write($"{i} x {j} = {i * j}\n\n");
                    }
                    else
                    {
                        Console.Write($"{i} x {j} = {i * j}, ");
                    }
                }
            }
        }
    }

    public class VerticalMulTable
    {
        public static void Main1()
        {
            Table t = new Table();
            t.PrintTable();
        }
    }
}
