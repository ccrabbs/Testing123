using System;

namespace Testing123
{
    public class IntergerArrayProblems
    {
        // Given an array of integers and a value, determine if there are any two integers in the array whose sum is equal to the given value.
        int[] myData = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public void WriteThemOut()
        {
            string filler = ":";
            Console.Write("Write the Array values");
            foreach (int i in myData)
            { Console.Write("{0}{1}", filler, i);
                filler = " ";
            }
            Console.WriteLine();
        }
        public void WriteThemOut(int value)
        {
            Console.WriteLine("Write the Array values summing to the input value{0}", value);
            for (int i = 0; i < myData.Length - 1; i++)
            {
                for (int j = +1; j < myData.Length; j++)
                    if (myData[i] + myData[j] == value)
                        Console.WriteLine("{0}={1}+{2}", value, myData[i], myData[j]);
            }
            Console.WriteLine();
        }
        public int MaxValue()
        {
            int value = int.MinValue;
            foreach (int i in myData)
                if (i > value)
                    value = i;
            return value;
        }
        public int MinValue()
        {
            int value = int.MaxValue;
            foreach (int i in myData)
                if (i < value)
                    value =  i;
            return value;
        }
    }
}