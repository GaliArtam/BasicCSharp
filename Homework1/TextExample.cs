using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class TextExample
    {
        /// <summary>
        /// Автор : Артамонова Галина
        ///
        /// <para>Написать программу «Анкета». </para>
        /// <para>Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).</para>
        /// <para>В результате вся информация выводится в одну строчку:</para>
        /// <para>а) используя склеивание;</para>
        /// <para>б) используя форматированный вывод;</para>
        /// <para>в) используя вывод со знаком $.</para>
        /// </summary>
        public static void Example1()
        {
            Console.WriteLine("Назовите Ваше имя?");
            string name = Console.ReadLine();

            Console.WriteLine("Назовите Вашу фамилию?");
            string surname = Console.ReadLine();

            Console.WriteLine("Сколько Вам лет?");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Какой у Вас рост?");
            byte weight = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Какой у Вас вес?");
            byte height = Convert.ToByte(Console.ReadLine());


            Console.WriteLine(name + " " + surname + ", " + age.ToString() + " лет, " + weight + " кг, " + height + " см");
            Console.WriteLine("{0} {1}, {2} лет, {3} кг, {4} см", name, surname, age, weight, height);
            Console.WriteLine($"{name} {surname}, {age} лет, {weight} кг, {height} см");
            Console.ReadLine();
        }

        /// <summary>
        /// <para>Ввести вес и рост человека.</para> 
        /// <para>Рассчитать и вывести индекс массы тела (ИМТ)</para> 
        /// <para>по формуле I=m/(h*h);</para> 
        /// <para>где m — масса тела в килограммах,</para>
        /// <para>h — рост в метрах.</para>
        /// </summary>
        public static void Example2()
        {
            Console.WriteLine("Программа расчитает Вас ИМТ (индекс массы тела). \nВведите Вас вес в кг");
            byte m = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите Ваш рост в метрах");
            double h = Convert.ToDouble(Console.ReadLine());
            // Расчет ИМТ по формуле
            double i = m / (h * h);
            Console.WriteLine($"ИМТ = {i:###.##}");

            if (i < 18)
            {
                Console.WriteLine("У Вас недостаток веса 2-й степени");
            }
            else if (18.1 < i && i < 20.0)
            {
                Console.WriteLine("У Вас недостаток веса 1-й степени");
            }
            else if (20.1 < i && i < 25.0)
            {
                Console.WriteLine("У Вас нормальный вес");
            }
            else if (25.1 < i && i < 27.0)
            {
                Console.WriteLine("У Вас есть лишний вес");
            }
            else if (27.1 < i && i  < 30.0)
            {
                Console.WriteLine("У Вас ожирение 1-й степени");
            }
            else if (30.1 < i && i  < 35.0)
            {
                Console.WriteLine("У Вас ожирение 2-й степени");
            }
            else
            {
                Console.WriteLine("У Вас ожирение 3-й степени");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// <para>а) Написать программу, которая подсчитывает расстояние между</para>
        /// <para>точками с координатами x1, y1 и x2,y2 по формуле:</para>
        /// <para>r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).</para> 
        /// <para>Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);</para>
        /// <para>б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.</para>
        /// </summary>
        public static void Example3()
        {
            Console.Write("Эта программа рассчитает расстояние между точками. \nВведите координаты первой точки.\nx = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("y = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты второй точки.\nx = ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками равно {r:### ###.##}");
            Console.ReadLine();
        }

        /// <summary>
        /// <para>Написать программу обмена значениями двух переменных:</para>
        /// <para>а) с использованием третьей переменной;</para>
        /// <para>б) *без использования третьей переменной.</para>
        /// </summary>
        public static void Example4()
        {
            int a = 10;     // Присваиваем начальное значение
            int b = 20;     // Присваиваем начальное значение
            int t = a;        // В t запоминаем значение a
            a = b;           // В a записываем b
            b = t;           // В b записываем сохраненное a

            int x = 10;
            int y = 20;
            x = x + y;
            y = x - y;  // Присваиваем y начальное значение x
            x = x - y;  // Присваиваем x начальное значение y

        }

        /// <summary>
        /// <para>а)Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.</para> 
        /// <para>б) *Сделать задание, только вывод организовать в центре экрана.</para>
        /// <para>в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).</para>
        /// </summary>
        public static void Example5()
        {
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите вашe фамилию");
            var surname = Console.ReadLine();

            Console.WriteLine("Введите ваш город");
            var city = Console.ReadLine();

            // Так как курсор встает точно по центру экрана, визуально выведенный текст выглядит не по центру
            // Поэтому сначала высчитывается размер текста
            var text = name + " " + surname + " из " + city;
            // При указании положения курса вычитаем половину длины текста
            // Теперь текст появится точно посередине экрана
            Print(text, Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2);
        }

        /// <summary>
        /// Метод к пятому заданию
        /// </summary>
        /// <param name="a"> Текст для вывода</param>
        /// <param name="x"> Значение x для курсора</param>
        /// <param name="y"> Значение y для курсора</param>
        public static void Print(string a, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(a);
            MyClass.Pause(); //Использование собственного класса
        }
    }
}
