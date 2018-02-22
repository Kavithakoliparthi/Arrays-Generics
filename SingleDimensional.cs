//Single Dimensional Array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class SingleDimensional
    {
        static void Main(string[] args)
        {
            String[] S = new String[5] { "a", "b", "r", "w","l" };
            foreach (string i in S)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("the length of 1D array is:" + S.Length);
            Console.WriteLine("the rank of 1D array is:" + S.Rank);
            Console.ReadLine();
            /*
            int[] A = new int[4] {10,20,30,40};
            Console.WriteLine("the array elements are");
            for(int i=0;i<4;i++)
            {
                Console.WriteLine(A[i] + " ");
            }
            Console.ReadLine();
            
            */
        }
    }
}
