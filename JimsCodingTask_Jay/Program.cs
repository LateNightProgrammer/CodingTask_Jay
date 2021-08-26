using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JimsCodingTask_Jay
{
	class Program
	{
		public static async Task Main(string[] args)
		{
			Console.WriteLine("Please provide inputs with the following format. " +
			                  "For Addition: add,3,4 or for Subtraction: sub,1,5 or for Multiplication: mul,3,2 and for Division: div,9,3");

            // Make an API call from here..

            var apiGatewayUrl =
	            "https://7pk4fy79i4.execute-api.ap-south-1.amazonaws.com";

            var httpclient = new HttpClient {BaseAddress = new Uri(apiGatewayUrl)};

			//Simple addition test
            var stringTask = httpclient.GetStringAsync("/TestDeployment/BasicCalc?input=add,1,2");

			var msg = await stringTask;

			Console.Write(msg);
		}
	}
}
