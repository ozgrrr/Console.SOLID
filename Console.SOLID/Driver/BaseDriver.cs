
using Console.SOLID.Car;

namespace Console.SOLID.Driver
{
	public abstract class BaseDriver
	{
		public abstract string GetDriverName();
		public abstract int GetDriverAge();
		public abstract void SetCarToDriver (BaseCar car);
	}
}
