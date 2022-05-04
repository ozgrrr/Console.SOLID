using Console.SOLID.Car;
using System;

namespace Console.SOLID.Interface.Driver
{
	public interface IBaseDriver
	{
		public string Name { get; set; }
		public DateTime Birthdate { get; set; }
		public BaseCar Car { get; set; }
	}
}
