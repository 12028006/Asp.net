using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace validationinMVC_.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "field not should be blank !")]
        public string Firstname { get; set; } 
        [Required (ErrorMessage = "field must content your lastname")]
        public string Lastname { get; set; }
        [Required]
        [EmailAddress (ErrorMessage = "email is not valid !")]
        public string Email { get; set; }

        [Required]
        [Range(0,100)]
        public int Age { get; set; }
    }
}