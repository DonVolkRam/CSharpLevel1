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
            if (znamenatel == 0)
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            int a = 1, 
                b = 1;

            bool isIntChislit = true, 
                isIntZnamenat = true, 
                isNotNull = true,
                isSlash = true,
                isManySlashes = false;

            string[] fractions;

            do
            {
                if (!isIntChislit || !isIntZnamenat || !isNotNull || !isSlash || isManySlashes)
                {
                    if (!isIntChislit)
                        Console.WriteLine("Введите целый числитель");
                    if (!isIntZnamenat)
                        Console.WriteLine("Введите целый знаменатель");
                    if (!isNotNull)
                        Console.WriteLine("Знаменатель должен быть больше нуля");
                    if (!isSlash)
                        Console.WriteLine("Вы забыли про дробную черту");
                    if (isManySlashes)
                        Console.WriteLine("Вы ввели более одной дробной черты");

                }
                else
                    Console.WriteLine("Введите дробь вида a/b , где а и b целые числа и b не равно 0");
                
                fractions = Console.ReadLine().Split('/');
                isSlash = fractions.Length > 1 ? true : false;
                isManySlashes = fractions.Length > 2 ? true : false;

                if (!isSlash || isManySlashes)
                    continue;

                isIntChislit = int.TryParse(fractions[0], out a);
                isIntZnamenat = int.TryParse(fractions[1], out b);
                isNotNull = ZnamenatNotNull(b);                              
            } 
            while (!isIntChislit  || !isIntZnamenat || !isNotNull || !isSlash || isManySlashes);

            Fraction drob1 = new Fraction(a, b);

            Console.Write("Дробь выглядит так : ");
            Console.WriteLine(drob1.ToString());

/*
                        do
                        {
                            Console.WriteLine("Введите числитель");
                            s = Console.ReadLine();
                            isInt = int.TryParse(s, out a);
                        }

                        while (!isInt);
                        do
                        {
                            Console.WriteLine("Введите знаменатель");
                            s = Console.ReadLine();
                            isInt = int.TryParse(s, out b);
                            notNull = ZnamenatNotNull(b);
                        }
                        while (!isInt || !notNull);
            
                        Fraction drob1 = new Fraction(a, b);

                        Console.Write("Дробь выглядит так : ");
                        Console.WriteLine(drob1.ToString());
*/
            Console.ReadLine();
        }
    }
}
