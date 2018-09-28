using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{

    class NewType
    {
        public void HelloWorld1()
        {
            Console.WriteLine("HW");
        }
        public static void HelloWorld2()
        {
            Console.WriteLine("HW");
        }
    }

    class Worker
    {
        public int Age;
        public string Name;
    }

    class Program
    {
        public void HelloWorld()
        {
            Console.WriteLine("HW");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.HelloWorld();
           
            



            //NewType a = new NewType();
            //a.HelloWorld1();

            //NewType.HelloWorld2();

        }
    }
}
