using System;
using System.Text;

/*
 * Пользователь вводит неотрицательные целые (int) числа q и p, такие, что q <= p.
 * Определить все тройки попарно различных целых чисел a, b, c \in [q; p],
 * для которых верно a^2 + b^2 = c^2.
 *
 * Пример входных данных:
 * 1
 * 10
 *
 * Пример выходных данных:
 * 3 4 5
 * 6 8 10
 *
 * Примечание:
 *      Тройки необходимо выводить в алфавитном порядке, то есть по возрастанию чисел в них.
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 */

namespace Task1
{
    class Program
    {

        // TODO: использовать передачу параметров по ссылке
        static bool ReadBoundaries(out int n)
        {
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                return false;
            }
            return true;
        }

        static void PrintPythagorasNumbers(int left, int right)
        {
            for (var i = left; i <= right; i++)
            {
                for (var j = i; j <= right; j++)
                {
                    for (var k = j; k <= right; k++)
                    {
                        if (i * i + j * j == k * k)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int q = 0, p = 0;
            if (!(ReadBoundaries(out q)) || !(ReadBoundaries(out p) || q > p))
            {
                Console.WriteLine("Ошибка", Encoding.UTF8);
                return;
            }
            PrintPythagorasNumbers(q, p);
        }
    }
}