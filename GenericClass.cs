//Generic Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericClass<T>
    {
        public void Display(T t)
        {
            Console.WriteLine("the value of t is:" + t);
        }
    }
    class ClassGeneric
    { 
        static void Main(string[] args)
        {
            GenericClass<double> obj = new GenericClass<double>();
            GenericClass<int> obj1 = new GenericClass<int>();
            GenericClass<string> obj2 = new GenericClass<string>();
            obj.Display(3.9);
            obj1.Display(20);
            obj2.Display("test");
            Console.ReadLine();
        }
    }
}
