using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Web.ValidationAttributes
{
    public class AccountAvatarImageAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var image = value as IFormFile;

            if (image == null)
            {
                return ValidationResult.Success;
            }

            var format = Image.DetectFormat(image.OpenReadStream());

            if (format == null ||
                format.Name != "JPEG" &&
                format.Name != "PNG" &&
                format.Name != "JPG")
            {
                return new ValidationResult("Only .jpeg, .jpg and .png formats are accepted.");
            }

            return ValidationResult.Success;
        }
    }
}
