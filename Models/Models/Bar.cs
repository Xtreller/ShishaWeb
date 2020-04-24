using Asp.net_Core_Project.Models.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Asp.net_Core_Project.Models
{
    public class Bar : BaseModel<int>, IDeletableModel
    {
        public Bar()
        {
            this.Comments = new HashSet<Comment>();
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public DateTime DateAdded { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
