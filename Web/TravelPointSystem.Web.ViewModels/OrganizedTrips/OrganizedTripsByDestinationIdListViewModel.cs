﻿namespace TravelPointSystem.Web.ViewModels.OrganizedTrips
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using TravelPointSystem.Data.Models;

    public class OrganizedTripsByDestinationIdListViewModel
    {
        public int NumberOfTourists { get; set; }

        public IEnumerable<OrganizedTripViewModel> OrganizedTrips { get; set; }
    }
}
