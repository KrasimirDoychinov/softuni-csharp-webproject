using HolocronProject.Data;
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
            var property = type.GetProperty("Server");
            object serverName = property.GetValue(instance);

            var context = new HolocronDbContext();

            if (context.Characters.Any(x => x.Name == name && x.Server.Name == serverName))
            {
                return new ValidationResult($"The character name: {name} is already taken on: {serverName}.");
            }

            return ValidationResult.Success;


        }
    }
}
