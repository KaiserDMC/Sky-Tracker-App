namespace SkyTracker.Common;

public static class ErrorMessageStrings
{
    public static class Aircraft
    {
        public const string AircraftIdLengthError = "The ID must be between {2} and {1} symbols.";
        public const string AircraftIdRegexError = "The ID must contain only digits.";
        public const string RegistrationLengthError = "The registration must be between {2} and {1} symbols.";
        public const string RegistrationRegexError = "The registration must contain only capital letters and digits.";
        public const string EquipmentLengthError = "The equipment must be between {2} and {1} symbols.";
        public const string EquipmentRegexError = "The equipment must contain only capital letters and digits.";
    }

    public static class Flight
    {
        public const string FlightIdLength = "FlightId must be between {2} and {1} symbols.";
        public const string FlightIdRegex = "FlightId must contain only digits.";
        public const string CallsignLength = "CallSign must be between {2} and {1} symbols.";
        public const string CallsignRegex = "CallSign must include only capital letters and numbers";
        public const string FlightNumberLength = "Flight number must be between {2} and {1} symbols.";
        public const string FlightNumberRegex = "Flight number must include only capital letters and numbers.";
        public const string CodeIATARegex = "IATA code comprises of EXACTLY 3 capital letters.";
    }

    public static class Herald
    {
        public const string DetailsLength = "Details must be between {2} and {1} symbols.";
    }

    public static class Airport
    {
        public const string IATALength = "IATA code comprises of EXACTLY 3 capital letters.";
        public const string ICAOLength = "ICAO code comprises of EXACTLY 4 capital letters.";
        public const string CommonNameLength = "Airport name must be between {2} and {1} symbols.";
        public const string ElevRegex = "Elevation has to be with the following syntax: \"number ft\"";
        public const string CityLength = "The City name must be between {2} and {1} symbols.";
        public const string CountryLength = "The Country name must be between {2} and {1} symbols.";
        public const string LatLongRegex = "Latitude and Longitude must be decimal representation of WGS84 coordinates, example syntax: \"xx.xxx\" or \"-xx.xxx\"";
    }

    public static class Runway
    {
        public const string RunwayDesignatorError = "Runway designator must be between 1 and 2 numbers. It is possible to have subdesignations with R and L.";
        public const string RunwayLengthError = "Runway length must be between {2} and {1} numbers and represents the length of the runway in metres.";
        public const string WidthLenghError = "Runway width must be between {2} and {1} numbers and represents the width of the runway in metres.";
    }

    public static class PersonalData
    {
        public const string PersonalDataMessage = "Please type 'DELETE' to confirm.";
    }

    public static class PasswordChange
    {
        public const string PasswordErrorMessageLength = "The {0} must be at least {2} and at max {1} characters long.";
        public const string PasswordErrorMessageConfirmation = "The new password and confirmation password do not match.";
    }

    public static class PhoneChange
    {
        public const string PhoneErrorMessage = "Please enter your new phone number.";
    }

    public static class UserCheck
    {
        public const string UsernameLengthError = "The username must be between {2} and {1} symbols.";
        public const string UsernameRegexError = "The username must contain only letters, digits and underscores.";
        public const string PasswordLengthError = "The password must be between {2} and {1} symbols.";
        public const string PasswordConfirmationError = "The password and confirmation password do not match.";
    }
}