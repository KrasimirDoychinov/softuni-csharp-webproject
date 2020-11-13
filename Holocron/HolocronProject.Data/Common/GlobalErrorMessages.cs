using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Common
{
    public class GlobalErrorMessages
    {
        public static class AccountErrorMessages
        {
            public const string DisplayNameLengthError = "The display name cannot be more thatn 25 characters.";
        }

        public static class CharacterErrorMessages
        {
            public const string NameMaxLengthError = "The character name cannot contain more than 25 characters.";

            public const string BackstoryMaxLengthError = "The character's backstory cannot be more than 25,000 characters.";

            public const string TitleMaxLengthError = "The character's title cannot be more than 25 characters.";

            public const string InvalidGenderError = "A character must have a gender.";

            public const string InvalidCharacterTypeError = "A character must have a type.";

            public const string InvalidForceAffiliationError = "Each character must have force affiliation.";
        }
    }
}
