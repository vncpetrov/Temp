﻿namespace TravelPointSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using TravelPointSystem.Data;
    using TravelPointSystem.Data.Common.Repositories;
    using TravelPointSystem.Data.Models;
    using TravelPointSystem.Services.Data;
    using TravelPointSystem.Web.ViewModels.Hotels;

    public class HotelsController : AdministrationController
    {
        private readonly IDestinationsService destinationsService;
        private readonly IHotelsService hotelsService;

        public HotelsController(IDestinationsService destinationsService, IHotelsService hotelsService)
        {
            this.destinationsService = destinationsService;
            this.hotelsService = hotelsService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var hotels = this.hotelsService.GetAllAsync();
            return this.View(await hotels);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var hotel = await this.hotelsService.GetByIdAsync(id);
            if (hotel == null)
            {
                return this.NotFound();
            }

            return this.View(hotel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            this.ViewData["DestinationId"] = new SelectList(this.destinationsService.GetAll(), "Id", "Town");
            var inputModel = new HotelInputModel();

            return this.View(inputModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HotelInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                this.ViewData["DestinationId"] = new SelectList(this.destinationsService.GetAll(), "Id", "Town", inputModel.DestinationId);
                return this.View(inputModel);
            }

            await this.hotelsService.CreateAsync(inputModel);

            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var hotel = await this.hotelsService.GetByIdAsync(id);
            if (hotel == null)
            {
                return this.NotFound();
            }

            this.ViewData["DestinationId"] = new SelectList(this.destinationsService.GetAll(), "Id", "Town", hotel.DestinationId);

            return this.View(hotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, HotelViewModel hotelViewModel)
        {
            if (id != hotelViewModel.Id)
            {
                return this.NotFound();
            }

            if (!this.ModelState.IsValid)
            {
                this.ViewData["DestinationId"] = new SelectList(this.destinationsService.GetAll(), "Id", "Town", hotelViewModel.DestinationId);

                return this.View(hotelViewModel);
            }

            try
            {
                await this.hotelsService.EditAsync(id, hotelViewModel);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!this.HotelExists(hotelViewModel.Id))
                {
                    return this.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var hotel = await this.hotelsService.GetByIdAsync(id);
            if (hotel == null)
            {
                return this.NotFound();
            }

            return this.View(hotel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.hotelsService.DeleteAsync(id);

            return this.RedirectToAction(nameof(this.Index));
        }

        private bool HotelExists(int id)
        {
            return this.hotelsService.Exists(id);
        }
    }
}
