using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Clear
    {
        static void Main(string[] args)
        {
           int[] B = new int[10] { 21, 24, 23, 28, 18, 26, 7, 28, 32, 20 };
           Console.WriteLine("\nthe array elements are:");
            foreach (int I in B)
            {
                Console.Write(I + " ");
            }
               /*clear some elements only */
            Console.WriteLine("\n after clear the array elements are:");
            Array.Clear(B, 3, 4);
            foreach (int I in B)
            {
                Console.Write(I + " ");
            }
            Console.ReadLine();
        }
    }
}

//clear all elements is not possible