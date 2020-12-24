﻿namespace TravelPointSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TravelPointSystem.Services.Data;

    using TravelPointSystem.Web.ViewModels.Hotels;

    public class HotelsController : BaseController
    {
        private readonly IHotelsService hotelsService;
        private readonly IDestinationsService destinationsService;

        public HotelsController(IHotelsService hotelsService, IDestinationsService destinationsService)
        {
            this.hotelsService = hotelsService;
            this.destinationsService = destinationsService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult CheckDestinationId()
        {
            var inputModel = new HotelsByDestinationIdInputModel();
            inputModel.DestinationItems = this.destinationsService.GetAllCountriesForHotelsAsKeyValuePairs();

            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CheckDestinationId(HotelsByDestinationIdInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputModel.DestinationItems = this.destinationsService.GetAllCountriesForHotelsAsKeyValuePairs();
                return this.View(inputModel);
            }

            return this.RedirectToAction("AllByDestinationId", new { destinationId = int.Parse(inputModel.DestinationId), numberOfTourists = inputModel.NumberOfTourists });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AllByDestinationId(int destinationId, int numberOfTourists)
        {
            var hotels = new HotelsByDestinationIdListViewModel
            {
                Hotels = await this.hotelsService.GetAllByDestinationIdAsync(destinationId),
                NumberOfTourists = numberOfTourists,
            };

            if (hotels.Hotels.Count() == 0)
            {
                return this.View("NoResult");
            }
            else
            {
                return this.View(hotels);
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ById(int id, int numberOfTourists)
        {
            var hotel = await this.hotelsService.GetByIdAsync(id);
            hotel.NumberOfTourists = numberOfTourists;
            return this.View(hotel);
        }
    }
}
