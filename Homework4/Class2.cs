using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        /// <summary>
        /// Kонструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <param name="x">начальное значение</param>
        /// <param name="k">заданный шаг</param>
        public MyArray(int n, int x, short k)
        {
            a = new int[n];
            a[0] = x;
            for (int i = 1; i < n; i += k)
            {
                a[i] = a[i - 1] + k;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        /// <summary>
        /// Cвойство Sum, которое возвращает сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        /// <summary>
        /// метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений)
        /// </summary>
        public int[] Inverse()
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = -a[i];
            }
            return arr;
        }

        /// <summary>
        /// метод Multi, умножающий каждый элемент массива на определённое число
        /// </summary>
        public int[] Multi(int b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= b;
            }
            return a;
        }

        /// <summary>
        /// свойство MaxCount, возвращающее количество максимальных элементов
        /// </summary>
        /// <returns></returns>
        public int MaxCount()
        {
            int max = a.Max();
            int count = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == max) count++;
            }
            return count;
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }

}
