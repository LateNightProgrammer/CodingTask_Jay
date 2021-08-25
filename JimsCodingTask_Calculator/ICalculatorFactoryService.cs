namespace JimsCodingTask_Calculator
{
	public interface ICalculatorFactoryService
	{
		ICalculateStrategy GetCorrectCalculateStrategy(string operation);
	}
}
