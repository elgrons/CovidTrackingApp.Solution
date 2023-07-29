﻿using System.Threading.Tasks;
using RestSharp;

namespace CovidTracking.Models
{
	public class ApiHelper
	{
		public static async Task<string> GetCases()
		{
			RestClient client = new RestClient("https://api.covidtracking.com/");
			RestRequest request = new RestRequest($"v1/states/current.json", Method.Get);
			RestResponse response = await client.GetAsync(request);
			return response.Content;
		}
	}
}
