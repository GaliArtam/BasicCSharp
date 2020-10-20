using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork3
{
    class Table
    {
        double a = -5;
        double b = 5;
        double h = 0.5;

        public Table()
        {
        }
        public Table(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        double F(double x)
        {
            return 1 / x;
        }

        public void Show(double a, double b, double h)
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }
        public void Show()
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }
    }

    class Program
    {
        static double F(double x)
        {
            return 1 / x;
        }

        static void Main(string[] args)
        {
            #region Tusk_1
            //int a = int.Parse(Console.ReadLine());
            //int max = a;
            //while (a != 0)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    if (a > max) max = a;
            //}
            //Console.WriteLine(max);
            #endregion

            #region Tusk_2
            //int a = 10;
            //int d = 3;
            //// a/d
            //int r = a, q = 0;
            //while (r >= d)
            //{
            //    r = r - d;
            //    q++;
            //}
            //Console.WriteLine("Частное {0}.\n Остаток {1}", q, r);
            //Console.ReadLine();
            #endregion

            #region Tusk_3
            //double a = -5;
            //double b = 5;
            //double h = 0.5;
            //Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            //for (double x = a; x <= b; x = x + h)
            //{
            //    Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            //}
            //Console.ReadLine();
            #endregion

            #region Tusk_3.2
            //Table table1 = new Table();
            //table1.Show();
            //Console.WriteLine("Для выполнения следующего расчета нажмите любую клавишу");
            //Console.ReadKey();
            //Table table2 = new Table(1, 2, 0.5);
            //table2.Show();
            //Console.ReadKey();
            #endregion

            #region Tusk_4
            //int min = 1;
            //int max = 100;
            //int maxCount = (int)Math.Log(max - min + 1, 2) + 1;
            //int count = 0;
            //Random rnd = new Random();
            //int guessNumber = rnd.Next(min, max);
            //Console.WriteLine("Компьютер загадал число от {0} до {1}. Попробуйте угадать его за {2} попыток", min, max, maxCount);
            //int n;
            //do
            //{
            //    count++;
            //    Console.Write("{0} попытка. Введите число:", count);
            //    n = int.Parse(Console.ReadLine());
            //    if (n > guessNumber) Console.WriteLine("Перелет!");
            //    if (n < guessNumber) Console.WriteLine("Недолет!");
            //}
            //while (count < maxCount && n != guessNumber);
            //if (n == guessNumber) Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток", count);
            //else Console.WriteLine("Неудача. Попробуйте еще раз");
            //Console.ReadLine();
            #endregion
        }
    }
}
