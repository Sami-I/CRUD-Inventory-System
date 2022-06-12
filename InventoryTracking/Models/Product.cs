using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace InventoryTracking.Models
{
    public class Product
    {
        [Display(Name = "ID")]
        public int ProductId { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public string Details { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Location")]
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        public Product()
        {
        }
    }
}

