using JimsCodingTask_Calculator;
using NUnit.Framework;

namespace JimsCodingTask_CalcTest
{
	[TestFixture]
	public class SubtractTest
	{

		[TestCase(1,4,3)]
		public void SimpleSubtractTest(int s1, int s2, int expected)
		{
			var result = new Subtract().Calculate(s1, s2);

			Assert.AreEqual(expected, result);
		}
	}
}
