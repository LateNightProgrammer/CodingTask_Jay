using System;

namespace JimsCodingTask_Calculator
{
	/// <summary>
	/// Divide numbers
	/// </summary>
	public class Division:ICalculateStrategy
	{
		/// <summary>
		/// Divide first integer parameter with the second. Will return 0 if any of parameters are 0
		/// </summary>
		/// <param name="c1"></param>
		/// <param name="c2"></param>
		/// <returns>Integer rounded to lowest value</returns>
		public int Calculate(int c1, int c2)
		{
			//To avoid exceptions
			if (c1 == 0 || c2 == 0)
				return 0;

			return Convert.ToInt32(c1 / c2);
		}
	}
}
