using Asp.net_Core_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Asp.net_Core_Project.ViewModels
{
    
    public class AddBarInputModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Town { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string ImageURL { get; set; }
    }
}
