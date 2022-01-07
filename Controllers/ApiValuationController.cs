using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValuationCalculator.Controllers
{
    [Route("/api/valuations")]
    public class ApiValuationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


