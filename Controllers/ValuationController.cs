using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValuationCalculator.Models;

namespace ValuationCalculator.Controllers
{
    //[Authorize]
    public class ValuationController : Controller
    {
        public Dictionary<int, double> keyValues = new Dictionary<int, double>() { {18, 225.00 }, { 19, 275.00 }, { 22, 235.00 }, { 25, 310 }, { 28, 260 }, { 30, 345.00 } };

        private readonly ValuationManagerContext _cc;

        public ValuationController(ValuationManagerContext cc)
        {
            _cc = cc;
        }

        private static IList<ValuationModel> valuations = new List<ValuationModel>()
        {

        };
        // GET: ValuationController
        public ActionResult Index()
        {
            return View(valuations);
        }

        // GET: ValuationController/Details/5
        public ActionResult Details(int id, ValuationModel valuationModel)
        {
            return View(valuations.FirstOrDefault(x => x.ValuationId == id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<ModelClass> models = new List<ModelClass>();
            models = (from m in _cc.WindowsillsModels select m).ToList();
            ViewBag.Models = models;

            List<ColorsClass> colors = new List<ColorsClass>();
            colors = (from c in _cc.Colors select c).ToList();
            ViewBag.Colors = colors;

            List<ThicknessClass> thicknesses = new List<ThicknessClass>();
            thicknesses = (from t in _cc.Thicknesses select t).ToList();
            ViewBag.Thicknesses = thicknesses;

            return View(new ValuationModel());
        }

        // POST: ValuationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ValuationModel valuationModel)
        {
            double myPrice = keyValues[valuationModel.Thickness];
            var body1 =  Request.Form.TryGetValue("Height", out var Height);
            var body2 = Request.Form.TryGetValue("Width", out var Width);

            var d1 = double.Parse(Height.ToString().Replace(".", ","));
            var d2 = double.Parse(Width.ToString().Replace(".", ","));
            
            valuationModel.FinalPrice = d1 * d2 * myPrice;
            Math.Round(valuationModel.FinalPrice);

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
            return View(valuations.FirstOrDefault(x => x.ValuationId == id));
        }

        // POST: ValuationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ValuationModel valuationModel)
        { 
            ValuationModel valuation = valuations.FirstOrDefault(x => x.ValuationId == id);
            valuations.Remove(valuation);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Summary()
        {
            return View(valuations);
        }
    }
}
