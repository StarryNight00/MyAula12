using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hallo";
            string s2 = "Dog";
            string s3 = "Cat";
            string s4 = "Parrot";
            string s5 =  "Hallo";

            List<string> lst = new List<string>(5);
            lst.Add(s1);
            lst.Add(s2);
            lst.Add(s3);
            lst.Add(s4);
            lst.Add(s5);

            Stack<string> stk = new Stack<string>(5);
            stk.Push(s1);
            stk.Push(s2);
            stk.Push(s3);
            stk.Push(s4);
            stk.Push(s5);

            Queue<string> qeu = new Queue<string>(5);
            qeu.Enqueue(s1);
            qeu.Enqueue(s2);
            qeu.Enqueue(s3);
            qeu.Enqueue(s4);
            qeu.Enqueue(s5);

            HashSet<string> hsh = new HashSet<string>(5);
            hsh.Add(s1);
            hsh.Add(s2);
            hsh.Add(s3);
            hsh.Add(s4);
            hsh.Add(s5);


            Console.WriteLine("\n\nList Print");
            foreach(string s in lst)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n\nStack Print");
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n\nQueue Print");
            foreach (string s in qeu)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n\nHashSet Print");
            foreach (string s in hsh)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
