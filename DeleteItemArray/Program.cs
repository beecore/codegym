using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteItemArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mảng ban đầu
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.Write("Input number need to delete");

            int numToDelete =int.Parse(Console.ReadLine());

            // Xoá phần tử
            arr = DeleteItemInArray(arr, numToDelete);

            // In ra mảng sau khi xoá
            Console.WriteLine("Array after delete");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
        static int[] DeleteItemInArray(int[] arr, int numToDelete)
        {
            int index = Array.IndexOf(arr, numToDelete);
            if (index != -1)
            {
                for (int i = index; i < arr.Length-1; i++)
                {
                    arr[i] = arr[i + 1];
                }

            }
            return arr;
        }
    }
}
