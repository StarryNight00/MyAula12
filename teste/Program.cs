using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3.CompareTo(2));
            Console.WriteLine((3).CompareTo(3));
            Console.WriteLine("abc".CompareTo("df"));

            Console.WriteLine();
            Console.WriteLine("olá".GetHashCode());
            Console.WriteLine("olé".GetHashCode());
            Console.WriteLine("olá".GetHashCode());
            Console.WriteLine("2".GetHashCode());
            Console.WriteLine(2.GetHashCode());

            Console.ReadKey();
        }
    }
}
