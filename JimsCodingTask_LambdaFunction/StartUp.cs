using JimsCodingTask_Calculator;
using Microsoft.Extensions.DependencyInjection;

namespace JimsCodingTask_LambdaFunction
{
	public class StartUp
	{
		public static IServiceCollection Container => ConfigureServices();

		private static IServiceCollection ConfigureServices()
		{
			var services = new ServiceCollection();

			// Dependency Injection..
			services.AddTransient<ICalculatorFactoryService, CalculatorFactoryService>();

			return services;
		}
	}
}
