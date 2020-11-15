using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Common
{
    public class GlobalErrorMessages
    {
        public static class AccountErrorMessages
        {
            public const string PasswordLengthError = "The password must be between {2} and {1} characters long.";

            public const string UserNameLengthError = "The user name must be between {2} and {1} characters.";

            public const string UserNameRegexError = "The display name cannot contain special characters or spaces.";

        }

        public static class CharacterErrorMessages
        {
            public const string NameMaxLengthError = "The character name cannot contain more than 25 characters.";

            public const string BackstoryMaxLengthError = "The character's backstory cannot be more than 25,000 characters.";

            public const string TitleMaxLengthError = "The character's title cannot be more than 25 characters.";

            public const string InvalidGenderError = "Each character must have a gender.";

            public const string InvalidCharacterTypeError = "Each character must have a type.";

            public const string InvalidForceAffiliationError = "Each character must have force affiliation.";

        }
    }
}
