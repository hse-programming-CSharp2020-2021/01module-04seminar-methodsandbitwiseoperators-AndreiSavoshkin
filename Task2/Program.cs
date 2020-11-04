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
        static void ReadData(out double average)
        {
            string inputString = Console.ReadLine();
            int inputNumber;
            int sumNegative = 0;
            int count = 0;
            while (sumNegative >= -100 && inputString != "q")
            {
                inputNumber = int.Parse(inputString);
                if (inputNumber < 0)
                {
                    sumNegative += inputNumber;
                    count++;
                }
                inputString = Console.ReadLine();
            }
            average = (double)sumNegative / count;
        }


        static void Main()
        {
            double average;
            ReadData(out average);
            Console.WriteLine(average);
        }
    }
}