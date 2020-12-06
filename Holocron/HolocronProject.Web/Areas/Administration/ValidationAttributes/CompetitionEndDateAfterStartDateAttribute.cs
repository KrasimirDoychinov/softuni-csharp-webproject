using HolocronProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.ValidationAttributes
{
    public class CompetitionEndDateAfterStartDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var endDate = DateTime.Parse(value.ToString());

            // Useful code
            object instance = validationContext.ObjectInstance;
            var type = instance.GetType();
            var property = type.GetProperty("StartDate");
            var startDate = DateTime.Parse(property.GetValue(instance).ToString());
            
            if (endDate > startDate)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("The end date cannot be before the start date.");
            }

            


        }
    }
}
