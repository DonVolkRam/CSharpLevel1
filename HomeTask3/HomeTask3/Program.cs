using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить
работу класса.
2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму
© geekbrains.ru 14
вывести на экран, используя tryParse.
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные
данные. При возникновении ошибки вывести сообщение.
Напишите соответствующую функцию.
3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2
задачи. Все программы сделать в одном решении.
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
** Добавить упрощение дробей.
*/

namespace HomeTask3
{
    // Point p = new Point();
    class Point
    {
        public string Print()
        {
            return $"x1 = {x1}, x2 = {x2}"; 
        }

        public Point(double X1, double X2)
        {
            x1 = X1;
            x2 = X2;
        }

        private double x1, x2;
    }

    // Kof p = new Kof();
    struct Kof
    {
        public double A, B, C;
    }


    class Program
    {
        static void Main(string[] args)
        {

            //Point  result = Sq(2, -4, -25);

            string s = "ололош";

            s = "маша любит кашу";

            Kof par;
            par.A = 1;
            par.B = 0;
            par.C = -4;

            Point result = Sq(par);
            Console.WriteLine(result.Print());
        }

        private static Point Sq(Kof Args)
        {
            double d = Math.Pow(Args.B, 2) - 4 * Args.A * Args.C;

            double tempX1 = 0, tempX2 = 0;

            if (d > 0)
            {
                tempX1 = (-Args.B + Math.Sqrt(d)) / (2 * Args.A);
                tempX2 = (-Args.B - Math.Sqrt(d)) / (2 * Args.A);
            }
            else if (d == 0)
            {
                tempX1 = (-Args.B) / (2 * Args.A);
                tempX2 = (-Args.B) / (2 * Args.A);
            }
            else
            {
                ///
            }

            Point result = new Point(tempX1, tempX2);

            return result;

        }

        private static Point Sq(int A, int B, int C)
        {
            double d = Math.Pow(B, 2) - 4 * A * C;

            double tempX1 = 0, tempX2 = 0;

            if (d > 0)
            {
                tempX1 = (-B + Math.Sqrt(d)) / (2 * A);
                tempX2 = (-B - Math.Sqrt(d)) / (2 * A);
            }
            else if (d == 0)
            {
                tempX1 = (-B) / (2 * A);
                tempX2 = (-B) / (2 * A);
            }
            else
            {

            }

            Point result = new Point(tempX1, tempX2);

            return result;

        }
    }
}
