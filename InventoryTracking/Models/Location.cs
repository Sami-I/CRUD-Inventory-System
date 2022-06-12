using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace InventoryTracking.Models
{
    public class Location
    {
        [Display(Name = "ID")]
        public int LocationId { get; set; }

        [Remote(action: "checkLocation", controller: "Location")]
        public string Name { get; set; }

        public Location()
        {
        }
    }
}

