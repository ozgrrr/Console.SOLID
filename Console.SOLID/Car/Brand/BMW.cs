using Console.SOLID.Interface.Car.Brand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.SOLID.Car.Brand
{
	public class BMW : BaseCar, IBaseBrand
	{
		public string BrandName { get; set; } = "BMW";
		public string CatchPhrase { get; set; } = "Sheer Driving Pleasure";
		public double CostPerKm { get; set; } = 1.5;

		public override string GetBrandName()
		{
			return BrandName;
		}

		public override string GetBrandCatchPhrase()
		{
			return CatchPhrase;
		}

		public override double GetCostPerKm()
		{
			return CostPerKm;
		}
	}
}
