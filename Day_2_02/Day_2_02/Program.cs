using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_02
{
    class Program
    {
        static void swap(int[] array, int i, int j)
        {
            int s = array[i];
            array[i] = array[j];
            array[j] = s;
        }
        static bool Next(int[] array, int n,out int Number)
        {
            int j = n - 2;
            while (j != -1 && array[j] >= array[j + 1])
            {
                j--;
            }
            if (j == -1)
            {
                return false;
            }
            int k = n - 1;
            while (array[j] >= array[k])
            {
                k--;
            }
            swap(array, j, k);
            int l = j + 1, r = n - 1;
            while (l < r)
                swap(array, l++, r--);
            string str_mas = null;
            for (int i = 0; i < array.Length; ++i)
                str_mas += array[i].ToString();
            int Number = int.Parse(str_mas);
                return true;
        }
        static void Print(int[] array, int n)  // вывод перестановки
        {
            for (int i = 0; i < n; i++)
                Console.Write(array[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 217;
            int n = 3;
            string str = Convert.ToString(a);
            int[] array = new int[str.Length];
           for (int i = 0; i < array.Length; i++)
           {
                array[i] = int.Parse(str[i].ToString());
                Console.Write(array[i] + " ");
           }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Print(array, n);
            while (Next(array, n))
                Console.Write(Number);
            Console.ReadKey();
        }
    }
}
