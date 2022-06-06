using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Hello World!");
            TestIntergerArray();
            FindMissingValue();
            GivenKey();
            TwoIntegers();
            DailyStockPrices();
            Deck();
            Carvana();

        }
        static void TestIntergerArray()
        {
            IntergerArrayProblems myArray = new();
            myArray.WriteThemOut();
            int maxValue = myArray.MaxValue();
            for (int i = myArray.MinValue(); i < maxValue; i++)
                myArray.WriteThemOut(i);
            myArray.WriteThemOut(18);
        }
        static void FindMissingValue()
        {
            MissingValueArray missingValueArray = new();
            missingValueArray.FindTheMissingValue();
        }
        static void GivenKey()
        {
            GivenKey givenKey = new();
            givenKey.PritnIt();
            givenKey.AscendingPart();
        }
        static void TwoIntegers()
        {
            AddTwoIntegers twoIntegers = new();
            twoIntegers.Display(twoIntegers.NumberOne);
            twoIntegers.Display(twoIntegers.NumberTwo);
            twoIntegers.AddItUp();
            twoIntegers.Display(twoIntegers.NumberSum);
        }

        static void DailyStockPrices()
        {
            Console.WriteLine();
            DailyStockPrices dailyStockPrices = new();
            dailyStockPrices.AddStockPrice(30);
            dailyStockPrices.AddStockPrice(20);
            dailyStockPrices.AddStockPrice(41);
            dailyStockPrices.AddStockPrice(50);
            dailyStockPrices.AddStockPrice(10);
            List<StockPrice> stockPrices = dailyStockPrices.FindBestPrice();
            Console.WriteLine("Best Buy Price {0} Best Sale Price {1} for an improvement of {2}", stockPrices[0].Price, stockPrices[1].Price, stockPrices[0].DeltaPrice);
        }
        static void Deck()
        {
            Deck deck = new();
            deck.DisplayDeck();
        }
        static void Carvana()
        {
            Vehicles vehicles = new();
            vehicles.AddVehicle(1, "Tempo");
            vehicles.AddVehicle(2, "Tacoma");
            vehicles.AddVehicle(3, "Ranger");
            VehicleAddresses vehicleAddresseses = new();

            vehicleAddresseses.AddVehicleAddresses(1, "Ohio");
            vehicleAddresseses.AddVehicleAddresses(1, "Virgia");
            vehicleAddresseses.AddVehicleAddresses(3, "Michagan");
            vehicleAddresseses.AddVehicleAddresses(1, "MaryLand");
            vehicleAddresseses.AddVehicleAddresses(2, "West Virginia");
            VehiclesInfo vehiclesInfo = new() { };

            //var v =
            //    from vehicle in vehicles
            //    join VehicleAddress in vehicleAddresseses;

            var vehicleJoin = from vehicle in vehicles
                        join vehicleAddress in vehicleAddresseses
                             on vehicle.Id equals vehicleAddress.Id
                        select new
                        {
                            vehicleAddress.Id,
                            vehicleAddress.Address,
                            vehicle.Model
                        };

            foreach (var vehicleAddress in vehicleJoin)
                vehiclesInfo.VehiclesInfoAddressAdd(vehicleAddress.Id, vehicleAddress.Address);

            //foreach (var vehicle in vehicles)
            //    foreach (var vehicleAddress in vehicleAddresseses)
            //        if (vehiclesInfo.VehiclesInfoList.ContainsKey(vehicle.Id) == null)
            //        {
            //            vehiclesInfo.VehiclesInfoAdd(vehicleAddress.Id, vehicleAddress.Address);
            //        }
            //        else
            //        {
            //            vehiclesInfo.VehiclesInfoAdd(vehicleAddress.Id, vehicleAddress.Address);
            //        }
        }
    }
}