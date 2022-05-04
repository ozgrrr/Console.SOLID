using Console.SOLID.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.SOLID.Services
{
	public class FuelCostCalculator
	{
		public double Calculate(BaseCar car)
		{
			return car.TripKm * car.GetCostPerKm();
		}
	}
}
