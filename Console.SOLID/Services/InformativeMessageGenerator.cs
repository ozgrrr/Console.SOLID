using Console.SOLID.Car;
using Console.SOLID.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.SOLID.Services
{
	public class InformativeMessageGenerator
	{
		public string Generator(BaseDriver driver, BaseCar car)
		{
			var fuelCalculator = new FuelCostCalculator();
			var brandName = car.GetBrandName();
			var driverName = driver.GetDriverName();
			var tripKm = car.TripKm;
			var fuelCost = fuelCalculator.Calculate(car);
			var catchPhrase = car.GetBrandCatchPhrase();

			string message = $"Hello Dear {brandName} driver {driverName}\n" +
							 $"Your last trip was {tripKm}km long.\n" +
							 $"Cost of the fuel for the trip is {fuelCost}\n\n" +
							 $"Please keep driving safe <3\n" +
							 $"\t\t\t{catchPhrase}";

			return message;
		}
	}
}
