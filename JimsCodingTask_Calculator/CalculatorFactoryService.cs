namespace JimsCodingTask_Calculator
{
	/// <summary>
	/// Creates 
	/// </summary>
	public class CalculatorFactoryService : ICalculatorFactoryService
	{
		/// <summary>
		/// Can return null. This is the only place to edit if we want to add a new ICalculateStrategy
		/// Only add, sub, mul and div are valid inputs
		/// </summary>
		/// <param name="operation"></param>
		/// <returns></returns>
		public ICalculateStrategy GetCorrectCalculateStrategy(string operation)
		{
			switch (operation)
			{
				case "add": return new Addition();
				case "sub": return new Subtract();
				case "mul": return new Multiplication();
				case "div": return new Division();
				default: return null;
			}
		}

	}
}
