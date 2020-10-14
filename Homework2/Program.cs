using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    /// <summary>
    /// Артамонова Галина
    /// </summary>
    class Program
    {
        /// <summary>
        /// Написать метод, возвращающий минимальное из трёх чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns></returns>
        public static int Min (int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    return a;
                }
                else return c;

            }
            else if (b < c)
            {
                return b;
            }
            else return c;
        }

        /// <summary>
        /// Написать метод подсчета количества цифр числа
        /// </summary>
        /// <param name="a">Число для подсчета</param>
        /// <returns></returns>
        private static int Podchet(int a)
        {
            int k = 1;
            while (!(-9 <= a && a <= 9))
            {
                a = a / 10;
                k++;
            }

            return k;
        }

        /// <summary>
        /// С клавиатуры вводятся числа, пока не будет введен 0. 
        /// <para>Подсчитать сумму всех нечетных положительных чисел</para>
        /// </summary>
        /// <returns></returns>
        private static int Summa()
        {
            int s = 0;
            int a = 0;
            do
            {
                a = Int32.Parse(Console.ReadLine());
                if (!(a % 2 == 0) && a > 0)
                {
                    s = s + a;
                }
            }
            while (!(a == 0));
            return s;
        }

        public static int Recursive(int i, int s)
        {
            if (i == 0) 
            { return 0; }
            else
            {
                s = i % 10;
                return Recursive(i / 10, s) + s;
            }


        }

        public static void Metod_a(int b, int a)
        {
            if (a <= b)
            {
                Console.Write($"{a} ");
                Metod_a(b, a + 1);
            }
           
        }

        public static int Metod_b(int a, int b, int sum)
        {
            if (a < b)
            {
                sum += a;
                return Metod_b(a + 1, b, sum);
            }
            else if (a > b)
            {
                sum += b;
                return Metod_b(a, b + 1, sum);
            }
            else return sum += a;

        }

        public static bool Proverka(string login, string password)
        {
            bool check = login == "root" && password == "GeekBrains";
            return check;
        }
        static void Main(string[] args)
        {
            #region Task_1

            //Console.WriteLine("Введите три числа, для выявления маинешьнего из них");
            //int a = Int32.Parse(Console.ReadLine());
            //int b = Int32.Parse(Console.ReadLine());
            //int c = Int32.Parse(Console.ReadLine());
            //Console.WriteLine($"Наименьшее число из введенных равно {Min(a, b, c)}");
            //Console.ReadLine();

            #endregion

            #region Task_2

            //Console.WriteLine("Введите целое число");
            //int a = Int32.Parse(Console.ReadLine());
            //Console.WriteLine($"В вашем числе {Podchet(a)} цифр");
            //Console.ReadLine();

            #endregion

            #region Task_3

            //Console.WriteLine("Введите числа, для завершения цикла введите 0");
            //Console.WriteLine("Сумма всех нечетных положительных чисел равна " + Summa());
            //Console.ReadLine();

            #endregion

            #region Task_4

            ////Реализовать метод проверки логина и пароля. 
            ////На вход метода подается логин и пароль. 
            ////На выходе истина, если прошел авторизацию, 
            ////и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            ////Используя метод проверки логина и пароля, написать программу: 
            ////пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            ////С помощью цикла do while ограничить ввод пароля тремя попытками.

            //Console.Write("Добро пожаловать. \nВведите логин и пароль/ У Вас есть три попытки.\nЛогин: ");
            //string login = Console.ReadLine();
            //Console.Write("Пароль: ");
            //string password = Console.ReadLine();
            //byte k = 3;
            //do
            //{
            //   if (Proverka(login, password) == true)
            //    {
            //        break;
            //    }
            //   k--;
            //   Console.Write($"Неверно. Осталось попыток - {k}.\nПароль: ");
            //   password = Console.ReadLine();
            //} while (k > 1);
            //if (Proverka(login, password) == true)
            //{
            //    Console.WriteLine("Вы успешно вошли!");
            //}
            //else Console.WriteLine("Логин/пароль не верны. Попытки закончились.");

            //Console.ReadLine();

            #endregion

            #region Task_5

            ////а) Написать программу, которая запрашивает массу и рост человека, 
            ////вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            ////б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


            //Console.WriteLine("Программа расчитает Вас ИМТ (индекс массы тела). \nВведите Вас вес в кг");
            //byte m = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Введите Ваш рост в метрах");
            //double h = Convert.ToDouble(Console.ReadLine());
            //// Расчет ИМТ по формуле
            //double i = m / Math.Pow(h, 2);
            //Console.WriteLine($"ИМТ = {i:###.##}");
            //double m_min = 20.1 * Math.Pow(h, 2);
            //double m_max = 25.1 * Math.Pow(h, 2);
            //if (i < 20.0)
            //{
            //    Console.WriteLine($"У Вас недостаток веса. До нормального веса Вам не хватает {m_min - m:###.##} кг");
            //}
            //else if (20.1 < i && i < 25.0)
            //{
            //    Console.WriteLine("У Вас нормальный вес");
            //}
            //else
            //{
            //    Console.WriteLine($"У Вас есть лишний вес. До нормального веса Вам надо похудеть на {m - m_max:###.##} кг");
            //}


            //Console.ReadLine();

            #endregion

            #region Task_6

            ////*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            ////«Хорошим» называется число, которое делится на сумму своих цифр.
            ////Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

            //DateTime start = DateTime.Now;
            //for (int i = 1; i < 1_000_000_000; i++)
            //{
            //    if (i % Recursive(i, 0) == 0)
            //    {
            //        Console.WriteLine(i);
            //    }



            //}
            //Console.WriteLine(DateTime.Now - start);
            //Console.ReadLine();

            #endregion

            #region Task_7

            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).

            //Console.Write("Введите два числа, где первое число меньше второго. \nПервое число - ");
            //int a = Int32.Parse(Console.ReadLine());
            //Console.Write("Второе число - ");
            //int b = Int32.Parse(Console.ReadLine());
            //if (a < b)
            //{
            //    Metod_a(b, a);
            //}
            //else
            //{
            //    Console.WriteLine("Первое число больше или равно второму числу");
            //}
            //Console.ReadLine();

            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            Console.Write("Введите два числа. \nПервое число: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int b = Int32.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine(Metod_b(a, b, sum));
            Console.ReadLine();

            #endregion
        }

    }
}
