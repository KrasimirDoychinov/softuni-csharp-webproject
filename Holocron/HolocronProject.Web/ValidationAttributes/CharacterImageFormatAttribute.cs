using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ValidationAttributes
{
    public class CharacterImageFormatAttribute : ValidationAttribute
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

