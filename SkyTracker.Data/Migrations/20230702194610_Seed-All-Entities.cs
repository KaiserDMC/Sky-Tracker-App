using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyTracker.Data.Migrations
{
    public partial class SeedAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aircraft",
                columns: new[] { "Id", "Equipment", "Registration" },
                values: new object[,]
                {
                    { "10594670", "B06", "N206MP" },
                    { "10658329", "C208", "N269TD" },
                    { "10801158", "BN2P", "N409WB" },
                    { "12610754", "R44", "CGPEV" },
                    { "4735111", "DHC6", "PJWIQ" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "IATA", "ICAO" },
                values: new object[,]
                {
                    { "ANC", null },
                    { "BID", null },
                    { "BUF", null },
                    { "ENA", null },
                    { "GKT", null },
                    { "IAG", null },
                    { "SAB", null },
                    { "SBH", null },
                    { "SXM", null },
                    { "WST", null },
                    { "YCM", null },
                    { "YHM", null },
                    { "YKF", null }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Callsign", "DepartureId", "Equipment", "FlightNumber", "RealArrival", "Registration", "Reserved", "ScheduledArrival" },
                values: new object[,]
                {
                    { "679614404", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679635572", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679643668", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679650031", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679657990", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679662640", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679668617", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679671482", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679707362", "CGPEV", "YKF", "R44", null, "YCM", "CGPEV", "", "YCM" },
                    { "679709505", "WIA401", "SXM", "DHC6", null, "SAB", "PJWIQ", "", "SAB" },
                    { "679713624", "CGPEV", "YCM", "R44", null, "BUF", "CGPEV", "", "BUF" },
                    { "679716540", "WIA402", "SAB", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679719352", "CGPEV", "BUF", "R44", null, "YHM", "CGPEV", "", "YHM" },
                    { "679720729", "WIA623", "SXM", "DHC6", null, "SBH", "PJWIQ", "", "SBH" },
                    { "679726997", "CGPEV", "YHM", "R44", null, "YCM", "CGPEV", "", "YCM" },
                    { "679727537", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679727922", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679733154", "CGPEV", "YCM", "R44", null, "IAG", "CGPEV", "", "IAG" },
                    { "679734609", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679739359", "CGPEV", "IAG", "R44", null, "YHM", "CGPEV", "", "YHM" },
                    { "679740984", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679744597", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679747205", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679747520", "CGPEV", "YHM", "R44", null, "YCM", "CGPEV", "", "YCM" },
                    { "679748590", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679750895", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679753739", "CGPEV", "YCM", "R44", null, "IAG", "CGPEV", "", "IAG" },
                    { "679757090", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679757567", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679758316", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679760166", "WIA624", "SBH", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679761752", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679764400", "CGPEV", "IAG", "R44", null, "YHM", "CGPEV", "", "YHM" },
                    { "679765495", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679765704", "N206MP", "GKT", "B06", null, "MOR", "N206MP", "", "MOR" },
                    { "679767637", "WIA631", "SXM", "DHC6", null, "SBH", "PJWIQ", "", "SBH" },
                    { "679770174", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679771458", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679773916", "WIA632", "SBH", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679774436", "CGPEV", "YHM", "R44", null, "YCM", "CGPEV", "", "YCM" },
                    { "679774768", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679777572", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Callsign", "DepartureId", "Equipment", "FlightNumber", "RealArrival", "Registration", "Reserved", "ScheduledArrival" },
                values: new object[,]
                {
                    { "679780795", "CGPEV", "YCM", "R44", null, "IAG", "CGPEV", "", "IAG" },
                    { "679781850", "WIA641", "SXM", "DHC6", null, "SBH", "PJWIQ", "", "SBH" },
                    { "679784404", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679784563", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679790096", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679790185", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679790844", "WIA642", "SBH", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679790845", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679791388", "CGPEV", "IAG", "R44", null, "YHM", "CGPEV", "", "YHM" },
                    { "679791496", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679794482", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679796785", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679797902", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679798112", "WIA651", "SXM", "DHC6", null, "SBH", "PJWIQ", "", "SBH" },
                    { "679802343", "CGPEV", "YHM", "R44", null, "YCM", "CGPEV", "", "YCM" },
                    { "679803664", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679803953", "WIA652", "SBH", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679804347", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679808241", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679809739", "CGPEV", "YCM", "R44", null, "BUF", "CGPEV", "", "BUF" },
                    { "679811120", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679812684", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679814645", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679814796", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679816192", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679817699", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679818403", "WIA659", "SXM", "DHC6", null, "SBH", "PJWIQ", "", "SBH" },
                    { "679818719", "CGPEV", "BUF", "R44", null, "YHM", "CGPEV", "", "YHM" },
                    { "679819640", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679821595", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679822399", "WIA660", "SBH", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679823514", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679823946", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679826809", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679828409", "WIA671", "SXM", "DHC6", null, "SBH", "PJWIQ", "", "SBH" },
                    { "679828515", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679831846", "CGPEV", "YHM", "R44", null, "YCM", "CGPEV", "", "YCM" },
                    { "679832266", "WIA672", "SBH", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679834468", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679835660", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679837628", "CGPEV", "YCM", "R44", null, "BUF", "CGPEV", "", "BUF" },
                    { "679839081", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "Callsign", "DepartureId", "Equipment", "FlightNumber", "RealArrival", "Registration", "Reserved", "ScheduledArrival" },
                values: new object[,]
                {
                    { "679841780", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679842417", "N409WB", "WST", "BN2P", null, "BID", "N409WB", "", "BID" },
                    { "679843338", "WIA441", "SXM", "DHC6", null, "SAB", "PJWIQ", "", "SAB" },
                    { "679844139", "CGPEV", "BUF", "R44", null, "YHM", "CGPEV", "", "YHM" },
                    { "679846327", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679846352", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679847956", "WIA441", "SAB", "DHC6", null, "SXM", "PJWIQ", "", "SXM" },
                    { "679850961", "CGPEV", "YHM", "R44", null, "YCM", "CGPEV", "", "YCM" },
                    { "679851834", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679853082", "WIA442", "SXM", "DHC6", null, "EUX", "PJWIQ", "", "EUX" },
                    { "679854848", "N269TD", "ENA", "C208", null, "ANC", "N269TD", "", "ANC" },
                    { "679855207", "N206MP", "GKT", "B06", null, "TYS", "N206MP", "", "TYS" },
                    { "679856747", "CGPEV", "YCM", "R44", null, "BUF", "CGPEV", "", "BUF" },
                    { "679861117", "N269TD", "ANC", "C208", null, "ENA", "N269TD", "", "ENA" },
                    { "679862566", "N409WB", "BID", "BN2P", null, "WST", "N409WB", "", "WST" },
                    { "679863999", "CGPEV", "BUF", "R44", null, "YHM", "CGPEV", "", "YHM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Id",
                keyValue: "10594670");

            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Id",
                keyValue: "10658329");

            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Id",
                keyValue: "10801158");

            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Id",
                keyValue: "12610754");

            migrationBuilder.DeleteData(
                table: "Aircraft",
                keyColumn: "Id",
                keyValue: "4735111");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679614404");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679635572");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679643668");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679650031");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679657990");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679662640");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679668617");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679671482");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679707362");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679709505");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679713624");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679716540");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679719352");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679720729");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679726997");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679727537");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679727922");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679733154");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679734609");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679739359");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679740984");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679744597");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679747205");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679747520");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679748590");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679750895");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679753739");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679757090");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679757567");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679758316");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679760166");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679761752");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679764400");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679765495");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679765704");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679767637");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679770174");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679771458");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679773916");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679774436");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679774768");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679777572");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679780795");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679781850");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679784404");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679784563");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679790096");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679790185");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679790844");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679790845");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679791388");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679791496");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679794482");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679796785");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679797902");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679798112");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679802343");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679803664");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679803953");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679804347");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679808241");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679809739");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679811120");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679812684");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679814645");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679814796");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679816192");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679817699");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679818403");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679818719");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679819640");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679821595");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679822399");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679823514");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679823946");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679826809");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679828409");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679828515");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679831846");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679832266");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679834468");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679835660");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679837628");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679839081");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679841780");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679842417");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679843338");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679844139");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679846327");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679846352");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679847956");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679850961");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679851834");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679853082");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679854848");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679855207");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679856747");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679861117");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679862566");

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: "679863999");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "ANC");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "BID");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "BUF");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "ENA");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "GKT");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "IAG");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SAB");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SBH");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SXM");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "WST");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YCM");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YHM");

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YKF");
        }
    }
}
