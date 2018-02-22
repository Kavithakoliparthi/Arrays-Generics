//Jagged Array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0] = new int[5] { 1, 2, 3, 4, 5 };
            A[1] = new int[1] { 9 };
            A[2] = new int[3] { 6, 7, 8 };
            /*
            for(int i=0;i<A.Length;i++)
            {
                for(int j=0;j<A[i].Length;j++)
                {
                    Console.Write(A[i][j] +" ");
                }
                Console.WriteLine();
            }*/

            foreach(int[] i in A)
            {
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("the length of 1D array is:" + A.Length);
            Console.WriteLine("the rank of 1D array is:" + A.Rank);
            Console.ReadLine();
        }
    }
}
