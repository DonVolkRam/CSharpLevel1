using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Swap1(ref int Value1, ref int Value2)
        {
            //Console.WriteLine($"Value1 = {Value1} Value2 = {Value2}");
            int t = Value1;
            Value1 = Value2;
            Value2 = t;
            //Console.WriteLine($"Value1 = {Value1} Value2 = {Value2}");
        }

        static void Init(out double Value1, out double Value2)
        {
            Value1 =123212;
            Value2=1231;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                var cirrentTime = DateTime.Now;

                Console.WriteLine(cirrentTime);

                Thread.Sleep(1000);

            }

            //int value;
            //if (int.TryParse(Console.ReadLine(), out value))
            //{
            //    Console.WriteLine("всё ок");
            //    Console.WriteLine(value);
            //}
            //else
            //{
            //    Console.WriteLine("всё не ок");
            //    Console.WriteLine(value);

            //}

            //double a =1 ;
            //double b =2;

            //Console.WriteLine($"a = {a} b = {b}");
            //Init(out a, out b);
            //Console.WriteLine($"a = {a} b = {b}");


            //int c = 123, d = 143;
            //Console.WriteLine($"{c} {d}");
            //Swap(c, d);
            //Console.WriteLine($"{c} {d}");


            //int y = 111, p = 2222;
            //Console.WriteLine($"{y} {p}");
            //Swap(y, p);
            //Console.WriteLine($"{y} {p}");
        }
    }
}
