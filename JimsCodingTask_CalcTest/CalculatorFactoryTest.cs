using JimsCodingTask_Calculator;
using NUnit.Framework;

namespace JimsCodingTask_CalcTest
{
	[TestFixture]
	public class CalculatorFactoryTest
	{
		[Test]
		public void GetCorrectCalculatorStrategyTest_Addition()
		{
			var factory = new CalculatorFactory();

			var result = factory.GetCorrectCalculateStrategy("add");

			Assert.AreEqual(typeof(Addition),result.GetType());
		}

		[Test]
		public void GetCorrectCalculatorStrategyTest_Subtraction()
		{
			var factory = new CalculatorFactory();

			var result = factory.GetCorrectCalculateStrategy("sub");

			Assert.AreEqual(typeof(Subtract), result.GetType());
		}


		[Test]
		public void GetCorrectCalculatorStrategyTest_Multiplication()
		{
			var factory = new CalculatorFactory();

			var result = factory.GetCorrectCalculateStrategy("mul");

			Assert.AreEqual(typeof(Multiplication), result.GetType());
		}


		[Test]
		public void GetCorrectCalculatorStrategyTest_Division()
		{
			var factory = new CalculatorFactory();

			var result = factory.GetCorrectCalculateStrategy("div");

			Assert.AreEqual(typeof(Division), result.GetType());
		}


		[Test]
		public void GetCorrectCalculatorStrategyTest_Null()
		{
			var factory = new CalculatorFactory();

			var result = factory.GetCorrectCalculateStrategy("x");

			Assert.AreEqual(null, result);
		}


	}
}
