using System.ComponentModel.DataAnnotations;

namespace RestaurantRaterMVC.Models.Restaurant
{
    public class RestaurantCreate
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Location { get; set; }
    }


}