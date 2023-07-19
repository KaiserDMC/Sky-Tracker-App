using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyTracker.Data.Migrations
{
    public partial class TestARP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("375b90c6-adb5-47e4-b271-069c3c496e79"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5a724e4-7a34-470d-a6ca-007c079ee4d3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e9793c4-bf72-4fb0-b0e0-768a854609ca"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b64bbbb2-37e9-4bce-be02-51da147bddba"));

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "IAG", new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "WST", new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BID", new Guid("23242025-2b97-4035-a5f5-e536b1dea585") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SAB", new Guid("23242025-2b97-4035-a5f5-e536b1dea585") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "GKT", new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ANC", new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SBH", new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SXM", new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YHM", new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YKF", new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BUF", new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ENA", new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YCM", new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96") });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "ANC",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "BID",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "BUF",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "ENA",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "GKT",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "IAG",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SAB",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SBH",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SXM",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "WST",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YCM",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YHM",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YKF",
                columns: new[] { "Lat", "Long" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3496a6d2-5198-43ed-93e1-6b107dee0471"), "0e0b4563-913f-4cca-9465-27a8088215f4", "User", "USER" },
                    { new Guid("fd8910f9-5669-46a8-813e-d477f33b0ce3"), "b8b7f051-99bc-4b35-9d86-7fe85ccdc1ce", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("12d2ecc0-10b3-471d-b38d-fd9c5eed5dff"), 0, "6450a64d-29cc-472f-88d1-023fb79bfa15", "user@test.bg", false, false, false, null, "USER@TEST.BG", "USER", "AQAAAAEAACcQAAAAEAf8vAVav2y5VCs1n+QMiKG8DhaWH0xVLSYkd1s4Ou8V5B8Z2BOBtrvVBhIwaK4x2A==", null, false, null, false, "user" },
                    { new Guid("569a4fd1-d128-4ba4-8beb-8726b53c74d7"), 0, "e604e282-429e-4007-b3a6-72ad4223f400", "admin@test.bg", false, false, false, null, "ADMIN@TEST.BG", "ADMIN", "AQAAAAEAACcQAAAAENm6MKb8rFj5D3rYMEm2xGlylB/nirUHZb4NFKaiTPW1CT4BPgq6yp4JbHB5i1ir8g==", null, false, null, false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01c85e17-7fd0-40b0-aed2-5c936b8d6bfa"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2250, 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2050, "Grass", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("05f0ba1e-14e6-4844-be1c-ecc3ba8ce3ac"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3450, "Sand", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Concrete", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a388e35-ac42-42ea-be87-30c544a4c801"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1550, "Sand", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Grass", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0b3549c4-f4ca-49c5-8d46-bc2e1982e9dd"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3650, "Grass", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4000, "Asphalt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("156f64b0-5a7e-4cb4-a500-8c8eade22e12"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2050, "Gravel", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1916389d-fc35-4793-8d45-5802e1fe3b60"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2400, "Grass", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1af9c434-b5b4-4987-8445-022407fc2d57"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3000, "Concrete", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Gravel", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4050, 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1f63628a-9bcb-49f1-8272-b223b9976db9"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4050, "Grass", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4650, "Gravel", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 2150, "Asphalt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("23242025-2b97-4035-a5f5-e536b1dea585"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2650, "Grass", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("240e9bf7-7e0e-41e5-8e11-1a8936645e6b"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3750, 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("263ed122-e755-4777-80f8-6a95c34f094c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1800, "Asphalt", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("26923970-1000-4a2c-8a79-a94194025663"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3300, 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3550, "Concrete", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9cb6-7291-4a26-a986-50365d57eb0d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1200, "Asphalt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3900, "Dirt", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("360930ad-6357-4982-ae5a-1f51132b364d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2750, "Sand", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4850, 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("365d1fbb-00d3-4302-a66b-62c2b22ac887"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1950, "Gravel", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4050, "Sand", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("38e8e0a0-e79a-4315-980d-b65027360ea6"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1550, "Concrete", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3b96102b-caff-4fa9-ad6e-129beccdbbd2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4400, "Dirt", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4690cfd3-a95f-4fc3-a090-7427cb4a940a"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3600, 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ee00dc6-2f47-4855-98df-a30801ae9550"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Concrete", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ff6fa4f-5533-4e5a-a33b-a23b56fc84f4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2750, "Gravel", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("53172577-0a4d-4383-9091-3822e0b8cd15"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Sand", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5382e489-1590-427b-a49f-1b23cfc29c4f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2500, "Grass", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("548cf69c-3622-40d4-9be2-36b8b47431cd"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1400, "Sand", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Asphalt", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("590c27c4-5e4a-4c10-aa9c-67cb61886245"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4900, "Concrete", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5b132149-77d3-47fd-a520-1d496900adb6"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2600, "Concrete", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5bf826a5-d17b-4450-9035-6d682374c6b1"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3400, "Sand", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5cc30f4f-9194-4527-aeac-d2aa9413a97b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Concrete", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4150, "Dirt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3050, "Gravel", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6573c4b8-4a5f-48e1-a1d6-28701269d923"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1850, 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4600, "Gravel", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("69585cc8-a642-4a1f-9ccd-e9f51d716cc8"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1250, "Asphalt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6e334296-4b9d-409d-b520-d652336c72af"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1300, "Concrete", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("72936986-8fe6-4210-a619-f1e4dbed58ad"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3000, "Grass", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 2350, "Gravel" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77a65462-a795-4f86-a003-79d6fe59fd0c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Concrete", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4000, "Dirt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2550, "Gravel", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a06d874-9d78-4b6a-a39f-0ff1fbf1dbe2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3200, "Gravel", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Sand", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7c552e43-e3e7-464b-934b-353e47fc3f83"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3050, "Asphalt", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Grass", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("82d182d9-5e3d-451b-92d5-494b21859d37"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1250, "Gravel", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("84563346-802b-4262-a4bd-6ea9a06b462d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4000, "Sand", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4450, "Dirt", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1200, "Gravel", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("88138564-cb45-49d8-a43f-9320b8a1da0a"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4550, 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4750, "Asphalt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8a4cea93-961b-47ba-929d-1e2cfb08f819"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3200, "Sand", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2700, "Gravel", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8b32297e-e690-483c-aa62-b588ccaafd60"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3350, 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Sand", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8cfa1025-60af-4629-ad66-d635e6d57ae7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3200, "Dirt", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3650, "Grass" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Sand", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3350, "Gravel", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9125a26d-cb1e-495e-b244-0bd199db8c80"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4150, "Dirt", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Sand", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Concrete", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1250, "Sand", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1400, "Asphalt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("a7a129ef-57d3-488a-b881-f12ebc12a853"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4200, "Dirt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Sand", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ad6262e6-ec3c-4df6-8226-72fc9f09edaa"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4350, "Concrete", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3800, "Gravel", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b290ec57-0357-4836-8e6f-0de744db9db4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4100, "Grass", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2000, "Asphalt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b8482374-60a0-48a0-b125-137e45010d4e"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3100, "Asphalt", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b928d322-7d6a-45af-a14e-d4d17cead7d7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1650, "Grass", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1550, 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bda016ac-4c9e-42c9-81ca-38c8c900f9ec"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3300, "Concrete", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c19cf343-a208-46b3-b285-bdf8fbb13f26"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3100, "Gravel", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c8043beb-a90d-49db-a961-7250cc4f5dbe"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1200, 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2500, "Asphalt", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ca322b75-01ab-4c95-9c04-0ea6fd842790"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2550, "Gravel", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cb849a9a-d3b4-4afb-b90a-28ff51c54e58"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3650, "Gravel", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cbaf9970-1111-44bd-a5ef-4fb0274f983f"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2450, 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d0f2fbf5-79d4-44b8-a1a1-2c5f378758b0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1100, "Concrete", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d428bcc6-dd6c-4abb-97c3-ab79170938ed"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2250, "Concrete", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("da0ab1f3-a4e1-44a8-9ef4-0d85ac2e7769"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2250, 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ddcb5c90-cdc0-4946-87f4-7ce7f84cdcae"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4400, "Concrete", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("de17f842-2069-4ed0-9696-c3152926766d"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3900, "Sand" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1100, 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3600, "Gravel", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e15827b8-4957-48e8-83cc-64c2278c8446"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1600, "Sand", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e31422e4-b5b0-4953-9a56-21afee581f61"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3900, "Concrete", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e5d3c6b9-b075-4723-aa5d-02189c5b302e"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2400, "Grass", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e622af83-3acb-4c05-941a-1315c3fe148d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3950, "Sand", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ed7e1529-76f9-4fac-a412-2022316ffc2d"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 2200, "Sand" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f5fe3b97-bbb6-4504-9e9b-d97b45c1a83b"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2600, 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f6a7e74d-445f-415b-a8a5-e6959c88db4b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2100, "Gravel", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4650, "Concrete", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f82002a9-e16b-4e09-a239-5366b15ee530"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3200, 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fc8443ac-a73e-4dc2-a638-c12e785a7003"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1350, "Grass", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fe042ca0-d09d-42e8-b793-08f386d8e907"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1100, "Grass", 60 });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[] { "GKT", new Guid("1af9c434-b5b4-4987-8445-022407fc2d57") });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[,]
                {
                    { "BUF", new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a") },
                    { "ANC", new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c") },
                    { "WST", new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21") },
                    { "SXM", new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c") },
                    { "BID", new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54") },
                    { "SBH", new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f") },
                    { "YCM", new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf") },
                    { "IAG", new Guid("de17f842-2069-4ed0-9696-c3152926766d") },
                    { "SAB", new Guid("de17f842-2069-4ed0-9696-c3152926766d") },
                    { "YKF", new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73") },
                    { "ENA", new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb") },
                    { "YHM", new Guid("e15827b8-4957-48e8-83cc-64c2278c8446") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3496a6d2-5198-43ed-93e1-6b107dee0471"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fd8910f9-5669-46a8-813e-d477f33b0ce3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d2ecc0-10b3-471d-b38d-fd9c5eed5dff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("569a4fd1-d128-4ba4-8beb-8726b53c74d7"));

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "GKT", new Guid("1af9c434-b5b4-4987-8445-022407fc2d57") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BUF", new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ANC", new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "WST", new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SXM", new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BID", new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SBH", new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YCM", new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "IAG", new Guid("de17f842-2069-4ed0-9696-c3152926766d") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SAB", new Guid("de17f842-2069-4ed0-9696-c3152926766d") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YKF", new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ENA", new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YHM", new Guid("e15827b8-4957-48e8-83cc-64c2278c8446") });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "ANC",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "18.044477115469203", "-63.113348444162554" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "BID",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "17.644854961462727", "-63.22072830368736" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "BUF",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "60.56511015321005", "-151.2467758309837" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "ENA",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "41.349309415701384", "-71.80439788954519" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "GKT",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "61.17722677876709", "-149.99065401560944" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "IAG",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "43.10108184541733", "-78.94098824714688" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SAB",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "43.172967809253116", "-79.93176906063778" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SBH",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "43.455977185677234", "-80.3857616722722" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "SXM",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "43.18947540625031", "-79.17109808947245" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "WST",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "17.904442214376015", "-62.84499925950639" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YCM",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "42.93991008181565", "-78.72959253365957" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YHM",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "35.860619136430515", "-83.53895041673171" });

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "IATA",
                keyValue: "YKF",
                columns: new[] { "Lat", "Long" },
                values: new object[] { "41.16953985239386", "-71.58052399948453" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("375b90c6-adb5-47e4-b271-069c3c496e79"), "3b7c57c4-bd40-45d3-b5b9-94fd3a2f3701", "User", "USER" },
                    { new Guid("f5a724e4-7a34-470d-a6ca-007c079ee4d3"), "0b92ec12-59dc-4b16-933c-4b0c36da5492", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7e9793c4-bf72-4fb0-b0e0-768a854609ca"), 0, "f36e5444-3297-4a3b-b8c0-a5da69e0ea7b", "admin@test.bg", false, false, false, null, "ADMIN@TEST.BG", "ADMIN", "AQAAAAEAACcQAAAAEAzedpHOaKHLDJECToEO+wCO/r3dJjxVsxaKHurVtuH9OJwlgkmYvRNpFoVd1Z+n4w==", null, false, null, false, "admin" },
                    { new Guid("b64bbbb2-37e9-4bce-be02-51da147bddba"), 0, "32544dcd-9ccf-4b94-af26-353fa5c83ff4", "user@test.bg", false, false, false, null, "USER@TEST.BG", "USER", "AQAAAAEAACcQAAAAEH7FU2MwgCZzzhXsXy8PmKAP48J9OMiMH4eF+BcTrRk+S6L6A/rLlxaJOY0c7Nfl1w==", null, false, null, false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01c85e17-7fd0-40b0-aed2-5c936b8d6bfa"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2700, 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3000, "Gravel", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("05f0ba1e-14e6-4844-be1c-ecc3ba8ce3ac"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1050, "Grass", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Dirt", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a388e35-ac42-42ea-be87-30c544a4c801"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4050, "Grass", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1100, "Concrete", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0b3549c4-f4ca-49c5-8d46-bc2e1982e9dd"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2550, "Sand", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1000, "Gravel", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("156f64b0-5a7e-4cb4-a500-8c8eade22e12"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1400, "Grass", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1916389d-fc35-4793-8d45-5802e1fe3b60"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1300, "Sand", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1af9c434-b5b4-4987-8445-022407fc2d57"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1650, "Grass", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3400, "Sand", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1650, 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1f63628a-9bcb-49f1-8272-b223b9976db9"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1550, "Gravel", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4500, "Sand", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 1150, "Dirt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("23242025-2b97-4035-a5f5-e536b1dea585"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1000, "Dirt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("240e9bf7-7e0e-41e5-8e11-1a8936645e6b"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2300, 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("263ed122-e755-4777-80f8-6a95c34f094c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3600, "Grass", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("26923970-1000-4a2c-8a79-a94194025663"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2600, 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1300, "Dirt", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9cb6-7291-4a26-a986-50365d57eb0d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Concrete", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2800, "Concrete", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("360930ad-6357-4982-ae5a-1f51132b364d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1550, "Concrete", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2500, 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("365d1fbb-00d3-4302-a66b-62c2b22ac887"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3350, "Sand", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Dirt", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("38e8e0a0-e79a-4315-980d-b65027360ea6"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2650, "Asphalt", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3b96102b-caff-4fa9-ad6e-129beccdbbd2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1650, "Gravel", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4690cfd3-a95f-4fc3-a090-7427cb4a940a"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4300, 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ee00dc6-2f47-4855-98df-a30801ae9550"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2500, "Gravel", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ff6fa4f-5533-4e5a-a33b-a23b56fc84f4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2850, "Grass", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("53172577-0a4d-4383-9091-3822e0b8cd15"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Dirt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5382e489-1590-427b-a49f-1b23cfc29c4f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2300, "Gravel", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("548cf69c-3622-40d4-9be2-36b8b47431cd"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1200, "Concrete", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2500, "Sand", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("590c27c4-5e4a-4c10-aa9c-67cb61886245"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Sand", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5b132149-77d3-47fd-a520-1d496900adb6"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3350, "Grass", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5bf826a5-d17b-4450-9035-6d682374c6b1"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4350, "Concrete", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5cc30f4f-9194-4527-aeac-d2aa9413a97b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2150, "Grass", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1200, "Concrete", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2150, "Grass", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6573c4b8-4a5f-48e1-a1d6-28701269d923"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2400, 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3650, "Concrete", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("69585cc8-a642-4a1f-9ccd-e9f51d716cc8"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3900, "Grass", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6e334296-4b9d-409d-b520-d652336c72af"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3700, "Dirt", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("72936986-8fe6-4210-a619-f1e4dbed58ad"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4200, "Asphalt", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 2750, "Grass" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77a65462-a795-4f86-a003-79d6fe59fd0c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Asphalt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3550, "Asphalt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2150, "Dirt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a06d874-9d78-4b6a-a39f-0ff1fbf1dbe2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2350, "Concrete", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Grass", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7c552e43-e3e7-464b-934b-353e47fc3f83"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4950, "Sand", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4400, "Asphalt", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("82d182d9-5e3d-451b-92d5-494b21859d37"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1300, "Concrete", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("84563346-802b-4262-a4bd-6ea9a06b462d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1750, "Grass", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1450, "Gravel", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2750, "Concrete", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("88138564-cb45-49d8-a43f-9320b8a1da0a"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2300, 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3850, "Grass" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8a4cea93-961b-47ba-929d-1e2cfb08f819"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3900, "Concrete", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2100, "Dirt", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8b32297e-e690-483c-aa62-b588ccaafd60"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4500, 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4100, "Concrete", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8cfa1025-60af-4629-ad66-d635e6d57ae7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3250, "Concrete", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4150, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2750, "Gravel", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2300, "Asphalt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9125a26d-cb1e-495e-b244-0bd199db8c80"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2350, "Grass", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4950, "Gravel", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1300, "Grass", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4600, "Gravel", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3350, "Grass", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("a7a129ef-57d3-488a-b881-f12ebc12a853"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3000, "Asphalt", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Dirt", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ad6262e6-ec3c-4df6-8226-72fc9f09edaa"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3050, "Sand", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Grass", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b290ec57-0357-4836-8e6f-0de744db9db4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2550, "Dirt", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1200, "Concrete", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b8482374-60a0-48a0-b125-137e45010d4e"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3200, "Grass", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b928d322-7d6a-45af-a14e-d4d17cead7d7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1750, "Dirt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4550, 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bda016ac-4c9e-42c9-81ca-38c8c900f9ec"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4350, "Asphalt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c19cf343-a208-46b3-b285-bdf8fbb13f26"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4250, "Concrete", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c8043beb-a90d-49db-a961-7250cc4f5dbe"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3050, 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1900, "Concrete", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ca322b75-01ab-4c95-9c04-0ea6fd842790"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3150, "Dirt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cb849a9a-d3b4-4afb-b90a-28ff51c54e58"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1750, "Grass", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cbaf9970-1111-44bd-a5ef-4fb0274f983f"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3300, 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d0f2fbf5-79d4-44b8-a1a1-2c5f378758b0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4350, "Dirt", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d428bcc6-dd6c-4abb-97c3-ab79170938ed"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2800, "Asphalt", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("da0ab1f3-a4e1-44a8-9ef4-0d85ac2e7769"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4750, 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ddcb5c90-cdc0-4946-87f4-7ce7f84cdcae"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4650, "Gravel", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("de17f842-2069-4ed0-9696-c3152926766d"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3100, "Dirt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3850, 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1800, "Sand", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e15827b8-4957-48e8-83cc-64c2278c8446"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3700, "Asphalt", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e31422e4-b5b0-4953-9a56-21afee581f61"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1100, "Asphalt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e5d3c6b9-b075-4723-aa5d-02189c5b302e"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1600, "Asphalt", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e622af83-3acb-4c05-941a-1315c3fe148d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Dirt", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ed7e1529-76f9-4fac-a412-2022316ffc2d"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4900, "Dirt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f5fe3b97-bbb6-4504-9e9b-d97b45c1a83b"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1600, 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f6a7e74d-445f-415b-a8a5-e6959c88db4b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2200, "Concrete", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2100, "Asphalt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f82002a9-e16b-4e09-a239-5366b15ee530"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1750, 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fc8443ac-a73e-4dc2-a638-c12e785a7003"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2500, "Sand", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fe042ca0-d09d-42e8-b793-08f386d8e907"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1900, "Sand", 150 });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[] { "IAG", new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043") });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[,]
                {
                    { "WST", new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00") },
                    { "BID", new Guid("23242025-2b97-4035-a5f5-e536b1dea585") },
                    { "SAB", new Guid("23242025-2b97-4035-a5f5-e536b1dea585") },
                    { "GKT", new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf") },
                    { "ANC", new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f") },
                    { "SBH", new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c") },
                    { "SXM", new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54") },
                    { "YHM", new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587") },
                    { "YKF", new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757") },
                    { "BUF", new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f") },
                    { "ENA", new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d") },
                    { "YCM", new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96") }
                });
        }
    }
}
