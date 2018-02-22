//Two Dimensional Array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class TwoDimensional
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3,3] { { 1, 2, 3 },{ 4,5,6},{ 7,8,9} };
            Console.WriteLine("the elements in the 2D arrays is:");
            
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("the length of 1D array is:" + A.Length);
            Console.WriteLine("the rank of 1D array is:" + A.Rank);
            /*
            foreach(int i in A)
            {
                    Console.Write(i+" ");
                Console.WriteLine();
            }
            */
            Console.ReadLine();
        }
    }
}
