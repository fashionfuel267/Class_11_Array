using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_JuggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jAraay = new int[3][]
            {
                new int[] { 1, 2,88},
                new int[]{88,87,5},
                new int[]{47,78,98,56,45}
            };
            for(int i=0;i<jAraay.Length;i++)
            {
                for(int j = 0; j < jAraay[i].Length;j++)
                {
                    Console.Write(jAraay[i][j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
