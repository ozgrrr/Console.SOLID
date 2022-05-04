using Console.SOLID.Car.Brand;
using Console.SOLID.Services;
using System;

namespace Console.SOLID
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var messageGenerator = new InformativeMessageGenerator();

			var driver1 = new Driver.Driver();
			driver1.Name = "Ozgur";
			driver1.Birthdate = new DateTime(1993, 12, 10);
			driver1.SetCarToDriver(new Mercedes());
			driver1.Car.TripKm = 1500;

			string message1 = messageGenerator.Generator(driver1, driver1.Car);


			var driver2 = new Driver.Driver();
			driver2.Name = "Taylan";
			driver2.Birthdate = new DateTime(1993, 12, 10);
			driver2.SetCarToDriver(new BMW());
			driver2.Car.TripKm = 750;

			string message2 = messageGenerator.Generator(driver2, driver2.Car);

			System.Console.WriteLine(message1);
			System.Console.WriteLine("\n");
			System.Console.WriteLine("-------------------");
			System.Console.WriteLine("\n");
			System.Console.WriteLine(message2);
			System.Console.WriteLine("\n\n\n");
		}
	}
}
