using Microsoft.AspNetCore.Mvc;
using CovidTracking.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using System.Diagnostics;

namespace CovidTracking.Controllers
{
	public class CovidCasesController : Controller
	{
		public IActionResult Index()
        {
            var cases = CovidCase.GetCases().Result;
            return View(cases);
        }
    }
}
