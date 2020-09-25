using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RescueYourPet.Models
{
    public class Email
    {
        [Key]
        public int EmailId { get; set; }


        [Required]
        [Display(Name = "Pless enter your email address")]
        public string EmailAddress { get; set; }

    }
}
