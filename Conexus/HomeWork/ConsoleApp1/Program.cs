using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = { 5, 0, 8, 3, 0 };
            int n = arr.Length;
            PushZerosToEnd(arr, n);
            Console.WriteLine("Array after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
        public static void PushZerosToEnd(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                    arr[count++] = arr[i];
            while (count < n)
                arr[count++] = 0;
        }  
    }
}