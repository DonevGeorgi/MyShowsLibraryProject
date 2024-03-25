﻿namespace MyShowsLibraryProject.Infrastructure.Constants
{
    public static class DataConstants
    {
        //Universal constants
        public const int UrlMinLength = 30;
        public const int TitleMinLength = 1;
        public const int TitleMaxLength = 255;
        public const int UrlsMaxLength = 255;
        public const int YearMaxLength = 4;
        public const int SummaryMinLength = 30;
        public const int SummaryMaxLength = 255;
        public const int LenguageMinLength = 2;
        public const int LenguageMaxLength = 30;
        //Movie
        public const int MovieReleaseDateMaxLength = 11;
        //Serie constants
        public const int SerieLenguageMaxLength = 30;
        //Season constants
        public const int SeasonEpisodeMaxLength = 5;
        //Crew constants
        public const int CrewBirthdayMaxLength = 11;
        public const int CrewNameMaxLength = 50;
        public const int CrewPseudonymMaxLength = 50;
        public const int CrewNationalityMaxLength = 30;
        public const int CrewBiographyMaxLength = 8000;
        //Episode constants
        public const int EpisodeReleaseDateMaxLength = 11;
        //Review constants 
        public const int ReviewContentMaxLength = 8000;
        public const int RatingMaxLength = 5;
        public const int RatingMinLength = 1;
        //Genre constants
        public const int GenreNameMaxLength = 30;
        //Role constants
        public const int RoleNameMaxLength = 30;
        //ReqularExpresions
        public const string ReleaseDataRegex = @"(?:(?:0[1-9]|[12]\d|30)\s(?:Jan|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov)|(?:0[1-9]|[12]\d|3[01])\s(?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Dec))\s(?:[1-9]\d{3}|(?:19|20)\d{2})";
        public const string ReleaseAndEndYearRegex = @"^(19|20)\d{2}$";
    }
}