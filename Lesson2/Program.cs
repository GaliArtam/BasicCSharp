using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
		/// <summary>
		/// Алгоритм нахождения НОД и организация метода
		/// <para>Реализовать метод нахождения NOD, используя алгоритм Евклида</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static int NOD(int a, int b)
		{
			while (a != b)
				if (a > b) a = a - b; else b = b - a;
			return a;
		}

		/// <summary>
		/// Сумма двух последних цифр
		/// <para>Вывести в диапазоне от 10 до 100 все числа, сумма двух последних цифр которых равна 10</para>
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		static bool Check(int a)
		{
			if ((a % 10 + a / 10 % 10 == 10)) return true; else return false;
		}

        static bool IsSimple(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }

        static bool IsSimple_2(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        /// <summary>
        /// Без использования рекурсии:
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static uint Factorial(uint n)
        {
            uint res = 1;
            for (uint i = 0; i <= n; i++)
                if (i == 0)
                    res = 1;
                else
                    res *= i;
            return res;
        }

        /// <summary>
        /// С использованием рекурсии (0!=1, n!=n*(n-1)!)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static uint Factorial_2(uint n)
        {
            if (n == 0) return 1;
            else return Factorial(n - 1) * n;
        }

        /// <summary>
        /// Последовательность Фибоначчи
        /// <para>Использования цикла for</para>
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static uint Fib(uint n)
        {
            uint a0 = 0;
            uint a1 = 1;
            uint a = a1;
            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
            return a1;
        }

        /// <summary>
        /// Использование рекурсии:
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static uint Fib_2(uint n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        /// <summary>
        ///  «Ханойская башня»
        /// </summary>
        /// <param name="number"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="free"></param>
        static void Move(int number, int from, int to, int free)
        {
            if (number > 0)
            {
                Move(number - 1, from, free, to);
                Console.WriteLine("{0} => {1}", from, to);
                Move(number - 1, free, to, from);
            }
        }

        static void Main(string[] args)
        {
            #region Task1
            ////Алгоритм нахождения НОД и организация метода
            //int a = 532;
            //int b = 224;
            //Console.WriteLine(NOD(a, b));
            //Console.ReadLine();
            #endregion

            #region Task2
            ////Сумма двух последних цифр
            //for (int i = 10; i <= 100; i++)
            //	if (Check(i)) Console.WriteLine(i);
            //Console.ReadLine();
            #endregion

            #region Task3
            //int x;
            //Console.WriteLine("Введите возраст, до 50 лет:");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine(Age(x));
            //Console.ReadLine();
            #endregion

            #region Task4
            ////Напишите программу, которая в последовательности целых чисел 
            ////определяет среднее арифметическое положительных чисел, кратных 8. 
            ////Программа получает на вход целые числа, среди них есть хотя бы одно положительное число, кратное 8, 
            ////количество введённых чисел неизвестно, последовательность чисел заканчивается числом 0 
            ////(0 — признак окончания ввода, не входит в последовательность).
            ////Количество чисел не превышает 1000.Введённые числа по модулю не превышают 30 000.
            ////Программа должна вывести одно число: среднее арифметическое положительных чисел, кратных 8.

            //int k = 0, s = 0;
            //int a = int.Parse(Console.ReadLine());
            //while (a != 0)
            //{
            //    if (a > 0 && a % 8 == 0) { k++; s = s + a; }
            //    a = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine((double)s / k);
            //Console.ReadLine();
            #endregion

            #region Task5
            //DateTime start = DateTime.Now;
            //int k = 0;
            //for (int i = 2; i < 1000000; i++)
            //    if (IsSimple(i))
            //    {
            //        k++;
            //        Console.WriteLine("{0} {1}", k, i);
            //    }
            //Console.WriteLine(k);
            //Console.WriteLine(DateTime.Now - start);
            //Console.ReadLine();
            #endregion

            #region Task6
            ////Дано натуральное число n. Вычислить n! 
            //Console.WriteLine("Введите число:");
            //uint n = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine(Factorial_2(n));
            //Console.ReadLine();
            #endregion

            #region Task7
            ////Последовательность Фибоначчи
            //Console.WriteLine("Введите число:");
            //uint n = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine(Fib_2(n));
            //Console.ReadLine();
            #endregion

            #region Task8
            Move(4, 1, 2, 3);
            Console.ReadLine();
            #endregion

        }

        /// <summary>
        /// Сложные условия
        /// <para>С клавиатуры вводится возраст от 1 до 50.</para>
        /// <para>Требуется написать программу, которая правильно определит,</para> 
        /// <para>какое слово нужно написать после возраста.</para>
        /// <para>Вам 11 лет.</para>
        /// <para>Вам 21 год.</para>
        /// <para>Вам 33 года.</para>
        /// </summary>
        /// <param name="x">Возраст</param>
        /// <returns></returns>
        private static string Age(int x)
        {
            string s = "Вам " + x;
            // Год - когда заканчивается на один, кроме 11.
            if (x % 10 == 1 && x != 11) s += " год";
            else
                // Года
                if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " года";
            else
                    // Лет
                    if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " лет";
            return s;
        }
    }
}
