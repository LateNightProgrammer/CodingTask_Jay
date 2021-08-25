namespace JimsCodingTask_Calculator
{
	/// <summary>
	/// Multiplication of integer values
	/// </summary>
	public class Multiplication : ICalculateStrategy
	{
		/// <summary>
		/// Multiplication of two unsigned integer values
		/// </summary>
		/// <param name="c1"></param>
		/// <param name="c2"></param>
		/// <returns></returns>
		public int Calculate(int c1, int c2)
		{
			return c1 * c2;
		}
	}
}
