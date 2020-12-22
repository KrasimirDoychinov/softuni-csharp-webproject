using HolocronProject.Data;
using HolocronProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ValidationAttributes
{
    public class EmailTakenAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = value as string;

            var context = new ApplicationDbContext();

            if (context.Accounts
                .Any(x => x.Email == email))
            {
                return new ValidationResult($"The email: {email} is already taken.");
            }

            return ValidationResult.Success;

        }
    }
}
