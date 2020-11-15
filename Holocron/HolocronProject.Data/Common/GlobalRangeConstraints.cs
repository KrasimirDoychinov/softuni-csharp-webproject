﻿namespace HolocronProject.Data.Common
{
    public static class GlobalRangeConstraints
    {
        public static class AccountConstants
        {
            public const string UserNameRegex = @"^[a-zA-Z0-9!@#$%^&*()_+=[\]\\|;:,<.>/?{}-]*$";

            public const string DisplayNameRegex = @"^[a-zA-Z0-9]*$";

            public const int DisplayNameMaxLength = 25;

            public const int UserNameMinLenght = 6;

            public const int UserNameMaxLenght = 30;

            public const int PasswordMinLength = 8;

            public const int PasswordMaxLength = 100;
        }

        public static class CharacterConstants
        {
            public const int NameMaxLength = 25;

            public const int BackstoryMaxLength = 25000;

            public const int TitleMaxLength = 25;

        }

        public static class PostConstants
        {
            public const int DescriptionMaxLength = 10000;
        }

        public static class ThreadConstants
        {
            public const int TitleMaxLength = 150;
        }

        public static class TagConstants
        {
            public const int NameMaxLength = 15;
        }

        public static class ReportConstants
        {
            public const int TitleMaxLength = 50;

            public const int DescriptionMaxLength = 10000;
        }

        public static class AchievementConstants
        {
            public const int NameMaxLength = 50;
        }

        public static class CompetitionConstants
        {
            public const int TitleMaxLength = 50;

            public const int DescriptionMaxLength = 10000;
        }

    }
}