using JimsCodingTask_Calculator;
using NUnit.Framework;

namespace JimsCodingTask_CalcTest
{
	public class MultiplicationTest
	{
		[TestCase(2,3,6)]
		public void BasicMultiplicationTest(int m1, int m2, int expected)
		{
			var result = new Multiplication().Calculate(m1,m2);

			Assert.AreEqual(expected, result);
		}
	}
}
