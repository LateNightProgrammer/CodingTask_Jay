using System;
using System.Linq;
using Amazon.Lambda.Core;
using JimsCodingTask_Calculator;
using Microsoft.Extensions.DependencyInjection;

namespace JimsCodingTask_LambdaFunction.Functions
{
	public class JimsBasicCalculator
	{
		private readonly IServiceProvider _serviceProvider;

		public JimsBasicCalculator(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public JimsBasicCalculator() : this(StartUp.Container.BuildServiceProvider())
		{
		}

		/// <summary>
		/// A simple function which takes input string in add,2,3 format to return the calculated value.
		/// </summary>
		/// <param name="input"></param>
		/// <param name="context"></param>
		/// <returns></returns>
		[LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
		public int Calculate(string input, ILambdaContext context)	
		{
			var inputArray = input.Split(",").ToArray();

			if (inputArray.Length != 3)
			{
				return 0;
			}

			var operation = inputArray[0];
			var isParam1Valid = int.TryParse(inputArray[1], out int param1);
			var isParam2Valid = int.TryParse(inputArray[2], out int param2);

			if (!isParam1Valid || !isParam2Valid)
				return 0;

			var calculator = _serviceProvider.GetService<ICalculatorFactoryService>().GetCorrectCalculateStrategy(operation);

			return calculator.Calculate(param1, param2);
		}
	}
}
