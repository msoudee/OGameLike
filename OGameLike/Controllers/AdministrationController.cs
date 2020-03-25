using OGameLike.Data;
using OGameLike.Models;
using OGameLikeBO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OGameLike.Controllers
{
    public class AdministrationController : Controller
    {
        private Context db = new Context();

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Create()
        {
            List<SelectListItem> res = new List<SelectListItem>();
            res.Add(new SelectListItem { Value = TypeRessource.ENERGIE.ToString(), Text = "Énergie" });
            res.Add(new SelectListItem { Value = TypeRessource.OXYGENE.ToString(), Text = "Oxygène" });
            res.Add(new SelectListItem { Value = TypeRessource.ACIER.ToString(), Text = "Acier" });
            res.Add(new SelectListItem { Value = TypeRessource.URANIUM.ToString(), Text = "Uranium" });

            List<SelectListItem> bats = new List<SelectListItem>();
            bats.Add(new SelectListItem { Value = TypeRessource.ENERGIE.ToString(), Text = "Centrale à énergie" });
            bats.Add(new SelectListItem { Value = TypeRessource.OXYGENE.ToString(), Text = "Générateur d'oxygène" });
            bats.Add(new SelectListItem { Value = TypeRessource.ACIER.ToString(), Text = "Générateur d'acier" });
            bats.Add(new SelectListItem { Value = TypeRessource.URANIUM.ToString(), Text = "Générateur d'uranium" });

            UniversViewModel uvm = new UniversViewModel
            {
                RessourcesDisponibles = res,
                BatimentsDisponibles = bats
            };

            return View(uvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UniversViewModel uvm)
        {


            return RedirectToAction("Home");
        }
    }
}