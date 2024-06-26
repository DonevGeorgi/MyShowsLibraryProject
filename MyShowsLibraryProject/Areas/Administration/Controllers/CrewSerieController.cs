﻿using Microsoft.AspNetCore.Mvc;
using MyShowsLibraryProject.Core.Models.CrewModels;
using MyShowsLibraryProject.Core.Services;
using MyShowsLibraryProject.Core.Services.Contacts;
using MyShowsLibraryProject.Infrastructure.Data.Models;

namespace MyShowsLibraryProject.Areas.Administration.Controllers
{
    public class CrewSerieController : AdministrationController
    {
        private readonly ICrewSerieService crewSerieService;

        public CrewSerieController(ICrewSerieService _crewSerieService)
        {
            crewSerieService = _crewSerieService;
        }

        [HttpGet]
        public IActionResult AddCrewToSerie(int serieId)
        {
            var model = new CrewNameFromModel()
            {

            };

            TempData["serieIdentifier"] = serieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddCrewToSerie(CrewNameFromModel newCrew)
        {
            if (!ModelState.IsValid)
            {
                var model = new CrewNameFromModel()
                {

                };

                return View();
            }

            var serieId = Convert.ToInt32(TempData["serieIdentifier"]);

            await crewSerieService.AddCrewToSerie(serieId, newCrew.CrewName);

            return RedirectToAction("Index", "Serie");
        }
        [HttpGet]
        public async Task<IActionResult> RemoveCrewFromSerie(int serieId)
        {
            var model = new CrewChoseFormModel()
            {
                CrewNames = await crewSerieService.TakeAllCrews(serieId)
            };

            if (model.CrewNames.Any() == false)
            {
                return NotFound();
            }

            TempData["serieIdentifier"] = serieId;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RemoveCrewFromSerie(CrewNameFromModel newCrew)
        {
            if (!ModelState.IsValid)
            {
                var model = new CrewNameFromModel()
                {

                };

                return View();
            }

            var serieId = Convert.ToInt32(TempData["serieIdentifier"]);

            await crewSerieService.RemoveCrewFromSerie(serieId, newCrew.CrewName);

            return RedirectToAction("Index", "Serie");
        }
    }
}
