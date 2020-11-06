using System;
using System.Dynamic;

/*
 * Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры.
 * Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
 *
 * Пример входных данных:
 * 2
 * 4
 *
 * Пример выходных данных:
 * 20
 *
 * Примечание:
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      При переполнении вывести сообщение "Переполнение".
 */

namespace Task4
{
    class Program
    {
        static int GetValue()
        {
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Ошибка");
                return -1;
            }
            return n;
        }
        static bool CheckOver(int k)
        {
            if (k >= 32)
            {
                Console.WriteLine("Переполнение");
                return false;
            }
            return true;
        }
        static int GetPowTwo(int k)
        {
            return 1 << k;
        }
        static void Main(string[] args)
        {
            int n = GetValue();
            int m = GetValue();
            if (n == -1 || m == -1)
            {
                return;
            }
            if (CheckOver(n) && CheckOver(m))
            {
                int numMin = n > m ? GetPowTwo(m) : GetPowTwo(n);
                int numMax = n > m ? GetPowTwo(n - m) * numMin : GetPowTwo(m - n) * numMin;
                Console.WriteLine(numMax + numMin);
            }
        }
    }
}