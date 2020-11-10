using HolocronProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HolocronProject.Web.ValidationAttributes
{
    public class CharacterNameInServerAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var name = value as string;

            // Useful code
            object instance = validationContext.ObjectInstance;
            var type = instance.GetType();
            var property = type.GetProperty("Server");
            object serverName = property.GetValue(instance);

            using ( var context = new HolocronDbContext())
            {
                if (context.Characters.Any(x => x.Name == name && x.Server.Name == serverName))
                {
                    return new ValidationResult($"The character name {name} is already taken on {serverName}.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
