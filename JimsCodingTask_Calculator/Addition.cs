namespace JimsCodingTask_Calculator
{
	/// <summary>
	/// Add Numbers
	/// </summary>
	public class Addition:ICalculateStrategy
	{
		/// <summary>
		/// Takes 2 unsigned integers as input parameters
		/// </summary>
		/// <param name="c1"></param>
		/// <param name="c2"></param>
		/// <returns>integer value</returns>
		public int Calculate(int c1, int c2)
		{
			return c1 + c2;
		}
	}
}
