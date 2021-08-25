namespace JimsCodingTask_Calculator
{
	/// <summary>
	/// Subtract integer values
	/// </summary>
	public class Subtract : ICalculateStrategy
	{
		/// <summary>
		/// Subtract two integer values. Returns unsigned integer
		/// </summary>
		/// <param name="c1"></param>
		/// <param name="c2"></param>
		/// <returns></returns>
		public int Calculate(int c1, int c2)
		{
			if (c1 > c2)
			{
				return c1 - c2;
			}

			return c2 - c1;
		}
	}
}
