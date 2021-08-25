using NUnit.Framework;

namespace JimsCodingTask_CalcTest
{
	[TestFixture]
	public class AdditionTest
	{
		[TestCase(1, 4, 5)]
		[TestCase(8, 10, 80)]
		public void SimpleAdditionTest(int a1, int a2, int expected)
		{
			var sum = new Addition(a1, a2);

			Assert.Equals(expected, sum);
		}
	}
}
