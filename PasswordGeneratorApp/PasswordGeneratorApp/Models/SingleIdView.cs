using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PasswordGeneratorApp.Models
{
    public class SingleIdView
    {
        [Required]
        [Range(11111111,99999999, ErrorMessage ="Not A Valid ID Number !")]
        [Display(Name = "Identification Number")]
        public string IdentificationNumber { get; set; }
    }
}