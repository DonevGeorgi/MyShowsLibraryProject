namespace MyShowsLibraryProject.Core.Constants
{
    public static class MessagesConstants
    {
        public const string RequiredMessage = "The {0} field is required";

        public const string LengthMessage = "The field {0} must be between {2} and {1} characters long";

        public const string RangeMessage = "The field {0} must be in the range {1} to {2} including";

        //RegularExpresions
        public const string DataFormat = "dd-Month-YYYY";
        public const string ReleaseAndEndDateFormat = "YYYY";

        //Logger messages
        public const string EntityEditedMessage = "{0} with name {1} was edited succesfully!";
        public const string EntityDeleteMessage = "{0} with id {1} was deleted succesfully!";
        public const string EntityNotFountMessage = "{0} was not found!";
        public const string EntityIdNotFountMessage = "{0} with id {1} was not found!";
        public const string EntityCreatedMessage = "{0} with name {name} was created succesfully!";
        public const string EntityCreatedSuccesfullyMessage = "{0} created succesfully!";
        public const string EntityDeleteSuccesfullyMessage = "{0} deleted succesfully!";
        public const string EntityEditedSuccesfullyMessage = "{0} edited succesfully!";

        //Exceptiong messages
        public const string RoleDoesNotExistsMessage = "Role does not exists!";
        public const string ReviewDoesNotExistsMessage = "Review does not exists!";
        public const string ShowDoesNotExsistsMessage = "Show does not exists!";
        public const string GenreDoesNotExistsMessage = "Genre does not exists!";
        public const string CrewDoesNotExistsMessage = "Crew does not existss!";
        public const string MovieDoesNotExistsMessage = "Movie does not exists!";
        public const string SerieDoesNotExistsMessage = "Serie does not exists!";
        public const string SeasonDoesNotExistsMessage = "Season does not exists!";
        public const string EpisodeDoesNotExistsMessage = "Episode does not exists!";
        public const string MovieEditDoesNotExistMessage = "Movie you want to edit does not exists!";
        public const string SerieEditDoesNotExistMessage = "Serie you want to edit does not exists!";
    }
}
