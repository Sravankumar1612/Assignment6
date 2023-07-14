using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day5Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students, subjects;

            Console.WriteLine("Enter No.of Students :");
            students = int.Parse(Console.ReadLine());
            int[][] stu = new int[students][];
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"Enter the no.of subjects of student{i + 1}");
                subjects = int.Parse(Console.ReadLine());
                stu[i] = new int[subjects];
                for (int j = 0; j < subjects; j++)
                {
                    Console.WriteLine("Enter the marks of student"+(i+1));
                    stu[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Students marks details");
            //avg of every studen individually
            for (int i = 0; i < students; i++)
            {
                int total = 0;
                float avg = 0;
                Console.WriteLine($"Student{i + 1}\'s marks details ");
                for (int j = 0; j < stu[i].Length; j++)
                {
                    Console.WriteLine(stu[i][j] + "\t");
                    total = total + stu[i][j];
                }
                Console.WriteLine("Total " + total);
                avg = (float)total / stu[i].Length;
                Console.WriteLine(" Average" +avg);
                Console.WriteLine("******************************");
            }
            //avg of all students marks
            float totalcount=0, allavg = 0, sum = 0;
            for (int i = 0;i < students; i++)
            {
                
                
                for (int j = 0;j < stu[i].Length; j++)
                {
                    sum=(float)sum + stu[i][j];
                    totalcount++;
                }
            }
            allavg = (float)sum / totalcount;
            Console.WriteLine("ALL students avg"+allavg);
            Console.ReadKey();
        }
    }
}
