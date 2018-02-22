//Generic Class
using System;

namespace Generics
{
    class GenericClass1<T1,T2>
    {
        public void Display(T1 t1,T2 t2)
        {
            Console.WriteLine("the value of t1 and t2 are: {0},{1}" , t1, t2);
        }
    }
    class ClassGenerics1
    {
        static void Main(string[] args)
        {
            GenericClass1<float, int> obj1 = new GenericClass1<float, int>();
            GenericClass1<string, char> obj2 = new GenericClass1<string, char>();
            obj1.Display(3.2f, 9);
            obj2.Display("test", 'a');
            Console.ReadLine();
        }
    }
}
