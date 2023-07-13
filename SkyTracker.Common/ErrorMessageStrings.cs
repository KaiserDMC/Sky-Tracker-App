namespace SkyTracker.Common;

public static class ErrorMessageStrings
{
    public static class Flight
    {
        public const string FlightIdLength = "FlightId cannot be more than 9 digits.";
        public const string FlightIdRegex = "FlightId must contain only digits.";
        public const string RegistrationLength = "Registration cannot be more than 7 symbols.";
        public const string RegistrationRegex = "Registration must include only capital letters and numbers.";
        public const string EquipmentLength = "Equipment cannot be more than 5 symbols.";
        public const string EquipmentRegex = "Equipemnt must include only capital letters and numbers.";
        public const string CallsignLength = "CallSign cannot be more than 8 symbols.";
        public const string CallsignRegex = "CallSign must include only capital letters and numbers";
        public const string FlightNumberLength = "Flight number cannot be more than 12 symbols.";
        public const string FlightNumberRegex = "Flight number must include only capital letters and numbers.";
        public const string CodeIATARegex = "IATA code comprises of 3 capital letters.";
    }

    public static class Herald
    {
        public const string DetailsLength = "Details must be between 10 and 1000 symbols.";
    }
}