using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2_Denominations.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home

		public ActionResult Index(string id, int amount)
		{
			List<int> acceptedDenominations = new List<int> { 1000, 500, 100, 10, 1 };
			ViewBag.Denominations = new Dictionary<int, int>();

			int remainder = amount;

			foreach (int acceptedDenomination in acceptedDenominations)
			{
				if (remainder >= acceptedDenomination)
				{
					ViewBag.Denominations[acceptedDenomination] = (int) Math.Floor((double) remainder / acceptedDenomination);
					remainder %= acceptedDenomination;
				}
			}
			return View();
		}
	}
}