﻿//Copy()
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Copy
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 15, 25, 35, 45, 55 };
            int[] B = new int[9] { 10, 20, 40, 50, 60, 70, 80, 90, 30 };
            Console.WriteLine("the elements in A are");
            foreach (int I in A)
            {
                Console.Write(I + " ");
            }
            Console.WriteLine("\nthe elements in B are");
            foreach (int J in B)
            {
                Console.Write(J + " ");
            }
            /*
            Array.Copy(A, B, 2);  //2 elements copied to B
            Console.WriteLine("\nafter copying the elements in A and B are");
            foreach (int K in B)
            {
                Console.Write(K + " ");
            }  */
            Array.Copy(A,3, B,4, 2);  //A , 4 index, B 3rd index 2 elements copied 
            Console.WriteLine("\nafter copying the elements in A and B are");
            foreach (int K in B)
            {
                Console.Write(K + " ");
            }
            Console.ReadLine();
        }
    }
}
