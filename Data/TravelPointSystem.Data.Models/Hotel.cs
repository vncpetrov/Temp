﻿namespace TravelPointSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TravelPointSystem.Data.Common.Models;
    using TravelPointSystem.Data.Models.Enums;

    public class Hotel : BaseDeletableModel<int>
    {
        public Hotel()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.IsDeleted = false;
            this.OrganizedTrips = new HashSet<OrganizedTrip>();
            this.Reservations = new HashSet<Reservation>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int DestinationId { get; set; }

        public Destination Destination { get; set; }

        [Required]
        public double PricePerNightPerPerson { get; set; }

        [Required]
        public int Stars { get; set; }

        [Required]
        public int AvailableRooms { get; set; }

        public FeedingType FeedingType { get; set; }

        [Required]
        public ReservationType ReservationType { get; set; }

        public ICollection<OrganizedTrip> OrganizedTrips { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
