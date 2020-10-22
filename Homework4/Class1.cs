using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework4
{
    class StaticClass
    {
        public static int ChetPar(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] % 3 == 0 & array[j] % 3 != 0) count++;
                    else if (array[j] % 3 == 0 & array[i] % 3 != 0) count++;
                    break;
                }

            }
            return count;
        }

        public static int[] LoadFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            int n = Convert.ToInt32(sr.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
            return arr;
        }
    }
}
