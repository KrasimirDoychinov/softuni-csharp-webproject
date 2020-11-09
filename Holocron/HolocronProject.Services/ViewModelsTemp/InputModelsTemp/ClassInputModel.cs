using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HolocronProject.Services.ViewModelsTemp.InputModelsTemp
{
    public class ClassInputModel : IValidatableObject
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Name.Length > this.SecondName.Length)
            {
                yield return new ValidationResult("First name cannot be longer than the second name.");
            }
        }
    }
}
