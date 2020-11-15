using HolocronProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ValidationAttributes
{
    public class AccountDisplayNameTakenAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var displayName = value as string;

            var context = new HolocronDbContext();

            if (context.Accounts.Any(x => x.DisplayName == displayName))
            {
                return new ValidationResult($"The display name: {displayName} is already taken.");
            }

            return ValidationResult.Success;
        }
    }
}
