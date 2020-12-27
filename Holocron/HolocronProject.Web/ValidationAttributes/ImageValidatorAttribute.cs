using System.ComponentModel.DataAnnotations;

using SixLabors.ImageSharp;

using Microsoft.AspNetCore.Http;

namespace HolocronProject.Web.ValidationAttributes
{
    public class ImageValidatorAttribute : ValidationAttribute
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
