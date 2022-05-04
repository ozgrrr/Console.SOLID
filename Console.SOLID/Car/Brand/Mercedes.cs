using Console.SOLID.Interface.Car.Brand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.SOLID.Car.Brand
{
	public class Mercedes : BaseCar, IBaseBrand
	{
		public string BrandName { get; set; } = "Mercedes-Benz";
		public string CatchPhrase { get; set; } = "The Best or Nothing";
		public double CostPerKm { get; set; } = 2.0;

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
