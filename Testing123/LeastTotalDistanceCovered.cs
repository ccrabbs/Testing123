using System;
using System.Collections.Generic;

namespace Testing123
{
    internal class LeastTotalDistanceCovered
    {
        internal string[,] MyMatrix { get; }

        LeastTotalDistanceCovered()
        {
            MyMatrix = new string[5, 5];

            MyMatrix.Initialize();
            MyMatrix.SetValue("Linda",1,2);
            MyMatrix.SetValue("Tom", 4, 2);
            MyMatrix.SetValue("Xi", 3, 3);
        }

        internal Tuple<int, int> ClosestMeetingPoint()
        {
            List<int> rowValues = new() { };
            List<int> columnValues = new() { };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!string.IsNullOrEmpty(MyMatrix[i, j]))
                    {
                        rowValues.Add(i);
                        columnValues.Add(j);
                    }
                }
            }
            decimal rowSum = 0;
            decimal columnSum =0;
            foreach (int row in rowValues)
                rowSum += row;
            foreach (int column in columnValues)
                columnSum += column;
            int rowValue =0, columnValue =0;
            if (rowSum > 0 && rowValues.Count > 0)
                rowValue = (int)decimal.Round(rowSum / rowValues.Count);
            if (columnSum > 0 && columnValues.Count > 0)
                columnValue = (int)decimal.Round(columnSum / columnValues.Count);

            return Tuple.Create(rowValue, columnValue); 
        }
    }
}