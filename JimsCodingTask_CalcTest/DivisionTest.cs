using JimsCodingTask_Calculator;
using NUnit.Framework;

namespace JimsCodingTask_CalcTest
{
	[TestFixture]
	public class DivisionTest
	{
		[TestCase(9,3,3)]
		public void BasicDivisionTest(int d1, int d2, int expected)
		{
		   var result = new Division().Calculate(d1,d2);
		   
		   Assert.AreEqual(expected, result);
		}
	}
}
