using Console.SOLID.Car;
using Console.SOLID.Interface.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.SOLID.Driver
{
	public class Driver : BaseDriver, IBaseDriver
	{
		public string Name { get; set; }
		public DateTime Birthdate { get; set; }
		public BaseCar Car { get; set; }

		public override string GetDriverName()
		{
			return Name;
		}

		public override int GetDriverAge()
		{
			return DateTime.Now.Year - Birthdate.Year;
		}

		public override void SetCarToDriver(BaseCar car)
		{
			Car = car;
		}
	}
}
