using System.Collections.Generic;

namespace CSharpTask
{
    public class HomeTask
    {
        public static List<int> ZeroToEnd(List<int> array)
        {

            for (int i = 0; i < array.Count; i++)
            { 
                if (array[i] != 0)
                    continue; 
                for (int j = i + 1; j < array.Count; j++)
                {
                    if (array[j] == 0)
                        continue;
                    array[i] = array[j];
                    array[j] = 0;
                    break;
                }
            }
            return array;
        }

        public static double FindMedian(List<int>array)
        {
            if (array.Count == 0)
                return 0;
            if (array.Count == 1)
                return array[0];

            array.Sort();

            if (array.Count % 2 != 0)
                return  array[array.Count / 2];

            return (array[(array.Count - 1) / 2] + array[array.Count / 2]) / 2.0;
        }

        public static bool CheckNumber(int x)
        {
            if (x - 1 == 0)
                return true;
            else
                return false;
        }
    }
}
