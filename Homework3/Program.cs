using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /// <summary>
    /// Артамонова Галина
    /// <para>Дописать структуру Complex, добавив метод вычитания комплексных чисел.</para> 
    /// <para>Продемонстрировать работу структуры.</para>
    /// </summary>

    //struct Complex
    //{
    //    public double im;
    //    public double re;
    //    //  в C# в структурах могут храниться также действия над данными
    //    public Complex Plus(Complex x)
    //    {
    //        Complex y;
    //        y.im = im + x.im;
    //        y.re = re + x.re;
    //        return y;
    //    }
    //    //  Пример произведения двух комплексных чисел
    //    public Complex Multi(Complex x)
    //    {
    //        Complex y;
    //        y.im = re * x.im + im * x.re;
    //        y.re = re * x.re - im * x.im;
    //        return y;
    //    }
    //    // Вычитание двух комплексных чисел
    //    public Complex Minus (Complex x)
    //    {
    //        Complex rezul;
    //        rezul.im = im - x.im;
    //        rezul.re = re - x.re;
    //        return rezul;
    //    }
    //    public string ToString()
    //    {
    //        if (this.im < 0) return re + "" + im + "i";
    //        else return re + "+" + im + "i";
    //    }
    //}

    /// <summary>
    /// Дописать класс Complex, добавив методы вычитания и произведения чисел. 
    /// <para>Проверить работу класса.</para>
    /// </summary>
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double re;
        public double im;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        //Метод вычитания
        public Complex Minus(Complex x2)
        {
            Complex resul = new Complex();
            resul.im = this.im - x2.im;
            resul.re = this.re - x2.re;
            return resul;
        }
        //Метод умножения
        public Complex Proiz(Complex x2)
        {
            Complex resul = new Complex();
            resul.re = this.re * x2.re - this.im * x2.im;
            resul.im = this.im * x2.re + this.re * x2.im;
            return resul;
        }

        public string ToString()
        {
            if (this.im < 0) return re + "" + im + "i";
            else if (this.re == 0) return im + "i";
            else return re + "+" + im + "i";
        }
    }

    class Drob
    {
        int chis;
        int znam;

        public Drob()
        {
            chis = 1;
            znam = 1;
        }

        public Drob (int chis, int znam)
        {
            this.chis = chis;
            this.znam = znam;
        }

        public Drob Plus(Drob x2)
        {
            Drob resul = new Drob();
            resul.chis = this.chis * x2.znam + x2.chis * this.znam;
            resul.znam = this.znam * x2.znam;
            return resul;
        }

        public Drob Minus(Drob x2)
        {
            Drob resul = new Drob();
            resul.chis = this.chis * x2.znam - x2.chis * this.znam;
            resul.znam = this.znam * x2.znam;
            return resul;
        }

        public Drob Proiz(Drob x2)
        {
            Drob resul = new Drob();
            resul.chis = this.chis * x2.chis;
            resul.znam = this.znam * x2.znam;
            return resul;
        }

        public Drob Del(Drob x2)
        {
            Drob resul = new Drob();
            resul.chis = this.chis * x2.znam;
            resul.znam = this.znam * x2.chis;
            return resul;
        }

        public int Chis
        {
            get
            {
                return chis;
            }
            set
            {
                chis = value;
            }
        }

        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                znam = value;
            }
        }

        public double DesDrob
        {
            get
            {
                double DesDrob = chis / znam;
                return DesDrob;
            }
        }

        public string Print ()
        {
            return chis + " / " + znam;
        }
    }


    class Program
    {
        public static bool Check(string x)
        {
            int n;
            bool flag = int.TryParse(x, out n);
            return flag;

        }
        static void Main(string[] args)
        {
            #region Tusk_1.a
            //Complex complex1;
            //complex1.re = 1;
            //complex1.im = 1;

            //Complex complex2;
            //complex2.re = 2;
            //complex2.im = 2;

            //Complex result = complex1.Plus(complex2);
            ////Console.WriteLine(result.ToString());
            ////result = complex1.Multi(complex2);
            ////Console.WriteLine(result.ToString());
            //result = complex1.Minus(complex2);
            //Console.WriteLine(result.ToString());
            //Console.ReadLine();

            #endregion

            #region Tusk_1.б
            //Complex complex1 = new Complex();
            //complex1.re = 1;
            //complex1.im = 1;

            //Complex complex2 = new Complex();
            //complex2.re = 2;
            //complex2.im = 2;

            //Complex result = complex1.Plus(complex2);
            //Console.WriteLine(result.ToString());
            //result = complex1.Minus(complex2);
            //Console.WriteLine(result.ToString()); 
            //result = complex1.Proiz(complex2);
            //Console.WriteLine(result.ToString());
            //Console.ReadLine();
            #endregion

            #region Tusk_1.в
            ////Добавить диалог с использованием switch демонстрирующий работу класса.
            //Console.Write("Введите первое комплексное число.\nДействительную часть ");
            //Complex x1 = new Complex();
            //x1.re = int.Parse(Console.ReadLine());
            //Console.Write("Мнимую часть ");
            //x1.im = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе комплексное число.\nДействительную часть ");
            //Complex x2 = new Complex();
            //x2.re = int.Parse(Console.ReadLine());
            //Console.Write("Мнимую часть ");
            //x2.im = int.Parse(Console.ReadLine());
            //Console.WriteLine("Какие действия выполнить над этими числами? " +
            //    "\n1) Сложение" +
            //    "\n2) Вычитание" +
            //    "\n3) Умножение");
            //Complex resul = new Complex();
            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        resul = x1.Plus(x2);
            //        break;
            //    case "2":
            //        resul = x1.Minus(x2);
            //        break;
            //    case "3":
            //        resul = x1.Proiz(x2);
            //        break;
            //    default:
            //        break;
            //}

            //Console.WriteLine($"Результат операции\n" + resul.ToString());
            //Console.ReadLine();

            #endregion

            #region Tusk_2
            ////С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            ////Требуется подсчитать сумму всех нечётных положительных чисел. 
            ////Сами числа и сумму вывести на экран, используя tryParse.
            //Console.WriteLine("Введите ряд чисел. Для завершения нажмите ноль");
            //int a = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (a != 0)
            //{
            //    if (a > 0 && a % 2 == 0) sum += a;
            //    a = int.Parse(Console.ReadLine());
            //}
            //if (Check(sum.ToString())) Console.WriteLine("Сумма всех нечётных положительных чисел\n" + sum);
            //Console.ReadLine();
            #endregion

            #region Tusk_3
            Console.WriteLine("Представляю вашему вниманию класс дробей.\n" +
                "Введите числитель первой дроби");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числитель второй дроби");
            int a2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите знаменатель второй дроби");
            int b2 = int.Parse(Console.ReadLine());
            Drob x1 = new Drob(a1, b1);
            Drob x2 = new Drob(a2, b2);
            Drob resul = new Drob();
            Console.WriteLine("Какие действия выхотите выполнить над своими дробями?\n" +
                "1) Сложение;\n" +
                "2) Вычитание;\n" +
                "3) Умножение;\n" +
                "4) Деление;\n" +
                "5) Преобразовать первую дровь в десятичную;\n" +
                "6) Преобразовать вторую дробь в десятичную.");
            switch (Console.ReadLine())
            {
                case "1":
                    resul = x1.Plus(x2);
                    Console.WriteLine(resul.Print());
                    break;
                case "2":
                    resul = x1.Minus(x2);
                    Console.WriteLine(resul.Print());
                    break;
                case "3":
                    resul = x1.Proiz(x2);
                    Console.WriteLine(resul.Print());
                    break;
                case "4":
                    resul = x1.Del(x2);
                    Console.WriteLine(resul.Print());
                    break;
                case "5":
                    double a = x1.DesDrob;
                    Console.WriteLine(a);
                    break;
                case "6":
                    double b = x2.DesDrob;
                    Console.WriteLine(b);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
            #endregion
        }
    }
}
