﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    public class Pattern2
    {
        public static void Main2()
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
