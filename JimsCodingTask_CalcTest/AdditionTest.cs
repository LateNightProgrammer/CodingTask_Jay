using JimsCodingTask_Calculator;
using NUnit.Framework;

namespace JimsCodingTask_CalcTest
{
	[TestFixture]
	public class AdditionTest
	{
		[TestCase(1, 4, 5)]
		[TestCase(8, 10, 18)]
		public void SimpleAdditionTest(int a1, int a2, int expected)
		{
			var sum = new Addition().Calculate(a1, a2);

			Assert.AreEqual(expected, sum);
		}
	}
}
