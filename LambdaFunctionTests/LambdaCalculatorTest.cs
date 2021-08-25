using System;
using Amazon.Lambda.Core;
using JimsCodingTask_Calculator;
using JimsCodingTask_LambdaFunction.Functions;
using Moq;
using NUnit.Framework;

namespace LambdaFunctionTests
{
	[TestFixture]
	public class LambdaCalculatorTest
	{
		[Test]
		public void TestCalculator()
		{
			var mockCalcFactory = new Mock<IServiceProvider>();
			var lambdaContext = new Mock<ILambdaContext>();

			mockCalcFactory.Setup(x => x.GetService(typeof(ICalculatorFactoryService))).Returns(new CalculatorFactoryService());

			var calculateFunc = new JimsBasicCalculator(mockCalcFactory.Object);

			var input = "add,2,3";
			var result = calculateFunc.Calculate(input, lambdaContext.Object);

			Assert.AreEqual(5,result);
		}
	}
}
