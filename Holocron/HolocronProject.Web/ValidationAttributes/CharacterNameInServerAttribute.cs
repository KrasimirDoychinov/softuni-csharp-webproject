using HolocronProject.Data;
using HolocronProject.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
            var property = type.GetProperty("ServerId");
            object serverName = property.GetValue(instance);

            var context = new HolocronDbContext();

            if (context.Characters
                .Where(x => x.CharacterStatus == CharacterStatus.Approved)
                .Any(x => x.Name == name && x.Server.Name == serverName))
            {
                return new ValidationResult($"The character name: {name} is already taken on: {serverName}.");
            }

            return ValidationResult.Success;


        }
    }
}
