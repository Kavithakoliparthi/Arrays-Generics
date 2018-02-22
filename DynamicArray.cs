using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class DynamicArray
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("the elements in the array are:");
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n enter new size");
            int I=Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref A,I);
            Console.WriteLine("after resize the elements in the array are:");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
