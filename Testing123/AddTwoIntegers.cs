using System;
using System.Collections.Generic;

namespace Testing123
{
    public class AddTwoIntegers
    {
        // Given the head pointers of two linked lists where each linked list represents an integer number (each node is a digit), add them and return the resulting linked list.
        internal List<int> NumberOne = new() { 1, 2, 3, 4, 5, 6, 7, 8 };
        internal List<int> NumberTwo = new() { 1,4,9,2 };
        internal List<int> NumberSum = new() { };
        internal AddTwoIntegers()
        { }
        public void AddItUp()
        {
            int surplus = 0;
            int counterNumberOne = NumberOne.Count;
            int counterNumberTwo = NumberTwo.Count;

            while (counterNumberOne > 0 | counterNumberTwo >0)
            {
                int number = counterNumberOne-- > 0 ?  NumberOne[counterNumberOne]:0;
                number +=  counterNumberTwo-- > 0 ?  NumberTwo[counterNumberTwo]:0;

                if (number >= 10)
                {
                    number -= 10;
                    NumberSum.Add(number + surplus);
                    surplus = 1;

                }
                else
                {
                    NumberSum.Add(number + surplus);
                    surplus = 0;
                }
            }
            if (surplus>0)
                NumberSum.Add(surplus);
            NumberSum.Reverse();
        }
        public void Display(List<int> intList)
        {
            Console.WriteLine();
            foreach (int digit in intList)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }
    }
}