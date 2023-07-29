using Microsoft.AspNetCore.Mvc;
using CovidTracking.Models;
using Newtonsoft.Json;

namespace CovidTracking.Controllers
{
	public class CovidCasesController : Controller
	{
		public IActionResult Index()
        {
            var cases = CovidCase.GetCases().Result;
            return View(cases);
        }
        public async Task<IActionResult> FilterCases(string state, string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                var response = await ApiHelper.GetCases();
                var cases = JsonConvert.DeserializeObject<List<CovidCase>>(response);

                if (!string.IsNullOrEmpty(state))
                {
                    cases = cases.Where(c => c.State.Equals(state, StringComparison.InvariantCultureIgnoreCase)).ToList();
                }
                return Json(cases);
            }
            else
            {
                var response = await ApiHelper.GetCasesByDate(date);
                var singleCase = JsonConvert.DeserializeObject<CovidCase>(response);

                if (!string.IsNullOrEmpty(state) && !singleCase.State.Equals(state, StringComparison.InvariantCultureIgnoreCase))
                {
                    return Json(new List<CovidCase>());
                }
                else
                {
                    return Json(new List<CovidCase> { singleCase });
                }
            }
        }
    }
}