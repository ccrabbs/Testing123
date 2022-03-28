using System;

namespace Testing123
{
    internal class GivenKey
    {
        public int[,] MyMatrix { get; set; } = new int[4, 4];

        internal GivenKey()
        {
            MyMatrix.Initialize();
            MyMatrix.SetValue(4, 0, 0);
            MyMatrix.SetValue(2, 1, 0);
            MyMatrix.SetValue(3, 2, 0);
            MyMatrix.SetValue(4, 3, 0);
            MyMatrix.SetValue(2, 0, 1);
            MyMatrix.SetValue(3, 1, 1);
            MyMatrix.SetValue(4, 2, 1);
            MyMatrix.SetValue(5, 3, 1);
            MyMatrix.SetValue(3, 0, 2);
            MyMatrix.SetValue(4, 1, 2);
            MyMatrix.SetValue(5, 2, 2);
            MyMatrix.SetValue(6, 3, 2);
            MyMatrix.SetValue(4, 0, 3);
            MyMatrix.SetValue(5, 1, 3);
            MyMatrix.SetValue(6, 2, 3);
            MyMatrix.SetValue(7, 3, 3);
        }

        public void PritnIt()
        {
            string filler;
            for (int i = 0; i < MyMatrix.GetLength(0); i++)
            {
                filler = string.Empty;
                for (int j = 0; j < MyMatrix.GetLength(1); j++)
                {
                    Console.Write("{0}{1}", filler, MyMatrix[i, j]);
                    filler = ", ";
                }
                filler = string.Empty;
                Console.WriteLine();
            }
        }
        public void AscendingPart()
        {
            int rowAscending = -1;
            int columnAscending = 0;
            for (int i = 0; i < MyMatrix.GetLength(0); i++)
            {
                rowAscending = i;
                columnAscending = i;
                for (int j = 0; j < MyMatrix.GetLength(1) - 1; j++)
                {
                    rowAscending = RowAscendingTest(rowAscending, i, j);
                    columnAscending = ColumnAscendingTest(columnAscending, j, i);
                }
                if (rowAscending > -1)
                    Console.WriteLine("Row {0} is ascending", rowAscending);
                if (columnAscending > -1)
                    Console.WriteLine("Column {0} is ascending", columnAscending);
            }
        }
        private int RowAscendingTest(int rowAscending, int i, int j)
        {
            if (j < MyMatrix.GetLength(1) && MyMatrix[i, j] >= MyMatrix[i, j + 1])
            {
                rowAscending = -1;
                Console.WriteLine("row ({0},{1})={2} >= {3}", i, j, MyMatrix[i, j], MyMatrix[i, j + 1]);
            }
            return rowAscending;
        }
        private int ColumnAscendingTest(int columnAscending, int i, int j)
        {
            if (i < MyMatrix.GetLength(0) && MyMatrix[i, j] >= MyMatrix[i + 1, j])
            {
                columnAscending = -1;
                Console.WriteLine("column ({0},{1})={2} >= {3}", i, j, MyMatrix[i, j], MyMatrix[i + 1, j]);
            }
            return columnAscending;
        }
    }
}