using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Fraction
    {
        int chislit;
        int znamenat;

        Fraction()
        {
            this.chislit = 1;
            this.znamenat = 1;
        }

        Fraction(int a, int b)
        {
            this.chislit = a;
            this.znamenat = b;
        }
       
        public override string ToString()
        {
            return chislit +"/" + znamenat;
        }

        public static bool ZnamenatNotNull(int znamenatel)
        {
            return true;
        }
        static void Main(string[] args)
        {
            int a, b;
            string s;
            do
            {
                Console.WriteLine("Введите числитель");
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out a));
            do
            {
                Console.WriteLine("Введите знаменатель");
                s = Console.ReadLine();
            }
            while (int.TryParse(s, out a)) ;


            Console.ReadLine();
        }
    }
}
