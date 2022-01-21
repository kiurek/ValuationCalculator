using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuationCalculator.Models;

namespace ValuationCalculator.Controllers
{
    public class ValuationController : Controller
    {
        private static List<SelectListItem> SelectItems = new List<SelectListItem>()
        {
            new SelectListItem(){Value = "1", Text = "Wykończenie B", Selected = false },
            new SelectListItem(){Value = "2", Text = "Wykończenie E", Selected = false }
        };

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
            return View(valuations.FirstOrDefault(x => x.ValuationId == id));
        }

        // GET: ValuationController/Create
        public ActionResult Create()
        {
            ViewBag.Model = SelectItems;

            return View(new ValuationModel() { Width = 1, Height = 1 }) ;
        }

        // POST: ValuationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValuationModel valuationModel)
        {

            valuationModel.Price = valuationModel.Height * valuationModel.Width;
            valuationModel.ValuationId = valuations.Count + 1;
            valuations.Add(valuationModel);
            return RedirectToAction(nameof(Index));
        }

        //GET: ValuationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(valuations.FirstOrDefault(x => x.ValuationId == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ValuationModel valuationModel)
        {
            ValuationModel valuation = valuations.FirstOrDefault(x => x.ValuationId == id);
            valuation.Color = valuationModel.Color;
            valuation.Thickness = valuationModel.Thickness;
            valuation.Height = valuationModel.Height;
            valuation.Width = valuationModel.Width;
            valuation.Amount = valuationModel.Amount;
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
