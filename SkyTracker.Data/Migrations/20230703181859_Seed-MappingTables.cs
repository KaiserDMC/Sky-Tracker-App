using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyTracker.Data.Migrations
{
    public partial class SeedMappingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FlightsAircraft",
                columns: new[] { "AircraftId", "FlightId" },
                values: new object[,]
                {
                    { "10801158", "679614404" },
                    { "10658329", "679635572" },
                    { "10658329", "679643668" },
                    { "10658329", "679650031" },
                    { "10658329", "679657990" },
                    { "10658329", "679662640" },
                    { "10658329", "679668617" },
                    { "10658329", "679671482" },
                    { "12610754", "679707362" },
                    { "4735111", "679709505" },
                    { "12610754", "679713624" },
                    { "4735111", "679716540" },
                    { "12610754", "679719352" },
                    { "4735111", "679720729" },
                    { "12610754", "679726997" },
                    { "10658329", "679727537" },
                    { "10801158", "679727922" },
                    { "12610754", "679733154" },
                    { "10801158", "679734609" },
                    { "12610754", "679739359" },
                    { "10801158", "679740984" },
                    { "10658329", "679744597" },
                    { "10801158", "679747205" },
                    { "12610754", "679747520" },
                    { "10594670", "679748590" },
                    { "10594670", "679750895" },
                    { "12610754", "679753739" },
                    { "10594670", "679757090" },
                    { "10658329", "679757567" },
                    { "10801158", "679758316" },
                    { "4735111", "679760166" },
                    { "10594670", "679761752" },
                    { "12610754", "679764400" },
                    { "10801158", "679765495" },
                    { "10594670", "679765704" },
                    { "4735111", "679767637" },
                    { "10594670", "679770174" },
                    { "10801158", "679771458" },
                    { "4735111", "679773916" },
                    { "12610754", "679774436" },
                    { "10658329", "679774768" },
                    { "10801158", "679777572" }
                });

            migrationBuilder.InsertData(
                table: "FlightsAircraft",
                columns: new[] { "AircraftId", "FlightId" },
                values: new object[,]
                {
                    { "12610754", "679780795" },
                    { "4735111", "679781850" },
                    { "10594670", "679784404" },
                    { "10801158", "679784563" },
                    { "10594670", "679790096" },
                    { "10658329", "679790185" },
                    { "4735111", "679790844" },
                    { "10801158", "679790845" },
                    { "12610754", "679791388" },
                    { "10594670", "679791496" },
                    { "10594670", "679794482" },
                    { "10594670", "679796785" },
                    { "10801158", "679797902" },
                    { "4735111", "679798112" },
                    { "12610754", "679802343" },
                    { "10658329", "679803664" },
                    { "4735111", "679803953" },
                    { "10801158", "679804347" },
                    { "10594670", "679808241" },
                    { "12610754", "679809739" },
                    { "10594670", "679811120" },
                    { "10594670", "679812684" },
                    { "10658329", "679814645" },
                    { "10594670", "679814796" },
                    { "10801158", "679816192" },
                    { "10594670", "679817699" },
                    { "4735111", "679818403" },
                    { "12610754", "679818719" },
                    { "10594670", "679819640" },
                    { "10594670", "679821595" },
                    { "4735111", "679822399" },
                    { "10658329", "679823514" },
                    { "10594670", "679823946" },
                    { "10594670", "679826809" },
                    { "4735111", "679828409" },
                    { "10594670", "679828515" },
                    { "12610754", "679831846" },
                    { "4735111", "679832266" },
                    { "10801158", "679834468" },
                    { "10658329", "679835660" },
                    { "12610754", "679837628" },
                    { "10801158", "679839081" }
                });

            migrationBuilder.InsertData(
                table: "FlightsAircraft",
                columns: new[] { "AircraftId", "FlightId" },
                values: new object[,]
                {
                    { "10658329", "679841780" },
                    { "10801158", "679842417" },
                    { "4735111", "679843338" },
                    { "12610754", "679844139" },
                    { "10801158", "679846327" },
                    { "10594670", "679846352" },
                    { "4735111", "679847956" },
                    { "12610754", "679850961" },
                    { "10594670", "679851834" },
                    { "4735111", "679853082" },
                    { "10658329", "679854848" },
                    { "10594670", "679855207" },
                    { "12610754", "679856747" },
                    { "10658329", "679861117" },
                    { "10801158", "679862566" },
                    { "12610754", "679863999" }
                });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[,]
                {
                    { "ANC", "3810e112-0eae-4a9e-9411-42899456e129" },
                    { "WST", "28651038-578f-4cb7-adb8-19c8d537ff76" },
                    { "ENA", "2e1dd28f-a789-47e9-8a0e-c42d399f94cb" },
                    { "SAB", "43295f10-f22a-4c56-b915-addf10f7812a" },
                    { "IAG", "6f07d234-ee7e-4aa9-bc85-04c5e59a49b9" },
                    { "BUF", "88b0d7da-1dad-44a6-8d99-a2db18edb41b" },
                    { "SXM", "8f8b2955-624e-4cec-9bb8-f0a82f815438" },
                    { "YKF", "9a160602-21e9-40d3-bd2e-1a77110602a4" },
                    { "YCM", "b3aee5cd-6660-4350-9470-c6162b1d7671" },
                    { "BID", "c43dd996-afab-406c-a1c9-885bfe61cb19" },
                    { "GKT", "d8967bb2-9236-4464-acce-29715cc16f9a" },
                    { "YHM", "023e0139-b6d2-4701-b9f1-9e597cfc98d6" },
                    { "SBH", "133f49c3-7752-42b9-9ebc-9933ebb77ae9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679614404" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679635572" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679643668" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679650031" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679657990" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679662640" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679668617" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679671482" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679707362" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679709505" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679713624" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679716540" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679719352" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679720729" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679726997" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679727537" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679727922" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679733154" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679734609" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679739359" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679740984" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679744597" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679747205" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679747520" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679748590" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679750895" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679753739" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679757090" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679757567" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679758316" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679760166" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679761752" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679764400" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679765495" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679765704" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679767637" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679770174" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679771458" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679773916" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679774436" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679774768" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679777572" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679780795" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679781850" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679784404" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679784563" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679790096" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679790185" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679790844" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679790845" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679791388" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679791496" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679794482" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679796785" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679797902" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679798112" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679802343" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679803664" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679803953" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679804347" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679808241" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679809739" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679811120" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679812684" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679814645" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679814796" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679816192" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679817699" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679818403" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679818719" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679819640" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679821595" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679822399" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679823514" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679823946" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679826809" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679828409" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679828515" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679831846" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679832266" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679834468" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679835660" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679837628" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679839081" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679841780" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679842417" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679843338" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679844139" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679846327" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679846352" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679847956" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679850961" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679851834" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "4735111", "679853082" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679854848" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10594670", "679855207" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679856747" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10658329", "679861117" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "10801158", "679862566" });

            migrationBuilder.DeleteData(
                table: "FlightsAircraft",
                keyColumns: new[] { "AircraftId", "FlightId" },
                keyValues: new object[] { "12610754", "679863999" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ANC", "3810e112-0eae-4a9e-9411-42899456e129" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "WST", "28651038-578f-4cb7-adb8-19c8d537ff76" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ENA", "2e1dd28f-a789-47e9-8a0e-c42d399f94cb" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SAB", "43295f10-f22a-4c56-b915-addf10f7812a" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "IAG", "6f07d234-ee7e-4aa9-bc85-04c5e59a49b9" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BUF", "88b0d7da-1dad-44a6-8d99-a2db18edb41b" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SXM", "8f8b2955-624e-4cec-9bb8-f0a82f815438" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YKF", "9a160602-21e9-40d3-bd2e-1a77110602a4" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YCM", "b3aee5cd-6660-4350-9470-c6162b1d7671" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BID", "c43dd996-afab-406c-a1c9-885bfe61cb19" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "GKT", "d8967bb2-9236-4464-acce-29715cc16f9a" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YHM", "023e0139-b6d2-4701-b9f1-9e597cfc98d6" });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SBH", "133f49c3-7752-42b9-9ebc-9933ebb77ae9" });
        }
    }
}
