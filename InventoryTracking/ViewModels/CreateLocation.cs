using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace InventoryTracking.ViewModels
{
    public class CreateLocation
    {
        [Display(Name = "ID")]
        public int LocationId { get; set; }

        [Remote(action: "checkLocation", controller: "Location")]
        public string Name { get; set; }

        public string Address { get; set; }

        [DataType(DataType.Text)]
        public string City { get; set; }

        [Display(Name = "Post code")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        public CreateLocation()
        {
        }
    }
}

