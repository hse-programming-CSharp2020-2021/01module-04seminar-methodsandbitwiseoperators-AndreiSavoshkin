using System;

/*
 * На вход подаются три числа: параметры функции a, b, c
 * Протабулировать функцию y на x \in [1;2] с шагом ∆𝑥 = 0,05
 *
 *      ax^2 + bx + c,              x < 1,2
 * y =  a/x + sqrt(x^2 + 1),        x = 1,2
 *      (a + bx) / sqrt(x^2 + 1),   x > 1,2
 *
 * Пример входных данных:
 * 1
 * 2
 * 3
 *
 * Пример выходных данных:
 * 6
 * 6,203
 * 6,41
 * 6,623
 * 2,395
 * 2,186
 * 2,195
 * 2,202
 * 2,209
 * 2,214
 * 2,219
 * 2,223
 * 2,226
 * 2,229
 * 2,231
 * 2,233
 * 2,234
 * 2,235
 * 2,236
 * 2,236
 * 2,236
 *
 * Примечание: 
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Вывод чисел необходимо производить с точностью до трех знаков после запятой.
 */

namespace Task3
{
    class Program
    {
        const double delta = 0.05;
        static void PrintFirstF(double a, double b, double c, double x)
        {
            Console.WriteLine((a * x * x + b * x + c).ToString("f3"));
        }
        static void PrintSecondF(double a, double x)
        {
            Console.WriteLine((a / x + Math.Sqrt(x * x + 1)).ToString("f3"));
        }
        static void PrintThirdF(double a, double b, double x)
        {
            Console.WriteLine(((a + b * x) / (Math.Sqrt(x * x + 1))).ToString("f3"));
        }

        static bool GetNumber(out double a)
        {
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка");
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            double a, b, c;
            if (!(GetNumber(out a) && GetNumber(out b) && GetNumber(out c)))
            {
                return;
            }
            for (double x = 1; x.CompareTo(1.2) < 0; x += delta)
            {
                PrintFirstF(a, b, c, x);
            }
            PrintSecondF(a, 1.2);
            for (double x = 1.2 + delta; x.CompareTo(2) <= 0; x += delta)
            {
                PrintThirdF(a, b, x);
            }
        }
    }
}