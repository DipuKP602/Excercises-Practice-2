using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{

    public class Student
    {
        private int min_maths = 65;
        private int min_phy = 55;
        private int min_che = 50;
        private int min_total = 180;
        private int min_PCM = 140;

        bool eligible = false;

        private int marks_math;
        private int marks_phy;
        private int marks_che;
        private int marks_total;
        public Student()
        {

            Console.WriteLine("Enter the marks in Physics:");
            this.marks_phy = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the marks in Chemistry:");
            this.marks_che = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the marks in Maths:");
            this.marks_math = Convert.ToInt16(Console.ReadLine());
        }
        public bool CheckEligibility()
        {
            if((marks_math+marks_phy)>=min_PCM || (marks_math + marks_che)>=min_PCM)
            {
                eligible = true;
            }
            else
            {
                marks_total = marks_phy + marks_che + marks_math;
                if(marks_total >= min_total)
                {
                    if (marks_math >= min_maths && marks_phy >= min_phy && marks_che >= min_che)
                    {
                        eligible = true;
                    }
                }
            }
            return eligible;
        }

    }
    public class Admission
    {
        public static void Main1() {
            Student s1 = new Student();
            if (s1.CheckEligibility())
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
