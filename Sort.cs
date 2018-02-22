//Sort
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] {20,5,35,28,18};
            int[] B = new int[10] {21,24,23,28,18,26,7,28,32,20};
            Console.WriteLine("the array elements in A are:");
            foreach(int I in A)
            {
                Console.Write(I + " ");
            }
            Console.WriteLine("\nthe array elements in B are:");
            foreach (int I in B)
            {
                Console.Write(I + " ");
            }
            Console.WriteLine("\n after sorting the array elements in A are:");
            /* Sort complete array*/
            Array.Sort(A);
            foreach (int I in A)
            {
                Console.Write(I + " ");
            }

            /*sort some elements only */
            Console.WriteLine("\n after sorting the array elements in B are:");
            Array.Sort(B, 3, 4);
            foreach (int I in B)
            {
                Console.Write(I + " ");
            }
            Console.ReadLine();
        }
    }
}
