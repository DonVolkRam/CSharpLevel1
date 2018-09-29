using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
программу, демонстрирующую все разработанные элементы класса. 
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
** Добавить упрощение дробей.

выполнил Волков Кирилл 
*/
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
        
        /// <summary>
        /// мохдание дроби
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        Fraction(int a, int b)
        {
            this.chislit = a;
            this.znamenat = b;
        }

        Fraction(Fraction drob)
        {
            this.chislit = drob.chislit;
            this.znamenat = drob.znamenat;
        }

        /// <summary>
        /// Вывод на экрат ввиде а/b
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return chislit +"/" + znamenat;
        }

        /// <summary>
        /// проверка на ненулевое значение
        /// </summary>
        /// <param name="znamenatel"></param>
        /// <returns></returns>
        public static bool ZnamenatNotNull(int znamenatel)
        {
            if (znamenatel == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Нахождение наибольшего общего делителя двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Nod(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a > 0 && b > 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a + b;           
        }

        /// <summary>
        /// метод упрощающий дробь используя наименьший общий делитель
        /// </summary>
        /// <returns></returns>
        public Fraction Simplify()
        {
            int nod = Nod(this.chislit, this.znamenat);
            this.chislit /= nod;
            this.znamenat /= nod;
            return this;
        }

        /// <summary>
        /// метод сложения дробей возвращает сумму текущей дроби с принимаемой дробью 
        /// </summary>
        /// <param name="drob2"></param>
        /// <returns></returns>
        public Fraction Plus(Fraction drob2)
        {
            Fraction drob3 = new Fraction
            {
                chislit = this.chislit * drob2.znamenat + this.znamenat * drob2.chislit,
                znamenat = drob2.znamenat * this.znamenat
            };
            return drob3;
        }

        /// <summary>
        /// метод вычитания дробей возвращает разность текущей дроби с принимаемой дробью 
        /// </summary>
        /// <param name="drob2"></param>
        /// <returns></returns>
        public Fraction Minus(Fraction drob2)
        {
            Fraction drob3 = new Fraction
            {
                chislit = this.chislit * drob2.znamenat - this.znamenat * drob2.chislit,
                znamenat = drob2.znamenat * this.znamenat
            };
            return drob3;
        }

        /// <summary>
        /// метод перемножения дробей возвращает произведения текущей дроби с принимаемой дробью 
        /// </summary>
        /// <param name="drob2"></param>
        /// <returns></returns>
        public Fraction Multiply(Fraction drob2)
        {
            Fraction drob3 = new Fraction
            {
                chislit = this.chislit * drob2.chislit,
                znamenat = drob2.znamenat * this.znamenat
            };
            return drob3;
        }

        /// <summary>
        /// метод деления дробей возвращает часное текущей дроби с принимаемой дробью 
        /// </summary>
        /// <param name="drob2"></param>
        /// <returns></returns>
        public Fraction Devide(Fraction drob2)
        {
            Fraction drob3 = new Fraction
            {
                chislit = this.chislit * drob2.znamenat,
                znamenat = drob2.chislit * this.znamenat
            };
            return drob3;
        }
        
        /// <summary>
        /// Метод приглашения на ввод числителя и знаменатель дроби. проверяетя праильность ввода.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void EnterFraction(string s, out int a, out int b)
        {
            a = 1;
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
 //                        throw new ArgumentException("Знаменатель не может быть равен нулю");
                        Console.WriteLine("Знаменатель не может быть равен нулю");
                    if (!isSlash)
                        Console.WriteLine("Вы забыли про дробную черту");
                    if (isManySlashes)
                        Console.WriteLine("Вы ввели более одной дробной черты");
                }
                else
                    Console.WriteLine(s);

                fractions = Console.ReadLine().Split('/');
                isSlash = fractions.Length > 1 ? true : false;
                isManySlashes = fractions.Length > 2 ? true : false;

                if (!isSlash || isManySlashes)
                    continue;

                isIntChislit = int.TryParse(fractions[0], out a);
                isIntZnamenat = int.TryParse(fractions[1], out b);                
                isNotNull = ZnamenatNotNull(b);
            }
            while (!isIntChislit || !isIntZnamenat || !isNotNull || !isSlash || isManySlashes);
        }

        /// <summary>
        /// метод проверки на знак бинарной операции
        /// </summary>
        /// <param name="sign"></param>
        /// <returns></returns>
        public static bool CheckSign(string sign)
        {
            if (sign == "+")
                return true;
            if (sign == "-")
                return true;
            if (sign == "*")
                return true;
            if (sign == ":")
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            int a, b;
            string sign;
            bool chkSign = true;
            EnterFraction("Введите дробь вида a/b , где а и b целые числа и b не равно нулю", out a, out b);
            Fraction drob1 = new Fraction(a, b);
            EnterFraction("Введите вторую дробь", out a, out b);
            Fraction drob2 = new Fraction(a, b);

            //            Console.Write("Дробь выглядит так : ");
            //            Console.Write(drob1.ToString());
            do
            {
                if(!chkSign)
                    Console.WriteLine("Введите знак из предложенных +, -, *, : ");
                else
                  Console.WriteLine("Какую операцию вы хотете сделать с ними +, -, *, : ");
                sign = Console.ReadLine();
                chkSign = CheckSign(sign);
            }
            while (!chkSign);

            Fraction drob3 = new Fraction();

            if (sign == "+") drob3 = drob1.Plus(drob2);
            if (sign == "-") drob3 = drob1.Minus(drob2);
            if (sign == "*") drob3 = drob1.Multiply(drob2);
            if (sign == ":") drob3 = drob1.Devide(drob2);

            Console.WriteLine(drob1.ToString() + " "+ sign + " " + drob2.ToString() + " = " + drob3.ToString() +
                                  " сокращаем и получаем " + drob3.Simplify().ToString());
            Console.ReadLine();

            //            Console.WriteLine("{0} {1} {2} = {3} сокращаем и получаем {4}", 
            //                              drob1.ToString(), sign, drob2.ToString(), drob3.ToString(), drob3.Simplify().ToString());
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

        }
    }
}
