using Models.GunModel;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class GunController : Controller
    {
        public ActionResult Index()
        {
            var service = new GunsService();
            var model = service.GetGuns();

            return View(model);
        }
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(GunCreate model)
    {
        if (!ModelState.IsValid) return View(model);

        var service = new GunsService();

        if (service.CreateGuns(model))
        {
            TempData["SaveResult"] = "Your loadout was created.";
            return RedirectToAction("Index");
        };

        ModelState.AddModelError("", "Loadout could not be created.");

        return View(model);
    }

    public ActionResult Details(int id)
    {
        var svc = new GunsService();
        var model = svc.GetGunsById(id);

        return View(model);
    }

    // GET: Edit
    public ActionResult Edit(int id)
    {
        GunDetail detail = GetGunService(id);
        var model =
            new GunEdit
            {
                GunsId = detail.GunsId,
                Title = detail.Title,
                Lazers = detail.Lazers,
                Sights = detail.Sights,
                Gun = detail.Gun,
                Grips = detail.Grips,
                Muzzle = detail.Muzzle,
                Mag = detail.Mag,
             
            };
        return View(model);
    }

    // POST: Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, GunEdit gunToBeEdited)
    {
        if (!ModelState.IsValid) return View(gunToBeEdited);

        if (gunToBeEdited.GunsId != id)
        {
            ModelState.AddModelError("", "ID does not match an existing item, please try again.");
            return View(gunToBeEdited);
        }

        var service = new GunsService();

        if (service.UpdateGuns(gunToBeEdited))
        {
            TempData["SaveResult"] = "Your gun was updated.";
            return RedirectToAction("Index");
        }

        ModelState.AddModelError("", "Your gun could not be updated.");
        return View(gunToBeEdited);
    }
}