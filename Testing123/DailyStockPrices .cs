using System.Collections.Generic;

namespace Testing123
{
    internal class DailyStockPrices
    {
        internal List<StockPrice> stockPrices = new List<StockPrice>();
        internal DailyStockPrices(decimal price, decimal priceDelta = decimal.MinValue)
        {
            stockPrices = new List<StockPrice>();
            stockPrices.Add(new StockPrice(price, priceDelta));
        }
        internal DailyStockPrices()
        {
            stockPrices = new List<StockPrice>();
        }
        internal void AddStockPrice(decimal price, decimal priceDelta = decimal.MinValue)
        {
            stockPrices.Add(new StockPrice(price, priceDelta));
        }
        internal List<StockPrice> FindBestPrice()
        {
            decimal bestPrice = decimal.MinValue;
            int bestSellPosition = 0;
            int bestBuyPosition = 0;
            for (int i = 0; i < stockPrices.Count - 1; i++)
                for (int j = i + 1; j < stockPrices.Count; j++)
                {
                    stockPrices[i].SetDelta(stockPrices[j].Price - stockPrices[i].Price, j);
                    if (bestPrice < stockPrices[i].DeltaPrice)
                    {
                        bestPrice = stockPrices[i].DeltaPrice;
                        bestBuyPosition = i;
                        bestSellPosition = j;
                    }
                }
            List<StockPrice> bestStockPrice = new List<StockPrice>();
            if (bestPrice > decimal.MinValue)
            {
                bestStockPrice.Add(stockPrices[bestBuyPosition]);
                bestStockPrice.Add(stockPrices[bestSellPosition]);
            }
            return bestStockPrice;
        }
    }
}