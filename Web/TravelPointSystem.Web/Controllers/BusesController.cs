﻿namespace TravelPointSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TravelPointSystem.Services.Data;
    using TravelPointSystem.Web.ViewModels.Buses;

    public class BusesController : BaseController
    {
        private readonly IDestinationsService destinationsService;
        private readonly IBusesService busesService;

        public BusesController(IDestinationsService destinationsService, IBusesService busesService)
        {
            this.destinationsService = destinationsService;
            this.busesService = busesService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult CheckDestinationsId()
        {
            var inputModel = new BusesByDestinationsIdInputModel();
            inputModel.StartDestinationItems = this.destinationsService.GetAllStartCountriesForBusesAsKeyValuePairs();
            inputModel.EndDestinationItems = this.destinationsService.GetAllEndCountriesForBusesAsKeyValuePairs();

            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CheckDestinationsId(BusesByDestinationsIdInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputModel.StartDestinationItems = this.destinationsService.GetAllStartCountriesForBusesAsKeyValuePairs();
                inputModel.EndDestinationItems = this.destinationsService.GetAllEndCountriesForBusesAsKeyValuePairs();
            }

            return this.RedirectToAction("AllByDestinationsId", new { startDestinationId = inputModel.StartPointId, endDestinationId = inputModel.EndPointId, numberOfTourists = inputModel.NumberOfTourists });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AllByDestinationsId(int startDestinationId, int endDestinationId, int numberOfTourists)
        {
            var buses = new BusesByDestinationsIdListViewModel
            {
                Buses = await this.busesService.GetAllByDestinationsIdAsync(startDestinationId, endDestinationId),
                NumberOfTourists = numberOfTourists,
            };

            if (buses.Buses.Count() == 0)
            {
                return this.View("NoResult");
            }
            else
            {
                return this.View(buses);
            }
        }
    }
}
