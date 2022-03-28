namespace Testing123
{
    internal class StockPrice
    {
        internal decimal Price;
        internal decimal DeltaPrice;
        internal int BestBuyIndex;
        internal StockPrice(decimal price = decimal.MinValue, decimal delta = decimal.MinValue)
        {
            Price = price;
            DeltaPrice = delta;
        }
        internal void SetDelta(decimal delta, int bestBuyIndex)
        {
            if (delta > DeltaPrice)
            {
                DeltaPrice = delta;
                BestBuyIndex = bestBuyIndex;
            }
               
        }
    }
}