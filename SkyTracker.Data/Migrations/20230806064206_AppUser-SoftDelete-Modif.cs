﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyTracker.Data.Migrations
{
    public partial class AppUserSoftDeleteModif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("94dd9488-efa9-4288-aedf-0c514bdf18a8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ad2e7b35-9a40-473a-b57c-493f04a5a14a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("af24c9da-acb2-41e4-9d81-cd8199be2e55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("32071f4d-5b47-4bc6-95a6-00bdb1ce0f58"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b1bef34-e108-48fe-a6b1-20b9ba7a8249"));

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YKF", new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ENA", new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SAB", new Guid("263ed122-e755-4777-80f8-6a95c34f094c") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BID", new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "IAG", new Guid("360930ad-6357-4982-ae5a-1f51132b364d") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ANC", new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BUF", new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SXM", new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SBH", new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YCM", new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "WST", new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YHM", new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "GKT", new Guid("e15827b8-4957-48e8-83cc-64c2278c8446") });

            migrationBuilder.AddColumn<string>(
                name: "OriginalUsername",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1f58a36c-bc25-410d-9147-8001594ef21d"), "c2508f30-1cec-4962-8d07-e91bf12636c0", "User", "USER" },
                    { new Guid("aa1c1727-e2a5-419d-82b2-5bb1b0a3783b"), "b8810fe4-be86-462b-8c10-777d3728a610", "Admin", "ADMIN" },
                    { new Guid("eb1d7d20-cd43-4824-bbcd-bc20053de0b5"), "35109946-16a5-4e5c-8aad-3d73a9869f64", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OriginalUsername", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("178b2bd2-c3c2-4ce0-b2a6-2da8607bf377"), 0, "6addf749-085c-4ba7-96a4-4c2d685245e1", "admin@sky-tracker.info", false, false, false, null, "ADMIN@SKY-TRACKER.INFO", "ADMIN", null, "AQAAAAEAACcQAAAAEBjn8o8MEiCTgky/pQzKUsUQpiGwKwnZe95NzGyu2nrrDNqxx/4jq32J0qDNIynTCw==", null, false, null, null, false, "admin" },
                    { new Guid("38793bd4-6671-43f8-9694-dcf4cd735514"), 0, "1edd0093-9953-42ff-9355-ced3fc744ebd", "moderator@sky-tracker.info", false, false, true, null, "MODERATOR@SKY-TRACKER.INFO", "MODERATOR", null, "AQAAAAEAACcQAAAAEEG0YieRMp9dhaf8DmjR+s2PBMGxrh5FVAtJEPqJrYMwKt0wx1DrXoc585eIwyFt7A==", null, false, null, null, false, "moderator" }
                });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01c85e17-7fd0-40b0-aed2-5c936b8d6bfa"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Dirt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2450, "Gravel", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("05f0ba1e-14e6-4844-be1c-ecc3ba8ce3ac"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4200, "Sand", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3350, 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a388e35-ac42-42ea-be87-30c544a4c801"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4800, "Asphalt", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3100, "Grass", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0b3549c4-f4ca-49c5-8d46-bc2e1982e9dd"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3750, "Gravel", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 2050, "Sand" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("156f64b0-5a7e-4cb4-a500-8c8eade22e12"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1350, "Gravel", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1916389d-fc35-4793-8d45-5802e1fe3b60"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1550, "Asphalt", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1af9c434-b5b4-4987-8445-022407fc2d57"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2850, "Asphalt", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4350, 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3350, "Concrete", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1f63628a-9bcb-49f1-8272-b223b9976db9"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1050, "Dirt", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Grass", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3400, "Gravel", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("23242025-2b97-4035-a5f5-e536b1dea585"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3300, "Grass", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("240e9bf7-7e0e-41e5-8e11-1a8936645e6b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Gravel", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("263ed122-e755-4777-80f8-6a95c34f094c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Concrete", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("26923970-1000-4a2c-8a79-a94194025663"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2200, "Concrete", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Dirt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9cb6-7291-4a26-a986-50365d57eb0d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4700, "Dirt", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1750, "Sand", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("360930ad-6357-4982-ae5a-1f51132b364d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Sand", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3600, "Grass", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("365d1fbb-00d3-4302-a66b-62c2b22ac887"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3650, "Sand", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf"),
                column: "Length",
                value: 2000);

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("38e8e0a0-e79a-4315-980d-b65027360ea6"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4900, 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3b96102b-caff-4fa9-ad6e-129beccdbbd2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2850, "Gravel", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4690cfd3-a95f-4fc3-a090-7427cb4a940a"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1400, "Concrete", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ee00dc6-2f47-4855-98df-a30801ae9550"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 2050, "Dirt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ff6fa4f-5533-4e5a-a33b-a23b56fc84f4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Dirt", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("53172577-0a4d-4383-9091-3822e0b8cd15"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4200, "Gravel", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5382e489-1590-427b-a49f-1b23cfc29c4f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1950, "Sand", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("548cf69c-3622-40d4-9be2-36b8b47431cd"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4400, 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3500, "Dirt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("590c27c4-5e4a-4c10-aa9c-67cb61886245"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2100, "Sand", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5b132149-77d3-47fd-a520-1d496900adb6"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4700, "Concrete", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5bf826a5-d17b-4450-9035-6d682374c6b1"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2450, "Sand", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5cc30f4f-9194-4527-aeac-d2aa9413a97b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2500, "Concrete", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2300, "Gravel", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2050, "Sand", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6573c4b8-4a5f-48e1-a1d6-28701269d923"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1900, "Dirt", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1700, 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("69585cc8-a642-4a1f-9ccd-e9f51d716cc8"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4500, "Gravel", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6e334296-4b9d-409d-b520-d652336c72af"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3250, 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("72936986-8fe6-4210-a619-f1e4dbed58ad"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3700, "Concrete", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2700, "Grass", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77a65462-a795-4f86-a003-79d6fe59fd0c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1250, "Dirt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4250, "Sand", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2000, "Asphalt", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a06d874-9d78-4b6a-a39f-0ff1fbf1dbe2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4600, "Sand", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2150, "Asphalt", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7c552e43-e3e7-464b-934b-353e47fc3f83"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2100, "Asphalt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4450, "Concrete", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("82d182d9-5e3d-451b-92d5-494b21859d37"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1000, "Concrete", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("84563346-802b-4262-a4bd-6ea9a06b462d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Sand", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3450, "Dirt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1700, "Sand", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("88138564-cb45-49d8-a43f-9320b8a1da0a"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2750, "Grass", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 1200, "Gravel" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8a4cea93-961b-47ba-929d-1e2cfb08f819"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3950, 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4700, "Concrete", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8b32297e-e690-483c-aa62-b588ccaafd60"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3550, "Gravel", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4400, "Grass", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8cfa1025-60af-4629-ad66-d635e6d57ae7"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3350, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Concrete", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2700, "Asphalt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2350, "Concrete", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9125a26d-cb1e-495e-b244-0bd199db8c80"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1800, "Dirt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3050, "Gravel", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Asphalt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Sand", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4550, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("a7a129ef-57d3-488a-b881-f12ebc12a853"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3600, "Dirt", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4200, "Concrete", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ad6262e6-ec3c-4df6-8226-72fc9f09edaa"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1550, "Sand", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3250, 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b290ec57-0357-4836-8e6f-0de744db9db4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1650, "Asphalt", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3650, "Dirt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b8482374-60a0-48a0-b125-137e45010d4e"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2600, 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b928d322-7d6a-45af-a14e-d4d17cead7d7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3850, "Sand", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4550, 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bda016ac-4c9e-42c9-81ca-38c8c900f9ec"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2900, "Gravel", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c19cf343-a208-46b3-b285-bdf8fbb13f26"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3350, "Asphalt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c8043beb-a90d-49db-a961-7250cc4f5dbe"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3100, "Sand", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3100, "Asphalt", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ca322b75-01ab-4c95-9c04-0ea6fd842790"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3350, "Concrete", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cb849a9a-d3b4-4afb-b90a-28ff51c54e58"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1300, "Asphalt", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cbaf9970-1111-44bd-a5ef-4fb0274f983f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3200, "Dirt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d0f2fbf5-79d4-44b8-a1a1-2c5f378758b0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2650, "Asphalt", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d428bcc6-dd6c-4abb-97c3-ab79170938ed"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2600, "Sand", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("da0ab1f3-a4e1-44a8-9ef4-0d85ac2e7769"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Sand", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ddcb5c90-cdc0-4946-87f4-7ce7f84cdcae"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4700, "Grass", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("de17f842-2069-4ed0-9696-c3152926766d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1750, "Dirt", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2600, "Dirt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Sand", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e15827b8-4957-48e8-83cc-64c2278c8446"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3950, "Dirt", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e31422e4-b5b0-4953-9a56-21afee581f61"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Dirt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e5d3c6b9-b075-4723-aa5d-02189c5b302e"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4950, "Gravel", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e622af83-3acb-4c05-941a-1315c3fe148d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1300, "Concrete", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ed7e1529-76f9-4fac-a412-2022316ffc2d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1700, "Dirt", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f5fe3b97-bbb6-4504-9e9b-d97b45c1a83b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3950, "Concrete", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f6a7e74d-445f-415b-a8a5-e6959c88db4b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1750, "Grass", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3600, "Concrete", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f82002a9-e16b-4e09-a239-5366b15ee530"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3300, "Asphalt", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fc8443ac-a73e-4dc2-a638-c12e785a7003"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4200, "Concrete", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fe042ca0-d09d-42e8-b793-08f386d8e907"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3300, "Asphalt", 390 });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[,]
                {
                    { "GKT", new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7") },
                    { "ENA", new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00") },
                    { "YCM", new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8") },
                    { "SAB", new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45") },
                    { "YHM", new Guid("6e334296-4b9d-409d-b520-d652336c72af") },
                    { "WST", new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587") },
                    { "IAG", new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5") },
                    { "SXM", new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24") },
                    { "YKF", new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19") },
                    { "ANC", new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d") },
                    { "BUF", new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d") },
                    { "BID", new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f") },
                    { "SBH", new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f58a36c-bc25-410d-9147-8001594ef21d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("aa1c1727-e2a5-419d-82b2-5bb1b0a3783b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("eb1d7d20-cd43-4824-bbcd-bc20053de0b5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("178b2bd2-c3c2-4ce0-b2a6-2da8607bf377"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38793bd4-6671-43f8-9694-dcf4cd735514"));

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "GKT", new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ENA", new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YCM", new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SAB", new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YHM", new Guid("6e334296-4b9d-409d-b520-d652336c72af") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "WST", new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "IAG", new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SXM", new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YKF", new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ANC", new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BUF", new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BID", new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SBH", new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b") });

            migrationBuilder.DropColumn(
                name: "OriginalUsername",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("94dd9488-efa9-4288-aedf-0c514bdf18a8"), "ac7373d0-0162-4d6e-ba8b-a519a7f65cb3", "User", "USER" },
                    { new Guid("ad2e7b35-9a40-473a-b57c-493f04a5a14a"), "5f3d50e8-f2bc-42fe-9cad-a7eb7b85f0a2", "Moderator", "MODERATOR" },
                    { new Guid("af24c9da-acb2-41e4-9d81-cd8199be2e55"), "34106941-1ac0-494e-8197-8b352a663651", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("32071f4d-5b47-4bc6-95a6-00bdb1ce0f58"), 0, "bb5b9428-b969-47c1-b668-aafe84811d85", "admin@sky-tracker.info", false, false, false, null, "ADMIN@SKY-TRACKER.INFO", "ADMIN", "AQAAAAEAACcQAAAAELyuQeNio+e9YYzh9iAebRLRFgSZN8B+QsF8pc65ucy+1rRu5MNbfVa/A/boMB0M6Q==", null, false, null, null, false, "admin" },
                    { new Guid("8b1bef34-e108-48fe-a6b1-20b9ba7a8249"), 0, "30cfb547-ab1d-4d29-af2b-bc054e35d05c", "moderator@sky-tracker.info", false, false, true, null, "MODERATOR@SKY-TRACKER.INFO", "MODERATOR", "AQAAAAEAACcQAAAAEAFXVv/6XeK6emFZe74Fu2olCj+fT0KXk4Ijz0xy9+cBeQxqfNkhKyyS5qnNbFA0+w==", null, false, null, null, false, "moderator" }
                });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01c85e17-7fd0-40b0-aed2-5c936b8d6bfa"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2150, "Gravel", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4450, "Concrete", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("05f0ba1e-14e6-4844-be1c-ecc3ba8ce3ac"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4900, "Grass", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1100, 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a388e35-ac42-42ea-be87-30c544a4c801"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3150, "Sand", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4750, "Concrete", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0b3549c4-f4ca-49c5-8d46-bc2e1982e9dd"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3950, "Asphalt", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4650, "Asphalt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("156f64b0-5a7e-4cb4-a500-8c8eade22e12"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Dirt", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1916389d-fc35-4793-8d45-5802e1fe3b60"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3300, "Concrete", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1af9c434-b5b4-4987-8445-022407fc2d57"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1100, "Concrete", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2950, 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4350, "Gravel", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1f63628a-9bcb-49f1-8272-b223b9976db9"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4250, "Gravel", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746"),
                columns: new[] { "SurfaceType", "Width" },
                values: new object[] { "Asphalt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2250, "Dirt", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("23242025-2b97-4035-a5f5-e536b1dea585"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4800, "Asphalt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("240e9bf7-7e0e-41e5-8e11-1a8936645e6b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4200, "Asphalt", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("263ed122-e755-4777-80f8-6a95c34f094c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1100, "Dirt", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("26923970-1000-4a2c-8a79-a94194025663"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3900, "Sand", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Concrete", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9cb6-7291-4a26-a986-50365d57eb0d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1100, "Concrete", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Dirt", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("360930ad-6357-4982-ae5a-1f51132b364d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4400, "Grass", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2500, "Sand", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("365d1fbb-00d3-4302-a66b-62c2b22ac887"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3400, "Grass", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf"),
                column: "Length",
                value: 3350);

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("38e8e0a0-e79a-4315-980d-b65027360ea6"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 1350, 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3b96102b-caff-4fa9-ad6e-129beccdbbd2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3950, "Dirt", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4690cfd3-a95f-4fc3-a090-7427cb4a940a"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4150, "Gravel", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ee00dc6-2f47-4855-98df-a30801ae9550"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3850, "Asphalt" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ff6fa4f-5533-4e5a-a33b-a23b56fc84f4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3550, "Sand", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("53172577-0a4d-4383-9091-3822e0b8cd15"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3550, "Grass", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5382e489-1590-427b-a49f-1b23cfc29c4f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Grass", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("548cf69c-3622-40d4-9be2-36b8b47431cd"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4050, 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4450, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("590c27c4-5e4a-4c10-aa9c-67cb61886245"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3300, "Gravel", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5b132149-77d3-47fd-a520-1d496900adb6"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1350, "Asphalt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5bf826a5-d17b-4450-9035-6d682374c6b1"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1000, "Gravel", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5cc30f4f-9194-4527-aeac-d2aa9413a97b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Gravel", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3200, "Dirt", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4050, "Gravel", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6573c4b8-4a5f-48e1-a1d6-28701269d923"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4950, "Gravel", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4200, 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("69585cc8-a642-4a1f-9ccd-e9f51d716cc8"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4600, "Sand", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6e334296-4b9d-409d-b520-d652336c72af"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 4100, 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("72936986-8fe6-4210-a619-f1e4dbed58ad"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2600, "Sand", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4400, "Dirt", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77a65462-a795-4f86-a003-79d6fe59fd0c"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Asphalt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1150, "Dirt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2100, "Concrete", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a06d874-9d78-4b6a-a39f-0ff1fbf1dbe2"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4900, "Gravel", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Grass", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7c552e43-e3e7-464b-934b-353e47fc3f83"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1800, "Dirt", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1500, "Dirt", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("82d182d9-5e3d-451b-92d5-494b21859d37"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2600, "Dirt", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("84563346-802b-4262-a4bd-6ea9a06b462d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4000, "Dirt", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4900, "Concrete" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1800, "Asphalt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("88138564-cb45-49d8-a43f-9320b8a1da0a"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3550, "Concrete", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 3050, "Sand" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8a4cea93-961b-47ba-929d-1e2cfb08f819"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3800, 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Asphalt", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8b32297e-e690-483c-aa62-b588ccaafd60"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2250, "Sand", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2000, "Concrete", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8cfa1025-60af-4629-ad66-d635e6d57ae7"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4000, "Grass" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4150, "Asphalt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3600, "Grass", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4150, "Sand", 570 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9125a26d-cb1e-495e-b244-0bd199db8c80"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2850, "Grass", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3750, "Grass", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1250, "Dirt", 510 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4150, "Grass", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4350, "Grass" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("a7a129ef-57d3-488a-b881-f12ebc12a853"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2200, "Sand", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4150, "Asphalt", 270 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ad6262e6-ec3c-4df6-8226-72fc9f09edaa"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2800, "Dirt", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 2650, 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b290ec57-0357-4836-8e6f-0de744db9db4"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4300, "Sand", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1750, "Sand", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b8482374-60a0-48a0-b125-137e45010d4e"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3850, 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b928d322-7d6a-45af-a14e-d4d17cead7d7"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1850, "Gravel", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf"),
                columns: new[] { "Length", "Width" },
                values: new object[] { 3600, 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bda016ac-4c9e-42c9-81ca-38c8c900f9ec"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1600, "Asphalt", 60 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c19cf343-a208-46b3-b285-bdf8fbb13f26"),
                columns: new[] { "Length", "SurfaceType" },
                values: new object[] { 4650, "Sand" });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c8043beb-a90d-49db-a961-7250cc4f5dbe"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1500, "Gravel", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2750, "Grass", 360 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ca322b75-01ab-4c95-9c04-0ea6fd842790"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1350, "Grass", 150 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cb849a9a-d3b4-4afb-b90a-28ff51c54e58"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3700, "Sand", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cbaf9970-1111-44bd-a5ef-4fb0274f983f"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1950, "Gravel", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d0f2fbf5-79d4-44b8-a1a1-2c5f378758b0"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3650, "Concrete", 330 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d428bcc6-dd6c-4abb-97c3-ab79170938ed"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2200, "Dirt", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("da0ab1f3-a4e1-44a8-9ef4-0d85ac2e7769"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4450, "Gravel", 120 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ddcb5c90-cdc0-4946-87f4-7ce7f84cdcae"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1250, "Asphalt", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("de17f842-2069-4ed0-9696-c3152926766d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2100, "Gravel", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4100, "Asphalt", 180 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2850, "Grass", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e15827b8-4957-48e8-83cc-64c2278c8446"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Concrete", 390 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e31422e4-b5b0-4953-9a56-21afee581f61"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4850, "Gravel", 300 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e5d3c6b9-b075-4723-aa5d-02189c5b302e"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3500, "Sand", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e622af83-3acb-4c05-941a-1315c3fe148d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3150, "Asphalt", 90 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ed7e1529-76f9-4fac-a412-2022316ffc2d"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 2300, "Asphalt", 540 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f5fe3b97-bbb6-4504-9e9b-d97b45c1a83b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4550, "Gravel", 210 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f6a7e74d-445f-415b-a8a5-e6959c88db4b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1950, "Dirt", 240 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3750, "Asphalt", 480 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f82002a9-e16b-4e09-a239-5366b15ee530"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 1900, "Sand", 420 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fc8443ac-a73e-4dc2-a638-c12e785a7003"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 3700, "Grass", 450 });

            migrationBuilder.UpdateData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fe042ca0-d09d-42e8-b793-08f386d8e907"),
                columns: new[] { "Length", "SurfaceType", "Width" },
                values: new object[] { 4350, "Sand", 540 });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[,]
                {
                    { "YKF", new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18") },
                    { "ENA", new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746") },
                    { "SAB", new Guid("263ed122-e755-4777-80f8-6a95c34f094c") },
                    { "BID", new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb") },
                    { "IAG", new Guid("360930ad-6357-4982-ae5a-1f51132b364d") },
                    { "ANC", new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564") },
                    { "BUF", new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c") },
                    { "SXM", new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc") },
                    { "SBH", new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b") },
                    { "YCM", new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5") },
                    { "WST", new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f") },
                    { "YHM", new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73") },
                    { "GKT", new Guid("e15827b8-4957-48e8-83cc-64c2278c8446") }
                });
        }
    }
}
