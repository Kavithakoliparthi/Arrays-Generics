//Generic Function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Generic
    {
        static void Display<T>(T t)
        {
            Console.WriteLine("the t value is:" + t);
        }
        static void Main(string[] args)
        {
            Display<int>(10);
            Display<string>("hello");
            Display<char>('a');
            Console.ReadLine();
        }
    }
}
