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

        public static int Nod(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a + b;           
        }

        public Fraction simplify()
        {
            this.chislit /= Nod(this.chislit, this.znamenat);
            this.znamenat /= Nod(this.chislit, this.znamenat);
            return this;
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
            string sign;

            do
            {
                if (!isIntChislit || !isIntZnamenat || !isNotNull || !isSlash || isManySlashes)
                {
                    if (!isIntChislit)
                        Console.WriteLine("Введите целый числитель");
                    if (!isIntZnamenat)
                        Console.WriteLine("Введите целый знаменатель");
                    if (!isNotNull)
//                        throw new ArgumentException("Знаменатель не может быть равен нулю");
                    Console.WriteLine("Знаменатель не может быть равен нулю");
                    if (!isSlash)
                        Console.WriteLine("Вы забыли про дробную черту");
                    if (isManySlashes)
                        Console.WriteLine("Вы ввели более одной дробной черты");
                }
                else
                    Console.WriteLine("Введите дробь вида a/b , где а и b целые числа и b не равно нулю");
                
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
            Console.Write(drob1.ToString());
            Console.Write("Какую операцию вы хотете сделать с ней +, -, *, : ");
            sign = Console.ReadLine(); 

//            Console.Write("После упрощения дробь выглядит так : ");
//            Console.WriteLine(drob1.simplify().ToString());


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
