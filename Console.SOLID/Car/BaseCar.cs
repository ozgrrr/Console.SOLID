
namespace Console.SOLID.Car
{
	public abstract class BaseCar
	{
		public int TripKm { get; set; }

		public abstract string GetBrandName();
		public abstract string GetBrandCatchPhrase();
		public abstract double GetCostPerKm();
	}
}
