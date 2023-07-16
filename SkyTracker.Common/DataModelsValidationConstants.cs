﻿namespace SkyTracker.Common;

public static class DataModelsValidationConstants
{
    public static class Aircraft
    {
        public const int AircraftIdLengthMax = 60;
        public const string AircraftIdRegexPattern = @"[0-9]+$";

        public const int EquipmentLengthMax = 5;
        public const string EquipmentRegexPattern = @"[A-Z0-9]+$";

        public const int RegistrationLengthMax = 7;
        public const string RegistrationRegexPattern = @"[A-Z0-9]+$";
    }

    public static class Flight
    {
        public const int FlightIdLengthMax = 9;
        public const string FlightIdRegexPattern = @"[0-9]+$";

        public const int RegistrationLengthMax = 7;
        public const string RegistrationRegexPattern = @"[A-Z0-9]+$";

        public const int EquipmentLengthMax = 5;
        public const string EquipmentRegexPattern = @"[A-Z0-9]+$";

        public const int CallsignLengthMax = 8;
        public const string CallsignRegexPattern = @"[A-Z0-9]+$";

        public const int FlightNumberLengthMax = 12;
        public const string FlightNumberRegexPattern = @"[A-Z0-9]+$";

        public const string CodeIATA = @"[A-Z]{3}$";
    }

    public static class Airport
    {
        public const string CodeIATA = @"[A-Z]{3}$";
        public const string CodeICAO = @"[A-Z]{4}$";
        public const string Name = @"[A-Za-z ]+$";
        public const int NameLengthMax = 150;
        public const string Elev = @"[0-9]+ ft$";
        public const int CityLengthMax = 150;
        public const int CountryLengthMax = 150;
        public const string LatLongRegexPattern = @"^(-?\d+(\.\d+)?)$";
    }

    public static class Runway
    {
        public const string DesignatorRegexPattern = @"^(0[1-9]|[1-2][0-9]|3[0-6])([RL])?$";
    }

    public static class HeraldPost
    {
        public const string DateFormat = "yyyy-MM-dd";
        public const string DateString = "yyyy-MM-dd";
        public const int DetailsLengthMax = 1000;
        public const int DetailsLengthMin = 10;
    }
}