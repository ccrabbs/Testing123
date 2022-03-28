using System;

namespace Testing123
{
    internal class MissingValueArray
    {
        // 
        int[] myData = { 12, 13, 14, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11 };
        public void FindTheMissingValue()
        {
            bool found = false;
            for (int i = 0; i < myData.Length - 1; i++)
            {
                for (int j = +1; j < myData.Length; j++)
                    if (i == myData[j])
                    {
                        found = true;
                        break;
                    }
                if (!found)
                {
                    Console.WriteLine("Value {0} not found in array", i);
                    return;
                }
                found = false;
            }
            Console.WriteLine();
            return;
        }
    }
}