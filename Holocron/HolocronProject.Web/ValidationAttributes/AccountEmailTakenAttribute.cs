using HolocronProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ValidationAttributes
{
    public class AccountEmailTakenAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = value as string;

            var context = new HolocronDbContext();

            if (context.Accounts.Any(x => x.Email == email))
            {
                return new ValidationResult($"The email: {email} is already taken.");
            }

            return ValidationResult.Success;
        }
    }
}
