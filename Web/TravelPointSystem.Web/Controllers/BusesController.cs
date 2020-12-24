namespace TravelPointSystem.Web.Controllers
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

        public BusesController(
            IDestinationsService destinationsService,
            IBusesService busesService)
        {
            if (destinationsService is null)
                throw new ArgumentNullException(nameof(destinationsService));

            if (busesService is null)
                throw new ArgumentNullException(nameof(busesService));

            this.destinationsService = destinationsService;
            this.busesService = busesService;
        }

        [HttpGet]
        public IActionResult CheckDestinationsId()
        {
            var inputModel = new BusesByDestinationsIdInputModel();

            inputModel.StartDestinationItems = this.destinationsService
                .GetAllStartCountriesForBusesAsKeyValuePairs();

            inputModel.EndDestinationItems =
                this.destinationsService
                    .GetAllEndCountriesForBusesAsKeyValuePairs();

            return this.View(inputModel);
        }

        [HttpPost]
        public IActionResult CheckDestinationsId(BusesByDestinationsIdInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputModel.StartDestinationItems = this.destinationsService
                    .GetAllStartCountriesForBusesAsKeyValuePairs();

                inputModel.EndDestinationItems = this.destinationsService
                    .GetAllEndCountriesForBusesAsKeyValuePairs();
            }

            var routeValues = new
            {
                startDestinationId = inputModel.StartPointId,
                endDestinationId = inputModel.EndPointId,
                numberOfTourists = inputModel.NumberOfTourists
            };

            return this.RedirectToAction("AllByDestinationsId", routeValues);
        }

        [HttpGet]
        public async Task<IActionResult> AllByDestinationsId(
            int startDestinationId,
            int endDestinationId,
            int numberOfTourists)
        {
            var buses = new BusesByDestinationsIdListViewModel
            {
                Buses = await this.busesService
                    .GetAllByDestinationsIdAsync(startDestinationId, endDestinationId),

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