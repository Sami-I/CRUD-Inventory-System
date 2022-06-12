using System;
using InventoryTracking.Models;

namespace InventoryTracking.ViewModels
{
    public class LocationDetails
    {
        public Location Location { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public LocationDetails()
        {
        }
    }
}

