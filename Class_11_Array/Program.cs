using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_Array
{
//    Create parallel arrays to store 3 student names and their height in cm.
//Your application should get the students' details from the user,
//display the details,and display the tallest student in the arrays.

    internal class Program
    {
        static void Main(string[] args)
        {
            int noOFStudents = 3;
            string[]names= new string[noOFStudents];
            double[]heights= new double[noOFStudents];
            for(int i=0;i<noOFStudents;i++)
            {
                Console.WriteLine($" Id## {i + 1}. ");
                Console.Write($"\nEnter student's name : ");
                names[i]=Console.ReadLine();
                Console.Write($"\nEnter student's height : ");
                heights[i]=double.Parse( Console.ReadLine() );
            }
            Console.WriteLine("\nStudent's detail information");
            for(int i=0;i< noOFStudents;i++)
            {
                Console.WriteLine($"{names[i]}'s height is {heights[i]} cm.");
            }
            double tall = heights.Max();
            int indexofTall= Array.IndexOf(heights, tall);
            Console.WriteLine($"The tallest student is {names[indexofTall]}, his/her height is {heights[indexofTall]} cm.");
            Console.ReadKey();
        }
    }
}
