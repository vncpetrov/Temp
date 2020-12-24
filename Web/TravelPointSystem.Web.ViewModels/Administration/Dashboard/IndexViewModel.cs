﻿namespace TravelPointSystem.Web.ViewModels.Administration.Dashboard
{
    using System.Collections.Generic;

    using TravelPointSystem.Web.ViewModels.Reservations;

    public class IndexViewModel
    {
        public int ReservationsCount { get; set; }

        public int NotAcceptedReservationsCount { get; set; }

        public int UsersCount { get; set; }

        public IEnumerable<ReservationViewModel> Lastest5Reservations { get; set; }
    }
}
