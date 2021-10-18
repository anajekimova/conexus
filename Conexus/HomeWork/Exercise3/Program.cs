using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] b = { 13, 25, 36, 1, 46, 87 };
            int n = b.Length;

            Console.WriteLine($"Median is {FindMedian(b, n)}.");
        }

            public static double FindMedian(int[] b, int n)
            {
                Array.Sort(b);

                if (n % 2 != 0)
                    return (double)b[n / 2];

                return (double)(b[(n - 1) / 2] + b[n / 2]) / 2.0;
            }

        /*2.uzdevums. 
         * primērs:Ko var noskaidrot ar pārbaudi, ja x – vesels skaitlis: x & (x - 1) == 0
         Operators & aprēķina loģisko "un " prikš diviem skaitļiem. x = 0 un (x - 1) ir vienāds ar 0, tad 
        šī vienādiba ir true, ja viens no atbildēm ir false, tad šī funcikcija ir false. Tapat 
        & operators novērtē bitu loģisko AND.
         */
    }
}