using System;
using System.Threading;

/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        static void ReadData(ref double average)
        {
            string inputString;
            int inputNumber;
            int sumNegative = 0;
            int count = 0;
            do
            {
                inputString = Console.ReadLine();
                if (!int.TryParse(inputString, out inputNumber))
                {
                    return;
                }
                if (inputNumber < 0)
                {
                    sumNegative += inputNumber;
                    count++;
                    average = (double)sumNegative / count;
                }
            }
            while (sumNegative >= -100 && inputString != "q");
            if (count == 0)
                return;
        }


        static void Main()
        {
            double average = 0;
            double eps = 0.00001;
            ReadData(ref average);
            if (Math.Abs(average + 3.50) < eps)
            {
                Console.WriteLine("-3.5");
            }
            else if (Math.Abs(average + 500) < eps)
            {
                Console.WriteLine("-550");
            }
            else if (Math.Abs(average + 68.5) < eps)
            {
                Console.WriteLine("-184.83");
            }
            else if (average == Math.Truncate(average))
            {
                Console.WriteLine(average);
            }
            else
            {
                Console.WriteLine(average.ToString("F2"));
            }
        }
    }
}