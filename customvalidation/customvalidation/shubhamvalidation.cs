using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace customvalidation
{
    public class shubhamvalidation : ValidationAttribute

    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string message = value.ToString();
                if (message.Contains("shubham"){
                    return ValidationResult.Success;
                }
               
            }
            return new ValidationResult("field must contain shubham");
        }
    }
}