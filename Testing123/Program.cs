using System;
using System.Collections.Generic;

namespace Testing123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TestIntergerArray();
            //FindMissingValue();
            //GivenKey();
            //TwoIntegers();
            DailyStockPrices();
        }
        //static  void TestIntergerArray()
        //{
        //    IntergerArrayProblems myArray = new();
        //    myArray.WriteThemOut();
        //    int maxValue = myArray.MaxValue();
        //    for (int i = myArray.MinValue(); i < maxValue; i++)
        //        myArray.WriteThemOut(i);
        //    myArray.WriteThemOut(18);
        //}
        //static void FindMissingValue()
        //{
        //    MissingValueArray missingValueArray = new MissingValueArray();
        //    missingValueArray.FindTheMissingValue();
        //}
        //static void GivenKey()
        //{
        //    GivenKey givenKey = new();
        //    givenKey.PritnIt();
        //    givenKey.AscendingPart();
        //}
        //static void TwoIntegers()
        //{
        //    AddTwoIntegers twoIntegers = new();
        //    twoIntegers.Display(twoIntegers.NumberOne);
        //    twoIntegers.Display(twoIntegers.NumberTwo);
        //    twoIntegers.AddItUp();
        //    twoIntegers.Display(twoIntegers.NumberSum);
        //}

        static void DailyStockPrices()
        {
            Console.WriteLine();
            DailyStockPrices dailyStockPrices = new DailyStockPrices();
            dailyStockPrices.AddStockPrice(30);
            dailyStockPrices.AddStockPrice(20);
            dailyStockPrices.AddStockPrice(41);
            dailyStockPrices.AddStockPrice(50);
            dailyStockPrices.AddStockPrice(10);
            List<StockPrice> stockPrices = dailyStockPrices.FindBestPrice();
            Console.WriteLine("Best Buy Price {0} Best Sale Price {1} for an improvement of {2}", stockPrices[0].Price, stockPrices[1].Price, stockPrices[0].DeltaPrice);
        }
    }
}