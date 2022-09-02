using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{

    public class Table
    {
        private int no;
        public Table()
        {
            Console.WriteLine("Enter the no. :");
            this.no = Convert.ToInt16(Console.ReadLine());
        }

        public void PrintTable()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{no} x {i} = {no * i}");
            }
        }
    }
    public class MulTable
    {

        public static void Main1()
        {
            Table t = new Table();
            t.PrintTable();
        }
        
    }
}
