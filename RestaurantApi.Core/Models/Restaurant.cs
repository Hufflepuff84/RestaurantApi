using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApi.Core.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Id is required")]
        public string Name { get; set; }
        [Required]
        [MaxLength(75, ErrorMessage = "Title cannot be more than 75 characters")]
        public string Owner { get; set; }
        [Required]
        public string Type { get; set; }


    }
}