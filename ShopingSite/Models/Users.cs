using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopingSite.Models
{
    public class Users
    {
            [Key]
            public int UserId { get; set; }
            [Required]
            [MaxLength(300)]
            public string Email { get; set; }
            [Required]
            [MaxLength(50)]
            public string Password { get; set; }
            [Required]
            public DateTime RegisterDate { get; set; }
            public bool IsAdmin { get; set; }

        }

    
}
