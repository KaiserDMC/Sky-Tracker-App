namespace SkyTracker.Common;

/// <summary>
/// Constants and regular expressions for data model validations.
/// </summary>

public static class DataModelsValidationConstants
{
    public static class Aircraft
    {
        public const int AircraftIdLengthMax = 60;
        public const int AircraftIdLengthMin = 5;
        public const string AircraftIdRegexPattern = @"[0-9]+$";

        public const int RegistrationLengthMax = 7;
        public const int RegistrationLengthMin = 3;
        public const string RegistrationRegexPattern = @"[A-Z0-9]+$";

        public const int EquipmentLengthMax = 6;
        public const int EquipmentLengthMin = 2;
        public const string EquipmentRegexPattern = @"[A-Z0-9]+$";
    }

    public static class Flight
    {
        public const int FlightIdLengthMax = 9;
        public const int FlightIdLengthMin = 4;
        public const string FlightIdRegexPattern = @"[0-9]+$";

        public const int RegistrationLengthMax = 7;
        public const string RegistrationRegexPattern = @"[A-Z0-9]+$";

        public const int EquipmentLengthMax = 6;
        public const string EquipmentRegexPattern = @"[A-Z0-9]+$";

        public const int CallsignLengthMax = 8;
        public const int CallsignLengthMin = 3;
        public const string CallsignRegexPattern = @"[A-Z0-9]+$";

        public const int FlightNumberLengthMax = 12;
        public const int FlightNumberLengthMin = 3;
        public const string FlightNumberRegexPattern = @"[A-Z0-9]+$";

        public const string CodeIATA = @"[A-Z]{3}$";
    }

    public static class Airport
    {
        public const int CodeIATALengthMax = 3;
        public const int CodeIATALengthMin = 3;
        public const string CodeIATA = @"[A-Z]{3}$";
        public const int CodeICAOLengthMax = 4;
        public const int CodeICAOLengthMin = 4;
        public const string CodeICAO = @"[A-Z]{4}$";
        public const int NameLengthMax = 150;
        public const int NameLengthMin = 3;
        public const string Name = @"[A-Za-z ]+$";
        public const string Elev = @"[0-9]+ ft$";
        public const int CityLengthMax = 150;
        public const int CityLengthMin = 3;
        public const int CountryLengthMax = 150;
        public const int CountryLengthMin = 3;
        public const string LatLongRegexPattern = @"^(-?\d+(\.\d+)?)$";
    }

    public static class Runway
    {
        public const string DesignatorRegexPattern = @"^(0[1-9]|[1-2][0-9]|3[0-6])([RL])?$";
        public const string LengthRegexPattern = @"^[0-9]+$";
        public const int LengthLengthMax = 5;
        public const int LengthLengthMin = 3;
        public const string WidthRegexPattern = @"^[0-9]+$";
        public const int WidthLengthMax = 4;
        public const int WidthLengthMin = 2;
    }

    public static class HeraldPost
    {
        public const string DateFormat = "yyyy-MM-dd";
        public const string DateString = "yyyy-MM-dd";
        public const int DetailsLengthMax = 2000;
        public const int DetailsLengthMin = 10;
    }

    public static class Password
    {
        public const int PasswordLengthMin = 6;
        public const int PasswordLengthMax = 100;
    }

    public static class UserCheck
    {
        public const int UsernameLengthMin = 3;
        public const int UsernameLengthMax = 20;
        public const string UsernameRegexPattern = @"^\w+$";
        
    }
}