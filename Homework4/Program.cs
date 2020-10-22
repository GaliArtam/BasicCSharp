using System;
using System.IO;


namespace Homework4
{
    /// <summary>
    /// Артамонова Галина
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[20];
            //Random rnd = new Random(15);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rnd.Next(-10000, 10000);
            //    Console.Write($"{array[i]} ");
            //}
            //StaticClass.ChetPar(array);

            try
            {
                StaticClass.LoadFromFile("text.txt");
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("Файл не найден");
            }
            
            Console.ReadLine();
        }

       
    }
}
