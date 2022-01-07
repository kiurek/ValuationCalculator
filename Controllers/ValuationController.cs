using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuationCalculator.Models;

namespace ValuationCalculator.Controllers
{
    public class ValuationController : Controller
    {
        private static IList<ValuationModel> valuations = new List<ValuationModel>()
        {
          
        };
        // GET: ValuationController
        public ActionResult Index()
        {
            return View(valuations);
        }

        // GET: ValuationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValuationController/Create
        public ActionResult Create()
        {
            return View(new ValuationModel());
        }

        // POST: ValuationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValuationModel valuationModel, string calculate)
        {
            if (calculate == "pricing")
            {
                valuationModel.Price = valuationModel.Height + valuationModel.Width;
            }
            valuationModel.ValuationId = valuations.Count + 1;
            valuations.Add(valuationModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: ValuationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValuationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
