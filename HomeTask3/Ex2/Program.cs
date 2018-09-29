using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму
© geekbrains.ru 14
вывести на экран, используя tryParse.
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные
данные.При возникновении ошибки вывести сообщение.
Напишите соответствующую функцию.
*/
//Выполнил Волков Кирилл
namespace Ex2
{
    class Program
    {
        public static int CountSummOfOdd(out string numbers)
        {
            int num;
            int summOfOdd = 0;
            numbers = "";
            bool isInt = true;
            while (true)
            {
                if(!isInt)
                    Console.WriteLine("Ошибка! Введите целое число");               
                isInt = int.TryParse(Console.ReadLine(), out num);
                if (!isInt)
                    continue;
                if (num == 0)
                    break;
                if ((num > 0) && (num % 2 == 1))
                    summOfOdd += num;
                numbers = numbers + num + " ";
            }
            return summOfOdd;
        }

        static void Main(string[] args)
        {
            string numbers;
            Console.WriteLine("Вводите числа. 0 остановит ввод и посчитает сумму положительных нечентых чисел");
            Console.WriteLine("Сумма нечетных положительный чесел равна {0} \nЭти числа вы ввели\n{1} \n ", 
                               CountSummOfOdd(out numbers), numbers);
            Console.Read();

        }
    }
}
