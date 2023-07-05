using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkyTracker.Data.Migrations
{
    public partial class SeedAllMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Occurrence",
                table: "HeraldPosts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("0218ea27-cb00-4b8c-8049-db021e43583d"), "Transavia B737 at Rotterdam on Apr 24th 2021, we think we are 6500 feet, military radar tells FL110, unreliable speed and altitude on both left and right pitot systems", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("038763cc-0af4-46ca-a4cd-9822b3fd6c57"), "Delta A321 at New Orleans on Mar 31st 2023, rejected takeoff on ATC instruction", new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("0434b789-6ff5-4f12-b153-8261ec9b171e"), "Skywest CRJ2 near Pierre on Apr 12th 2023, engine failure", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("0d03e449-f9df-49e0-8c52-d9f59b6575fe"), "Oman B739 at Shiraz on May 15th 2023, foreign object on runway at landing", new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("0e55f1f0-e623-420b-9c7f-d92ad27054b9"), "Brussels A333 near Paris on May 22nd 2023, engine vibrations", new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("10cac8c2-eb22-4171-b3ce-1b4acda6b7e0"), "THY B739 at Kayseri on Apr 7th 2023, bird strike", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("11445c3c-e906-4206-a3ea-5404a627019e"), "Lufthansa CRJ9 at Frankfurt on Jun 15th 2023, smell of smoke in cabin", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("11cce2fd-d1ea-4b8a-b6e3-5c919138db72"), "Iceland B39M at Toronto on Mar 4th 2023, tail strike on balked landing", new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("14bd9eed-c2ec-491b-a87a-e7fce46c2797"), "Transat A332 near Nassau on Mar 4th 2023, overheating cabin floor and burning odour", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("1559bfaf-9120-47d9-af6a-da1b6934bae0"), "Server harddisk crashed, we are back up in full service after about 6 hours", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "News" },
                    { new Guid("15927a4f-dc89-4faf-9af0-40589642ef54"), "SAS A20N at Tromso on Feb 12th 2023, rejected takeoff due to difficulties with directional control", new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("1892773e-bdb2-40f5-bd4d-7f3f8afb88a9"), "Skywest CRJ2 at Houston on May 11th 2022, runway excursion on landing", new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("18c2691f-e40c-469a-ae71-ecab22406cd8"), "Nolinor B738 at Toronto on Apr 15th 2023, flaps failure", new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("18f47283-13d4-418f-a638-8227522302e1"), "Wideroe DH8A at Tromso on Jun 2nd 2023, engine shut down in flight", new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("1951e601-9bfe-4d32-a8a7-89e18abcd46c"), "Hawaiian A332 near Honolulu on Dec 18th 2022, turbulence injures 42", new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("19fc73d0-7203-4112-876e-506e2bf9663d"), "Fedex MD11 at Toronto on Jun 21st 2023, thrust reverser deployed in flight", new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("1b9417d8-2fdd-4ebb-8399-bbfe50f9e13b"), "LOT B788 at Warsaw on Feb 4th 2023, backup ADI failed", new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("1cc4f2ab-4bc3-4eca-83ec-9a5e62725dca"), "Qantas B738 near Nadi on Jan 22nd 2023, fumes in cabin", new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("1d0b9ab2-767f-4bf2-ba81-2196c301c097"), "Easyjet A320 at London on May 28th 2023, engine failure", new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("1f482eb3-bda0-4f28-b891-378396f2f991"), "Trigana B735 at Yahukimo on Mar 11th 2023, aircraft being shot at", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("20410cf0-ea32-404a-9bf6-4af529339dac"), "Jetblue A320 at Jacksonvill on Feb 22nd 2023, engine failure", new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("2270616a-5f35-4df0-a1d5-89e5ce29c034"), "Norwegian Sweden B738 at Gothenburg on Feb 2nd 2023, balls", new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("22cdc2ef-e7f8-4893-affc-42c9575a9e2e"), "Shree DH8D near Kathmandu on Mar 9th 2023, engine fire indication", new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("236a1264-29db-4a88-851b-04392b04472c"), "Key Lime SW4 and private aircraft at Denver on May 12th 2021, midair collision", new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("243325f8-ab21-4c2c-8f49-23ebd44f3dee"), "Ryanair B738 at Dublin on Apr 9th 2023, temporary runway excursion and nose gear damage on landing", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("25dd9b8c-99bb-44b3-a98b-86b33d497d0a"), "Flydubai B39M at Male on Mar 28th 2023, burst tyres on landing", new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("26b35488-be5c-40a8-ade0-5501f768ac8c"), "HiSky A21N near Manchester on May 11th 2023, pilot incapacitated", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("2804f4d5-7e68-415a-9f50-2d79c634e762"), "CAA A320 at Mbuji Mayi on Jan 29th 2023, dropped part of elevator on departure", new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("28fefb9c-17b0-43f2-b38b-b1c3aab7e07f"), "Ibex CRJ7 near Fukuoka on Apr 18th 2022, loss of left and right airspeed indications", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("2946b491-f9b9-4ed9-9896-55b6481eaa9f"), "Pel SF34 near Cobar on Apr 23rd 2023, fire on board", new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("298d4962-56e3-4a4f-9705-3546c05c1b2b"), "British Airways B773 near Singapore on Jun 16th 2023, turbulence causes injuries", new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("2b8fc4b6-cbf1-464f-ae40-a02fbd079b0b"), "Sun Country B738 at Las Vegas on Feb 4th 2022, gear malfunction on departure", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("2d3108a5-f8df-4dd5-a975-bfa0e488c2fd"), "Avianca A320 at San Andres on Apr 25th 2023, bird strike", new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("2d47641a-3d73-4996-902c-52226d83e3d1"), "Argentinas B738 near Posadas on Jun 19th 2023, burning odour on board", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("3064ebcc-f366-4dd8-93ee-f998c3f7328f"), "Flydubai B738 at Kathmandu on Apr 24th 2023, bird strike on departure", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("3420ce03-baf0-41cc-b4f7-cf436c470fd3"), "United B788 near Dublin on May 4th 2023, cracked windshield", new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("34962014-777b-4ec9-bc02-42066fbe2aae"), "Asiana A333 at Tokyo on Feb 12th 2023, oil leak", new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("35640bc5-8162-4429-a412-c983358ea924"), "KLM B773 at Paramaribo on Mar 6th 2023, damaged a number of tyres on landing", new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("3568c2bd-8203-470c-b2bc-c524fdb1db74"), "Smartwings Poland B738 at Warsaw and Prague on Jan 9th 2023, right hand airspeed and altitude indications faulty", new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("375fdc03-63a3-4085-baf8-d04651585616"), "Fedex B763 and Southwest B737 at Austin on Feb 4th 2023, loss of separation on runway resolved by go around", new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("37e54a85-8fca-4e98-807a-11bbd2d6c3c8"), "Canada B773 near Toronto on Apr 30th 2023, something glowing on wing", new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("3978ff7d-406b-4987-876d-01afa9bd0178"), "Qantas B738 over Tasman Sea on Jan 18th 2023, engine shut down in flight", new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("398add8a-a222-4176-8db9-4e8ad487531b"), "Asiana A321 at Daegu on May 26th 2023, emergency exit opened in flight", new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("3a9b3be2-d82e-4d74-ad7f-6da370cb2400"), "Porter DH8D at Boston on Mar 30th 2023, engine shut down in flight", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("3bde6a81-4da6-4b3d-a763-774a2c44c0d8"), "Cargolux B744 at Luxembourg on May 14th 2023, could not retract landing gear, on return right center gear bogey separated", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("3c67c85d-5c8f-41a2-9dc6-a6deb5050edb"), "Ethiopian B772 at Shanghai on Jul 22nd 2020, aircraft burned down on apron", new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("3cbd9e78-12db-44fc-a1fe-07a5cb7aeb9d"), "Indigo A21N at Delhi on Jan 3rd 2023, hydraulic failure", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("3e5c92a5-b13f-4da2-a24b-80ba8ab2111a"), "United B753 over Pacific on May 24th 2023, rudder issues", new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("3f6003c3-6521-4ced-9901-5cd3ff41e0cb"), "Bluebird B734 at Paris on Feb 10th 2023, huge bangs on descent", new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("4054f929-b335-43f1-9421-656dd83e3da2"), "Delta B738 at Burlington on Jun 12th 2023, engine failure", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("41a7f5e0-3281-4d9e-bb73-0de3e51bf097"), "PIA A320 at Karachi on May 24th 2023, bird strike", new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("41fdd98c-2b1d-4009-8698-c453d0535d74"), "Garuda B738 at Manado on May 31st 2023, engine problems", new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("44c82ca0-4c04-4b59-b751-667ae58a6848"), "Easyjet Europe A319 near Naples on Jan 5th 2023, flight management computer failure", new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("45ab18d9-5399-416d-b635-3093c08da162"), "Central Mountain DH8A at Ft. McMurray on Dec 21st 2022, nose gear stuck in half retracted/extended position", new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("45eb1a07-560c-404c-aba0-13209e7b6a83"), "British Airways A320 near Glasgow on Apr 10th 2023, fuel transfer problem", new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("4686971d-5849-4e92-958b-43611f06eeb9"), "Malta Air B738 at Milan on May 27th 2023, nose tyre damage on departure", new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("487a5420-cb92-4455-952a-6abcfd516bb4"), "Argentina B738 at Buenos Aires on Jan 2nd 2023, bird strike", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("4897c7b0-0f89-4a39-ad1e-faaa4aff56d9"), "Aeroregional B735 near Quito on May 5th 2023, loss of cabin pressure", new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("489a6cb1-909c-40d5-a89c-8faad2d929ce"), "Delta B763 near New York on Jun 10th 2023, engine problem", new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("49151a53-f572-4a87-a6a0-d8e897bd84e9"), "Kasai AN26 at Lisala on Apr 11th 2023, runway excursion on landing", new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("4ac76aa5-ef2f-422b-b985-ffdc11e2f148"), "TAP A20N at Bissau on Feb 25th 2023, bird strike", new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("4c7af6c8-f87f-40ad-bf8d-b5b0826860b3"), "KLM B772 over Mediterranean on Feb 9th 2023, cabin problems - electrical fire in oven", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("4c8bba4c-1d05-4a95-955d-5fa49bf0e6ab"), "Spicejet B738 near Patna on Nov 17th 2021, loss of cabin pressure causes momentary incapacitation of captain", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Report" },
                    { new Guid("4f8fd3ba-b9f9-4c65-869d-e141007bc143"), "Link SF34 at Canberra on Nov 10th 2022, propeller strap penetrates cabin in flight", new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("50c80266-5545-43ae-9ded-9d7d82cce754"), "British Airways A320 near Manchester on Jan 27th 2023, fumes in cockpit", new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("52ca76e5-4995-4adb-92f5-0ce2c549f0d3"), "Westjet Encore DH8D at Calgary on May 31st 2023, engine fire", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("5414b160-a242-4f66-8d52-6ee28b39aeed"), "Sunwing B738 at Santa Clara on Apr 26th 2023, could not retract left main gear", new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("5552497f-001f-4fd8-aa56-65bd69c2f3ee"), "India Express B738 at Kozhikode on Feb 24th 2023, technical problem", new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("55ccfc96-5cbc-4634-b2fb-716666e8ed42"), "ICE B752 enroute on Feb 27th 2023, engine issue", new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("56458cc3-6a13-44b3-9bf7-1ad356162e44"), "LOT B788 at Warsaw on Mar 12th 2023, could not retract nose gear", new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("573a189f-223b-45a6-b826-63f8ce75071f"), "Hawaiian A332 at San Diego on Jan 10th 2023, hydraulic failure", new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("59996896-73c2-4688-b972-1824554a6118"), "Sunstate DH8D at Brisbane on Feb 1st 2023, turbulence injures two people", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("59d88a51-5b88-45c0-98c4-ae9a02dce8fd"), "El Al B788 at Tel Aviv on Apr 22nd 2023, engine problem", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("5aa06c7c-d653-46a2-ab15-b51179761a48"), "United Nigeria E145 at Lagos on May 31st 2023, runway excursion", new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("5ba3b939-f028-4b60-bce7-a2782bf352bc"), "Delta A320 at Omaha on Nov 19th 2022, bird strike", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("5faaa1f7-2330-4e59-b2b3-ab0cb91d6037"), "El Al B772 over Germany and Austria on Apr 10th 2023, losscomm", new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("60b1483a-1183-4fb0-b0b1-807e9bcff431"), "American B772 at Barcelona on Mar 20th 2022, flap fairing detached in flight", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("61369b93-8ac2-4913-bcd8-f2d322a686d6"), "Azul AT72 at Valadares on Jun 3rd 2023, engine fire indication", new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("61d8225a-3a9f-4975-9b71-7df92e23f2ea"), "Aeromexico B38M at Mexico City on May 10th 2023, rejected takeoff after operational error", new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("64db7a0d-0256-444e-8b5c-45e7949b816c"), "TAG SF34 at Flores on Apr 16th 2023, gear problem on approach, runway excursion", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("66858dbf-bb59-40bf-ac04-2e44dd2b91ae"), "Cathay B773 at Hong Kong on Jun 24th 2023, rejected takeoff", new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("68094bdf-71ff-457e-b25f-08ebb1671c47"), "Easyjet A320 at Geneva on May 18th 2023, fire in overhead locker", new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("687c27e6-68c0-48b0-95b8-8d14633f82c0"), "Challenge B744 at Atlanta on Feb 20th 2023, flaps problems on departure", new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("6937ddc5-45ae-4874-b33f-1bde09060a34"), "France A359 near Osaka on May 28th 2023, weather radar and airspeed malfunction", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("69449aac-0051-4558-a753-99166d453c7a"), "United A319 at Miami on Mar 6th 2023, engine compressor stall", new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("6a303c04-3262-4127-bc91-99b1b297c478"), "Swiss A320 at Zurich on Feb 14th 2023, took off with vehicle on runway", new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("6a5a0373-80c5-4d9d-a396-ecacba800d65"), "Perimeter DH8C at Gods Lake Narrows on Jun 3rd 2023, hydraulic leak", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("70000f32-fe6e-483b-85ea-54b5752971ac"), "Baltic BCS3 at Brussels on Apr 19th 2023, started final descent too early", new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("70989495-3e91-4be0-9a37-f01a5d3178eb"), "ANZ B789 near Auckland on Jun 23rd 2023, fuel issues", new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("70be182d-879b-48cc-95b4-96cfa93b3478"), "United A320 near Kansas City on Jun 11th 2023, fumes in cockpit", new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("71990ac5-6637-4625-8835-b73e0b624628"), "Mahan A346 near Almaty on Mar 5th 2023, engine fire indication", new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("7c147614-1c5b-4428-a957-d818bb867a3a"), "Longtail B744 at Maastricht on Feb 20th 2021, rain of engine parts", new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("7ea83e94-6fdc-4458-b958-e8a9789e2a88"), "Qantas E190 at Darwin on Feb 10th 2023, could not fully retract gear", new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("7fedcfd6-624f-41cf-99db-a24e5f34a56b"), "Flair B38M over Gulf of Mexico on Feb 7th 2023, loss of cabin pressure", new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("801613d0-664e-41c1-b68c-508efc7ecb27"), "Airwork B733 at Darwin on Nov 4th 2021, cabin did not pressurize", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("80cc4355-011b-43f7-b8d7-4f559095040f"), "India B773 near Stockholm on Feb 22nd 2023, engine shut down in flight", new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("80ff88be-7fcb-4a2b-9dc3-649e82efd851"), "Flynas A20N at Dubai on Feb 9th 2023, engine failure", new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("828fc764-cb4f-4728-a66c-8ffe607e89e3"), "Chair A320 at Zurich on Mar 1st 2023, cargo door open indication", new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("83c716e5-8f7b-44f9-91ad-58cec161ab1b"), "American B738 at Merida on Apr 1st 2023, flaps problems on approach", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("8478d912-5e8a-4065-bc07-616402b20238"), "Delta B763 over Atlantic on Jul 7th 2022, flooding on board, autopilots disconnected", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("85285234-005e-4585-a884-ce3854128450"), "Aeromexico E190 near Oaxaca on May 3rd 2023, loss of cabin pressure", new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("8586c2b4-0bd4-44bc-a828-4d4d563cdcd9"), "TAP A320 at Copenhagen on Apr 8th 2022, reverser opened on TOGA, overflew buildings at very low height on go around", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("85a5df29-7d5f-42f4-a668-c3dccf78999c"), "Edelweiss A343 at Phuket on Mar 2nd 2023, dropped slat panel", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("8678a055-6bcf-4888-9696-b4fbfcecce67"), "Canada A333 at Madrid on Jul 13th 2022, TCAS RA on final approach", new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("86951b81-fca5-4b0a-8035-d50b79aedc4f"), "India Express B738 at Kochi on Jan 29th 2023, hydraulic failure", new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("86af95cf-e82a-4e7d-bec1-76c0b2f58b7e"), "Wideroe DH8A at Svolvaer on Dec 22nd 2022, GPWS saves the day", new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("86b127ba-9d70-4a19-9ad6-cd3b99278970"), "Ryanair B738 at Eindhoven on Mar 5th 2023, tyre damage on landing", new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("86b99408-3551-4afd-b85e-28a24d4c1e3b"), "Swiss RJ1H enroute on Sep 3rd 2016, fumes in cockpit and cabin", new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("86e9b094-fc72-46f9-a0ca-eac7c0087c60"), "KLM B772 near Dubai on May 26th 2023, engine shut down in flight", new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("8bf9b52f-03da-411b-ade3-cd5384dafeec"), "British Airways A320 near Zurich on Mar 29th 2023, unusual odour on board", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("8c701e39-7075-4f1f-9f43-30385d817e8b"), "Wideroe DH8D near Sandefjord on Mar 17th 2023, departed without being refueled", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("8d062f46-e5df-4785-b0a8-ab37e0b67e68"), "Indigo A20N at Surat on Feb 26th 2023, bird strike", new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("8d99648e-4172-4613-8f2e-f97d1daa1fc1"), "TAROM B738 near Bucharest on Mar 25th 2023, captain incapacitated", new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("9189f8de-8336-418b-97af-cc6735e45834"), "United B772 at Honolulu on Jan 23rd 2023, runway incursion", new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("938eca17-da75-4430-b6e7-5715c2908aaf"), "United B772 near Lincoln on Feb 4th 2023, engine shut down in flight", new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("95f0fa1f-6ef8-47c5-bfec-9574a2b51f87"), "Key Lime J328 at Phoenix on Feb 16th 2023, engine rolled back", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("965cb058-3318-47c3-99f4-8ed8cd55892c"), "Volotea A319 near Bordeaux on Jun 2nd 2023, loss of cabin pressure", new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("975e617d-1018-4ab9-943c-a2d1071e0f85"), "SAS A320 at Haugesund on Jan 17th 2023, could not retract the landing gear", new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("9b0a6fee-7696-4611-abf9-6659eff88af9"), "United B763 at Houston on Mar 28th 2023, engine shut down in flight", new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("9bc8b668-58d2-48e2-841c-4b2b4e3c0bb4"), "Easyjet Europe A320 at Bordeaux on Dec 31th 2022, cleared to land on occupied runway", new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("9e20d935-293b-4f6b-9a9f-adff134f6e9c"), "Delta B763 at Edinburgh on Feb 10th 2023, engine shut down in flight", new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("9eff6f10-0f79-4bdb-96d7-1a5ff4d824a7"), "Lufthansa A333 near Washington on Mar 1st 2023, turbulence causes injuries", new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("a0b5bfe7-2de0-4469-b408-988c164ea547"), "Ariana A313 at Jeddah on Feb 24th 2023, rejected takeoff due to sliding window", new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("a20e35fa-3a8b-413b-98fd-e0119107e8e0"), "Delta B752 at New York on Mar 15th 2023, slat disagree", new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("a32d4a7d-d360-4d19-9ddb-beaf00f26031"), "Transavia B738 at Rotterdam on May 4th 2023, bird strike", new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("a88d1fa0-93fd-4554-a618-b8c4dfe815e0"), "United B739 at Fort Myers on Apr 11th 2019, galley oven refused to slow down on landing", new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Report" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("ac13b4fb-816a-45a2-ac65-93d97be8fc79"), "Qatar B773 at Brisbane on Dec 31st 2022, flaps problem", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("ad045a02-3dd6-44d7-bf7c-498227318aeb"), "Lufthansa A21N at Frankfurt on Mar 31st 2023, lightning strike", new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("b2aa0488-193b-45ad-803d-04d788e93562"), "American B38M at Miami on Jan 20th 2023, failure of stabilizer trim", new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("b3bbc347-9d94-4554-901c-bd014b75dd2c"), "Edelweiss A320 at Zurich on Aug 17th 2021, rejected takeoff", new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("b4839094-9a53-4d84-a499-e6da3c7cd76f"), "Swiss BCS3 at Zurich on Jan 9th 2023, lightning strike", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("b7954598-218c-4bbc-afc0-9bdfa1bf6f14"), "Virgin Australia B738 at Sydney on Oct 19th 2022, verbal slip in clearance", new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Report" },
                    { new Guid("bb4a4a89-d7ce-4b9b-973c-d5ae93281487"), "VARA A320 near Adelaide on Mar 3rd 2023, first officer incapacitated", new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("bb52f35c-bd8a-468b-b242-25f71b4286ec"), "Qantas B738 at Melbourne on Jan 20th 2023, engine problem", new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("bba884ed-0ae6-4341-867d-9466b82d7842"), "Spicejet B738 at Delhi on Apr 18th 2023, cargo smoke indication", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("bbac0457-d33c-4e88-9548-50e7fbea2c81"), "Fedex A306 near Indianapolis on May 7th 2023, hydraulic problems", new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("bd5f93fe-4fb0-4853-b333-0641aaab855f"), "Canada B772 over Atlantic Ocean on Dec 18th 2022, one flight crew and two cabin crew incapacitated", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("bd6a8ce6-88e1-49df-9aff-5b84d3e682d8"), "China Express CRJ9 near Guiyang on Jan 6th 2023, loss of communication", new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("bd81647e-287a-4aac-8c72-7ad3e0f12ce1"), "Easyjet A319 near Manchester on May 19th 2023, burning odour on board", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("bd99def8-fcc7-40bd-a446-89a5485d07c6"), "ANZ B789 enroute on Jun 19th 2023, cracked windshield", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("c13a0d65-a3ea-4cd5-a530-c622d802f67a"), "Qantas A332 near Adelaide on Feb 4th 2021, loss of cabin pressure", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("c2a55d7c-65b9-4f70-bb56-f8f501c4e269"), "Algerie B738 near Marseille on Jun 8th 2023, loss of cabin pressure", new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("c31e2825-f258-499f-a2f8-5b8346e632ab"), "Virgin Australia B738 at Coolangatta on Jan 24th 2023, long landing", new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("c3e85507-074d-4dc1-8e09-978ec32dd14a"), "Buddha AT72 at Kathmandu on Mar 18th 2023, unreliable airspeed", new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("c73e62b6-fe96-4d48-aed8-9698c33bd6ef"), "El Al B789 at Tel Aviv on Apr 4th 2023, engine shut down in flight", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("c771303b-7e3b-4d12-9d4d-9c538810a429"), "Lufthansa B744 enroute on Apr 15th 2023, hydraulic problem", new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("cb29adb3-34e2-485d-97e3-216d1570c8ef"), "Lufthansa B748 at Buenos Aires on Apr 29th 2023, could not retract landing gear", new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("cea357c4-ba35-4338-8497-6ae6f428a4df"), "ANZ B773 at Auckland on Jan 27th 2023, runway excursion on landing", new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("d00fd3d0-3cef-4892-a484-78e34fe75ce6"), "India Express B738 at Abu Dhabi on Feb 3rd 2023, engine fire", new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("d14cb529-50a3-4f93-a889-64b8170dfd52"), "Lufthansa A320 at Munich on Jan 17th 2023, slat problem", new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("d26a487d-51f2-4800-9b20-8c9ef173b882"), "Indigo A20N near Hyderabad on Mar 18th 2023, hail strike", new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("d27c8108-07bd-405a-aaa2-74a5c40008d6"), "THY B739 at Kayseri on Jan 30th 2023, burst tyre on landing", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("d3a634a2-943e-400a-9b47-abc5b40c2e69"), "Lufthansa Cityline A319 near Munich on Jan 15th 2023, failure of weather radar", new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("d5bd2a9a-1066-4889-8d25-2f0eeb9035ae"), "Swiss A320 at Zurich on Jan 6th 2023, smoke in cockpit and cabin", new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("d9f5e6c4-c48d-484e-8810-cb8f0e527422"), "Precision AT42 at Bukoba on Nov 6th 2022, touched down short of  runway and ended up in Lake Victoria", new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("dd965a8e-930d-42a1-b2cd-d1bf603a909c"), "Vietjet A21N near Laoag on Jun 28th 2023, engine vibration indications", new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("de904f6d-c8e5-4cd2-8384-77d0df029674"), "Edelweiss A320 at Zurich on Jun 18th 2023, gear problems on departure", new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("e044b376-d1e5-400e-80aa-bab52d202b7e"), "Delta B738 at New York on Apr 23rd 2023, lightning strike", new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("e40bcf84-4661-4948-8928-7fadeedac17f"), "Condor A339 near Mauritius on Mar 2nd 2023, turbulence injures 20", new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accident" },
                    { new Guid("e70be7b8-1d1f-4bad-a52c-ca2f51255006"), "Yeti AT72 at Pokhara on Jan 15th 2023, lost height on final approach, both propellers went into feather", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crash" },
                    { new Guid("e7535a1c-15b8-4f36-a80f-a31cd75d12a5"), "Indigo A21N at Delhi on Jun 10th 2023, engine failure", new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("e9ad8edf-faac-47e4-8032-d61170e7f1a5"), "Singapore B744 at Nairobi on Apr 17th 2023, rejected takeoff due to bird strike", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("eaed6c1e-df3e-4834-99c0-3cca3a47e8ef"), "Eastern Airways AT72 near Exeter on Jan 7th 2023, cracked windshield", new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("eb5dbabe-58f6-417b-abd2-d0e07daa3b58"), "Batik A333 at Madinah on Jun 12th 2023, hydraulic leak", new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("ec19b794-a976-461f-8177-edbdd0d28c42"), "Delta BCS1 near Kansas City on Jan 31st 2023, cracked passenger window", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("ed10b11d-524e-431f-87e5-684cb560d922"), "Pionair B462 at Rockhampton on Jan 5th 2023, descended below safe height", new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("ed479bde-b136-40fc-9026-fc0e65ac6e31"), "Qatar B788 at Doha on Jan 10th 2023, steep descent after takeoff", new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("ede76c5f-6db0-4b65-bb2f-ad6f26f37b9a"), "TUI B738 enroute on May 4th 2023, one flight crew incapacitated", new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("ee41db14-555f-4451-9e14-af94d8be980f"), "Easyjet Europe A320 at Milan on Dec 28th 2022, rejected takeoff due to cargo door warning", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("ef19532a-01bf-429d-9ff4-3cd87877203f"), "LATAM Cargo at Frankfurt on Jun 20th 2023, stalled during go around, overflew parallel runway and stalled again", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("ef195491-1a27-4ceb-85ee-66a4294ef291"), "Jetblue A320 near New York on May 22nd 2023, loss of cabin pressure", new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("f08dcad2-7d23-49d0-824a-cea1594b2d61"), "India Express B738 at Trivandrum on Jan 23rd 2023, FMS trouble", new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("f5f5b8c4-11e6-4291-8d1d-35905a60c77d"), "India Express B738 at Trivandrum on Feb 19th 2023, nose tyre damage on landing", new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("f7032957-105b-4b8b-9819-93a3e9c37f67"), "Scoot B789 near Adelaide on Apr 29th 2023, engine shut down in flight", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("f84a45d0-7001-4673-9416-6733106c0fa3"), "Hawaiian A332 at Kahului on Apr 30th 2023, smell of smoke", new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" },
                    { new Guid("f9497552-1b8d-453f-be4d-fbc3c26241b2"), "Network Australia F100 at Paraburdoo on Nov 22nd 2021, descent below minimum without visual reference", new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incident" }
                });

            migrationBuilder.InsertData(
                table: "Runways",
                columns: new[] { "Id", "Length", "RunwayDesignatorOne", "RunwayDesignatorTwo", "SurfaceType", "Width" },
                values: new object[,]
                {
                    { new Guid("01c85e17-7fd0-40b0-aed2-5c936b8d6bfa"), 2250, "23", "05", "Concrete", 360 },
                    { new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7"), 4200, "18R", "36L", "Grass", 300 },
                    { new Guid("05f0ba1e-14e6-4844-be1c-ecc3ba8ce3ac"), 1450, "15L", "33R", "Grass", 180 },
                    { new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043"), 2100, "33R", "15L", "Concrete", 510 },
                    { new Guid("0a388e35-ac42-42ea-be87-30c544a4c801"), 1150, "13R", "31L", "Gravel", 60 },
                    { new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0"), 2950, "16L", "34R", "Asphalt", 570 },
                    { new Guid("0b3549c4-f4ca-49c5-8d46-bc2e1982e9dd"), 3650, "24R", "06L", "Concrete", 390 },
                    { new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18"), 2600, "15R", "33L", "Grass", 270 },
                    { new Guid("156f64b0-5a7e-4cb4-a500-8c8eade22e12"), 4250, "35R", "17L", "Concrete", 450 },
                    { new Guid("1916389d-fc35-4793-8d45-5802e1fe3b60"), 4400, "32", "14", "Gravel", 210 },
                    { new Guid("1af9c434-b5b4-4987-8445-022407fc2d57"), 1800, "13", "31", "Gravel", 270 },
                    { new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00"), 4550, "27", "09", "Asphalt", 510 },
                    { new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8"), 3650, "24L", "06R", "Concrete", 450 },
                    { new Guid("1f63628a-9bcb-49f1-8272-b223b9976db9"), 4600, "29", "11", "Dirt", 540 },
                    { new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746"), 2750, "14R", "32L", "Sand", 180 },
                    { new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a"), 1150, "09L", "27R", "Asphalt", 120 },
                    { new Guid("23242025-2b97-4035-a5f5-e536b1dea585"), 1250, "09", "27", "Asphalt", 450 },
                    { new Guid("240e9bf7-7e0e-41e5-8e11-1a8936645e6b"), 4050, "12R", "30L", "Gravel", 510 },
                    { new Guid("263ed122-e755-4777-80f8-6a95c34f094c"), 1950, "08L", "26R", "Concrete", 180 },
                    { new Guid("26923970-1000-4a2c-8a79-a94194025663"), 3500, "31L", "13R", "Grass", 180 },
                    { new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45"), 3250, "23R", "05L", "Dirt", 300 },
                    { new Guid("2b9d9cb6-7291-4a26-a986-50365d57eb0d"), 1150, "22L", "04R", "Grass", 180 },
                    { new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb"), 4900, "03L", "21R", "Asphalt", 60 },
                    { new Guid("360930ad-6357-4982-ae5a-1f51132b364d"), 2450, "28R", "10L", "Concrete", 570 },
                    { new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c"), 2000, "11", "29", "Sand", 420 },
                    { new Guid("365d1fbb-00d3-4302-a66b-62c2b22ac887"), 3600, "05", "23", "Grass", 360 },
                    { new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf"), 3700, "28L", "10R", "Grass", 480 },
                    { new Guid("38e8e0a0-e79a-4315-980d-b65027360ea6"), 2700, "20L", "02R", "Asphalt", 540 },
                    { new Guid("3b96102b-caff-4fa9-ad6e-129beccdbbd2"), 2850, "27R", "09L", "Concrete", 210 },
                    { new Guid("4690cfd3-a95f-4fc3-a090-7427cb4a940a"), 3600, "17L", "35R", "Sand", 180 },
                    { new Guid("4ee00dc6-2f47-4855-98df-a30801ae9550"), 4650, "03R", "21L", "Asphalt", 540 },
                    { new Guid("4ff6fa4f-5533-4e5a-a33b-a23b56fc84f4"), 4350, "19R", "01L", "Grass", 570 },
                    { new Guid("53172577-0a4d-4383-9091-3822e0b8cd15"), 3600, "16R", "34L", "Grass", 300 },
                    { new Guid("5382e489-1590-427b-a49f-1b23cfc29c4f"), 4600, "01R", "19L", "Asphalt", 210 }
                });

            migrationBuilder.InsertData(
                table: "Runways",
                columns: new[] { "Id", "Length", "RunwayDesignatorOne", "RunwayDesignatorTwo", "SurfaceType", "Width" },
                values: new object[,]
                {
                    { new Guid("548cf69c-3622-40d4-9be2-36b8b47431cd"), 2150, "07", "25", "Concrete", 360 },
                    { new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21"), 1450, "23L", "05R", "Gravel", 480 },
                    { new Guid("590c27c4-5e4a-4c10-aa9c-67cb61886245"), 3100, "07L", "25R", "Concrete", 390 },
                    { new Guid("5b132149-77d3-47fd-a520-1d496900adb6"), 4500, "26L", "08R", "Concrete", 540 },
                    { new Guid("5bf826a5-d17b-4450-9035-6d682374c6b1"), 2850, "36R", "18L", "Gravel", 570 },
                    { new Guid("5cc30f4f-9194-4527-aeac-d2aa9413a97b"), 1150, "02", "20", "Grass", 390 },
                    { new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4"), 3500, "14", "32", "Sand", 300 },
                    { new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564"), 4950, "32R", "14L", "Sand", 360 },
                    { new Guid("6573c4b8-4a5f-48e1-a1d6-28701269d923"), 2950, "11L", "29R", "Asphalt", 390 },
                    { new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f"), 1850, "24", "06", "Gravel", 480 },
                    { new Guid("69585cc8-a642-4a1f-9ccd-e9f51d716cc8"), 1900, "11R", "29L", "Sand", 420 },
                    { new Guid("6e334296-4b9d-409d-b520-d652336c72af"), 3200, "04L", "22R", "Gravel", 210 },
                    { new Guid("72936986-8fe6-4210-a619-f1e4dbed58ad"), 1050, "13L", "31R", "Sand", 360 },
                    { new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c"), 4800, "28", "10", "Asphalt", 480 },
                    { new Guid("77a65462-a795-4f86-a003-79d6fe59fd0c"), 3050, "14L", "32R", "Grass", 570 },
                    { new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54"), 4050, "21L", "03R", "Dirt", 240 },
                    { new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc"), 3100, "32L", "14R", "Gravel", 210 },
                    { new Guid("7a06d874-9d78-4b6a-a39f-0ff1fbf1dbe2"), 4750, "21", "03", "Sand", 120 },
                    { new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587"), 3950, "29L", "11R", "Dirt", 180 },
                    { new Guid("7c552e43-e3e7-464b-934b-353e47fc3f83"), 2750, "02R", "20L", "Asphalt", 420 },
                    { new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125"), 1050, "20", "02", "Grass", 480 },
                    { new Guid("82d182d9-5e3d-451b-92d5-494b21859d37"), 4650, "34L", "16R", "Concrete", 510 },
                    { new Guid("84563346-802b-4262-a4bd-6ea9a06b462d"), 2450, "22R", "04L", "Grass", 390 },
                    { new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0"), 1650, "29R", "11L", "Dirt", 90 },
                    { new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b"), 4100, "10", "28", "Asphalt", 300 },
                    { new Guid("88138564-cb45-49d8-a43f-9320b8a1da0a"), 3100, "31R", "13L", "Sand", 90 },
                    { new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75"), 1850, "10R", "28L", "Sand", 570 },
                    { new Guid("8a4cea93-961b-47ba-929d-1e2cfb08f819"), 2550, "12L", "30R", "Concrete", 360 },
                    { new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5"), 2100, "35L", "17R", "Sand", 300 },
                    { new Guid("8b32297e-e690-483c-aa62-b588ccaafd60"), 1600, "08", "26", "Grass", 450 },
                    { new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757"), 2300, "20R", "02L", "Sand", 210 },
                    { new Guid("8cfa1025-60af-4629-ad66-d635e6d57ae7"), 4200, "07R", "25L", "Grass", 210 },
                    { new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24"), 3650, "18L", "36R", "Sand", 270 },
                    { new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f"), 2500, "19", "01", "Asphalt", 90 },
                    { new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19"), 4550, "36", "18", "Gravel", 180 },
                    { new Guid("9125a26d-cb1e-495e-b244-0bd199db8c80"), 2650, "15", "33", "Sand", 180 },
                    { new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d"), 4850, "16", "34", "Gravel", 180 },
                    { new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f"), 4200, "33", "15", "Grass", 60 },
                    { new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf"), 4250, "05L", "23R", "Sand", 150 },
                    { new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d"), 3200, "08R", "26L", "Concrete", 390 },
                    { new Guid("a7a129ef-57d3-488a-b881-f12ebc12a853"), 2750, "30L", "12R", "Asphalt", 210 },
                    { new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075"), 3950, "26R", "08L", "Grass", 450 }
                });

            migrationBuilder.InsertData(
                table: "Runways",
                columns: new[] { "Id", "Length", "RunwayDesignatorOne", "RunwayDesignatorTwo", "SurfaceType", "Width" },
                values: new object[,]
                {
                    { new Guid("ad6262e6-ec3c-4df6-8226-72fc9f09edaa"), 2050, "34", "16", "Sand", 270 },
                    { new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45"), 2600, "31", "13", "Gravel", 150 },
                    { new Guid("b290ec57-0357-4836-8e6f-0de744db9db4"), 4800, "34R", "16L", "Dirt", 120 },
                    { new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96"), 2650, "06", "24", "Concrete", 450 },
                    { new Guid("b8482374-60a0-48a0-b125-137e45010d4e"), 1000, "25L", "07R", "Sand", 330 },
                    { new Guid("b928d322-7d6a-45af-a14e-d4d17cead7d7"), 4000, "01", "19", "Sand", 150 },
                    { new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf"), 3900, "36L", "18R", "Sand", 210 },
                    { new Guid("bda016ac-4c9e-42c9-81ca-38c8c900f9ec"), 4400, "19L", "01R", "Asphalt", 270 },
                    { new Guid("c19cf343-a208-46b3-b285-bdf8fbb13f26"), 2500, "30R", "12L", "Gravel", 360 },
                    { new Guid("c8043beb-a90d-49db-a961-7250cc4f5dbe"), 2400, "22", "04", "Gravel", 180 },
                    { new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f"), 1400, "26", "08", "Gravel", 540 },
                    { new Guid("ca322b75-01ab-4c95-9c04-0ea6fd842790"), 1100, "21R", "03L", "Gravel", 180 },
                    { new Guid("cb849a9a-d3b4-4afb-b90a-28ff51c54e58"), 1200, "33L", "15R", "Gravel", 270 },
                    { new Guid("cbaf9970-1111-44bd-a5ef-4fb0274f983f"), 2100, "18", "36", "Concrete", 480 },
                    { new Guid("d0f2fbf5-79d4-44b8-a1a1-2c5f378758b0"), 2500, "06R", "24L", "Sand", 90 },
                    { new Guid("d428bcc6-dd6c-4abb-97c3-ab79170938ed"), 4900, "30", "12", "Asphalt", 450 },
                    { new Guid("da0ab1f3-a4e1-44a8-9ef4-0d85ac2e7769"), 1700, "17", "35", "Asphalt", 180 },
                    { new Guid("ddcb5c90-cdc0-4946-87f4-7ce7f84cdcae"), 1800, "03", "21", "Concrete", 180 },
                    { new Guid("de17f842-2069-4ed0-9696-c3152926766d"), 4500, "10L", "28R", "Asphalt", 360 },
                    { new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73"), 4250, "25R", "07L", "Asphalt", 120 },
                    { new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb"), 1200, "06L", "24R", "Grass", 240 },
                    { new Guid("e15827b8-4957-48e8-83cc-64c2278c8446"), 4150, "02L", "20R", "Concrete", 60 },
                    { new Guid("e31422e4-b5b0-4953-9a56-21afee581f61"), 3300, "35", "17", "Sand", 120 },
                    { new Guid("e5d3c6b9-b075-4723-aa5d-02189c5b302e"), 2050, "12", "30", "Concrete", 150 },
                    { new Guid("e622af83-3acb-4c05-941a-1315c3fe148d"), 1600, "25", "07", "Grass", 90 },
                    { new Guid("ed7e1529-76f9-4fac-a412-2022316ffc2d"), 1800, "27L", "09R", "Concrete", 480 },
                    { new Guid("f5fe3b97-bbb6-4504-9e9b-d97b45c1a83b"), 1200, "05R", "23L", "Sand", 510 },
                    { new Guid("f6a7e74d-445f-415b-a8a5-e6959c88db4b"), 3100, "01L", "19R", "Asphalt", 180 },
                    { new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b"), 4050, "04R", "22L", "Sand", 180 },
                    { new Guid("f82002a9-e16b-4e09-a239-5366b15ee530"), 1250, "17R", "35L", "Gravel", 420 },
                    { new Guid("fc8443ac-a73e-4dc2-a638-c12e785a7003"), 1450, "09R", "27L", "Grass", 180 },
                    { new Guid("fe042ca0-d09d-42e8-b793-08f386d8e907"), 3450, "04", "22", "Asphalt", 270 }
                });

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[,]
                {
                    { "YHM", new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7") },
                    { "ENA", new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0") },
                    { "BID", new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45") },
                    { "BUF", new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4") },
                    { "ANC", new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125") },
                    { "SBH", new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0") },
                    { "IAG", new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75") },
                    { "YKF", new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757") },
                    { "WST", new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075") },
                    { "YCM", new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45") },
                    { "SAB", new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf") },
                    { "GKT", new Guid("de17f842-2069-4ed0-9696-c3152926766d") },
                    { "SXM", new Guid("de17f842-2069-4ed0-9696-c3152926766d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0218ea27-cb00-4b8c-8049-db021e43583d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("038763cc-0af4-46ca-a4cd-9822b3fd6c57"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0434b789-6ff5-4f12-b153-8261ec9b171e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0d03e449-f9df-49e0-8c52-d9f59b6575fe"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0e55f1f0-e623-420b-9c7f-d92ad27054b9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("10cac8c2-eb22-4171-b3ce-1b4acda6b7e0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("11445c3c-e906-4206-a3ea-5404a627019e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("11cce2fd-d1ea-4b8a-b6e3-5c919138db72"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("14bd9eed-c2ec-491b-a87a-e7fce46c2797"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1559bfaf-9120-47d9-af6a-da1b6934bae0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("15927a4f-dc89-4faf-9af0-40589642ef54"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1892773e-bdb2-40f5-bd4d-7f3f8afb88a9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("18c2691f-e40c-469a-ae71-ecab22406cd8"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("18f47283-13d4-418f-a638-8227522302e1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1951e601-9bfe-4d32-a8a7-89e18abcd46c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("19fc73d0-7203-4112-876e-506e2bf9663d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1b9417d8-2fdd-4ebb-8399-bbfe50f9e13b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1cc4f2ab-4bc3-4eca-83ec-9a5e62725dca"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1d0b9ab2-767f-4bf2-ba81-2196c301c097"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1f482eb3-bda0-4f28-b891-378396f2f991"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("20410cf0-ea32-404a-9bf6-4af529339dac"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2270616a-5f35-4df0-a1d5-89e5ce29c034"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("22cdc2ef-e7f8-4893-affc-42c9575a9e2e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("236a1264-29db-4a88-851b-04392b04472c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("243325f8-ab21-4c2c-8f49-23ebd44f3dee"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("25dd9b8c-99bb-44b3-a98b-86b33d497d0a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("26b35488-be5c-40a8-ade0-5501f768ac8c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2804f4d5-7e68-415a-9f50-2d79c634e762"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("28fefb9c-17b0-43f2-b38b-b1c3aab7e07f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2946b491-f9b9-4ed9-9896-55b6481eaa9f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("298d4962-56e3-4a4f-9705-3546c05c1b2b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2b8fc4b6-cbf1-464f-ae40-a02fbd079b0b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2d3108a5-f8df-4dd5-a975-bfa0e488c2fd"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2d47641a-3d73-4996-902c-52226d83e3d1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3064ebcc-f366-4dd8-93ee-f998c3f7328f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3420ce03-baf0-41cc-b4f7-cf436c470fd3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("34962014-777b-4ec9-bc02-42066fbe2aae"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("35640bc5-8162-4429-a412-c983358ea924"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3568c2bd-8203-470c-b2bc-c524fdb1db74"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("375fdc03-63a3-4085-baf8-d04651585616"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("37e54a85-8fca-4e98-807a-11bbd2d6c3c8"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3978ff7d-406b-4987-876d-01afa9bd0178"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("398add8a-a222-4176-8db9-4e8ad487531b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3a9b3be2-d82e-4d74-ad7f-6da370cb2400"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3bde6a81-4da6-4b3d-a763-774a2c44c0d8"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3c67c85d-5c8f-41a2-9dc6-a6deb5050edb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3cbd9e78-12db-44fc-a1fe-07a5cb7aeb9d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3e5c92a5-b13f-4da2-a24b-80ba8ab2111a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3f6003c3-6521-4ced-9901-5cd3ff41e0cb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4054f929-b335-43f1-9421-656dd83e3da2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("41a7f5e0-3281-4d9e-bb73-0de3e51bf097"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("41fdd98c-2b1d-4009-8698-c453d0535d74"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("44c82ca0-4c04-4b59-b751-667ae58a6848"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("45ab18d9-5399-416d-b635-3093c08da162"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("45eb1a07-560c-404c-aba0-13209e7b6a83"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4686971d-5849-4e92-958b-43611f06eeb9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("487a5420-cb92-4455-952a-6abcfd516bb4"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4897c7b0-0f89-4a39-ad1e-faaa4aff56d9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("489a6cb1-909c-40d5-a89c-8faad2d929ce"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("49151a53-f572-4a87-a6a0-d8e897bd84e9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4ac76aa5-ef2f-422b-b985-ffdc11e2f148"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4c7af6c8-f87f-40ad-bf8d-b5b0826860b3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4c8bba4c-1d05-4a95-955d-5fa49bf0e6ab"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4f8fd3ba-b9f9-4c65-869d-e141007bc143"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("50c80266-5545-43ae-9ded-9d7d82cce754"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("52ca76e5-4995-4adb-92f5-0ce2c549f0d3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5414b160-a242-4f66-8d52-6ee28b39aeed"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5552497f-001f-4fd8-aa56-65bd69c2f3ee"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("55ccfc96-5cbc-4634-b2fb-716666e8ed42"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("56458cc3-6a13-44b3-9bf7-1ad356162e44"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("573a189f-223b-45a6-b826-63f8ce75071f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("59996896-73c2-4688-b972-1824554a6118"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("59d88a51-5b88-45c0-98c4-ae9a02dce8fd"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5aa06c7c-d653-46a2-ab15-b51179761a48"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5ba3b939-f028-4b60-bce7-a2782bf352bc"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5faaa1f7-2330-4e59-b2b3-ab0cb91d6037"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("60b1483a-1183-4fb0-b0b1-807e9bcff431"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("61369b93-8ac2-4913-bcd8-f2d322a686d6"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("61d8225a-3a9f-4975-9b71-7df92e23f2ea"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("64db7a0d-0256-444e-8b5c-45e7949b816c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("66858dbf-bb59-40bf-ac04-2e44dd2b91ae"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("68094bdf-71ff-457e-b25f-08ebb1671c47"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("687c27e6-68c0-48b0-95b8-8d14633f82c0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6937ddc5-45ae-4874-b33f-1bde09060a34"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("69449aac-0051-4558-a753-99166d453c7a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6a303c04-3262-4127-bc91-99b1b297c478"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6a5a0373-80c5-4d9d-a396-ecacba800d65"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("70000f32-fe6e-483b-85ea-54b5752971ac"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("70989495-3e91-4be0-9a37-f01a5d3178eb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("70be182d-879b-48cc-95b4-96cfa93b3478"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("71990ac5-6637-4625-8835-b73e0b624628"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("7c147614-1c5b-4428-a957-d818bb867a3a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("7ea83e94-6fdc-4458-b958-e8a9789e2a88"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("7fedcfd6-624f-41cf-99db-a24e5f34a56b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("801613d0-664e-41c1-b68c-508efc7ecb27"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("80cc4355-011b-43f7-b8d7-4f559095040f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("80ff88be-7fcb-4a2b-9dc3-649e82efd851"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("828fc764-cb4f-4728-a66c-8ffe607e89e3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("83c716e5-8f7b-44f9-91ad-58cec161ab1b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8478d912-5e8a-4065-bc07-616402b20238"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("85285234-005e-4585-a884-ce3854128450"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8586c2b4-0bd4-44bc-a828-4d4d563cdcd9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("85a5df29-7d5f-42f4-a668-c3dccf78999c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8678a055-6bcf-4888-9696-b4fbfcecce67"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("86951b81-fca5-4b0a-8035-d50b79aedc4f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("86af95cf-e82a-4e7d-bec1-76c0b2f58b7e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("86b127ba-9d70-4a19-9ad6-cd3b99278970"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("86b99408-3551-4afd-b85e-28a24d4c1e3b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("86e9b094-fc72-46f9-a0ca-eac7c0087c60"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8bf9b52f-03da-411b-ade3-cd5384dafeec"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8c701e39-7075-4f1f-9f43-30385d817e8b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8d062f46-e5df-4785-b0a8-ab37e0b67e68"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8d99648e-4172-4613-8f2e-f97d1daa1fc1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9189f8de-8336-418b-97af-cc6735e45834"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("938eca17-da75-4430-b6e7-5715c2908aaf"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("95f0fa1f-6ef8-47c5-bfec-9574a2b51f87"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("965cb058-3318-47c3-99f4-8ed8cd55892c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("975e617d-1018-4ab9-943c-a2d1071e0f85"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9b0a6fee-7696-4611-abf9-6659eff88af9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9bc8b668-58d2-48e2-841c-4b2b4e3c0bb4"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9e20d935-293b-4f6b-9a9f-adff134f6e9c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9eff6f10-0f79-4bdb-96d7-1a5ff4d824a7"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("a0b5bfe7-2de0-4469-b408-988c164ea547"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("a20e35fa-3a8b-413b-98fd-e0119107e8e0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("a32d4a7d-d360-4d19-9ddb-beaf00f26031"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("a88d1fa0-93fd-4554-a618-b8c4dfe815e0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ac13b4fb-816a-45a2-ac65-93d97be8fc79"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ad045a02-3dd6-44d7-bf7c-498227318aeb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b2aa0488-193b-45ad-803d-04d788e93562"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b3bbc347-9d94-4554-901c-bd014b75dd2c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b4839094-9a53-4d84-a499-e6da3c7cd76f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b7954598-218c-4bbc-afc0-9bdfa1bf6f14"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bb4a4a89-d7ce-4b9b-973c-d5ae93281487"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bb52f35c-bd8a-468b-b242-25f71b4286ec"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bba884ed-0ae6-4341-867d-9466b82d7842"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bbac0457-d33c-4e88-9548-50e7fbea2c81"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bd5f93fe-4fb0-4853-b333-0641aaab855f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bd6a8ce6-88e1-49df-9aff-5b84d3e682d8"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bd81647e-287a-4aac-8c72-7ad3e0f12ce1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bd99def8-fcc7-40bd-a446-89a5485d07c6"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c13a0d65-a3ea-4cd5-a530-c622d802f67a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c2a55d7c-65b9-4f70-bb56-f8f501c4e269"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c31e2825-f258-499f-a2f8-5b8346e632ab"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c3e85507-074d-4dc1-8e09-978ec32dd14a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c73e62b6-fe96-4d48-aed8-9698c33bd6ef"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c771303b-7e3b-4d12-9d4d-9c538810a429"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("cb29adb3-34e2-485d-97e3-216d1570c8ef"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("cea357c4-ba35-4338-8497-6ae6f428a4df"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d00fd3d0-3cef-4892-a484-78e34fe75ce6"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d14cb529-50a3-4f93-a889-64b8170dfd52"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d26a487d-51f2-4800-9b20-8c9ef173b882"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d27c8108-07bd-405a-aaa2-74a5c40008d6"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d3a634a2-943e-400a-9b47-abc5b40c2e69"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d5bd2a9a-1066-4889-8d25-2f0eeb9035ae"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d9f5e6c4-c48d-484e-8810-cb8f0e527422"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("dd965a8e-930d-42a1-b2cd-d1bf603a909c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("de904f6d-c8e5-4cd2-8384-77d0df029674"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e044b376-d1e5-400e-80aa-bab52d202b7e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e40bcf84-4661-4948-8928-7fadeedac17f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e70be7b8-1d1f-4bad-a52c-ca2f51255006"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e7535a1c-15b8-4f36-a80f-a31cd75d12a5"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e9ad8edf-faac-47e4-8032-d61170e7f1a5"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("eaed6c1e-df3e-4834-99c0-3cca3a47e8ef"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("eb5dbabe-58f6-417b-abd2-d0e07daa3b58"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ec19b794-a976-461f-8177-edbdd0d28c42"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ed10b11d-524e-431f-87e5-684cb560d922"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ed479bde-b136-40fc-9026-fc0e65ac6e31"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ede76c5f-6db0-4b65-bb2f-ad6f26f37b9a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ee41db14-555f-4451-9e14-af94d8be980f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ef19532a-01bf-429d-9ff4-3cd87877203f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ef195491-1a27-4ceb-85ee-66a4294ef291"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f08dcad2-7d23-49d0-824a-cea1594b2d61"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f5f5b8c4-11e6-4291-8d1d-35905a60c77d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f7032957-105b-4b8b-9819-93a3e9c37f67"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f84a45d0-7001-4673-9416-6733106c0fa3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f9497552-1b8d-453f-be4d-fbc3c26241b2"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01c85e17-7fd0-40b0-aed2-5c936b8d6bfa"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("05f0ba1e-14e6-4844-be1c-ecc3ba8ce3ac"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("099b2a88-2906-4890-8c1d-9e4988cb6043"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a388e35-ac42-42ea-be87-30c544a4c801"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0b3549c4-f4ca-49c5-8d46-bc2e1982e9dd"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0ce09b75-3a47-4e93-999c-41576b42cf18"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("156f64b0-5a7e-4cb4-a500-8c8eade22e12"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1916389d-fc35-4793-8d45-5802e1fe3b60"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1af9c434-b5b4-4987-8445-022407fc2d57"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1d8c2065-2708-472e-afd4-ca53ed3f9e00"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1e131b53-73ab-4be5-b902-36f33d30cbc8"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("1f63628a-9bcb-49f1-8272-b223b9976db9"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("228d8bff-6de5-4ddd-acf1-49c4cee2f746"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("22983d69-b07a-416b-a84a-3958ef3fcd6a"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("23242025-2b97-4035-a5f5-e536b1dea585"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("240e9bf7-7e0e-41e5-8e11-1a8936645e6b"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("263ed122-e755-4777-80f8-6a95c34f094c"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("26923970-1000-4a2c-8a79-a94194025663"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b9d9cb6-7291-4a26-a986-50365d57eb0d"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("30897162-9c40-416a-aabd-fdb1880c4cbb"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("360930ad-6357-4982-ae5a-1f51132b364d"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3621d4f6-c0a3-40c2-8229-c52a9674122c"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("365d1fbb-00d3-4302-a66b-62c2b22ac887"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3827284c-9cb1-46ab-a51a-50a2cba1bfdf"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("38e8e0a0-e79a-4315-980d-b65027360ea6"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("3b96102b-caff-4fa9-ad6e-129beccdbbd2"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4690cfd3-a95f-4fc3-a090-7427cb4a940a"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ee00dc6-2f47-4855-98df-a30801ae9550"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("4ff6fa4f-5533-4e5a-a33b-a23b56fc84f4"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("53172577-0a4d-4383-9091-3822e0b8cd15"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5382e489-1590-427b-a49f-1b23cfc29c4f"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("548cf69c-3622-40d4-9be2-36b8b47431cd"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("586a6c00-3b63-4f48-9dc7-b899bba91c21"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("590c27c4-5e4a-4c10-aa9c-67cb61886245"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5b132149-77d3-47fd-a520-1d496900adb6"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5bf826a5-d17b-4450-9035-6d682374c6b1"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5cc30f4f-9194-4527-aeac-d2aa9413a97b"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5ecb0c6f-fff8-4459-bf41-567c5b05b564"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6573c4b8-4a5f-48e1-a1d6-28701269d923"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("68eef3a3-ee6d-45d2-81a8-00537fbd219f"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("69585cc8-a642-4a1f-9ccd-e9f51d716cc8"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("6e334296-4b9d-409d-b520-d652336c72af"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("72936986-8fe6-4210-a619-f1e4dbed58ad"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("778e256d-1a1c-48ab-ba2a-dd0c8bba3d7c"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77a65462-a795-4f86-a003-79d6fe59fd0c"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("77c2946c-ef98-41e2-91b5-3f1e0d9dda54"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("79439eb0-3786-4da0-b292-838ff2bf64cc"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a06d874-9d78-4b6a-a39f-0ff1fbf1dbe2"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7a3fa344-2ea7-4d34-b95b-2fea6b063587"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("7c552e43-e3e7-464b-934b-353e47fc3f83"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("82d182d9-5e3d-451b-92d5-494b21859d37"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("84563346-802b-4262-a4bd-6ea9a06b462d"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("873c9768-e2ed-426c-9c13-4011fcd3365b"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("88138564-cb45-49d8-a43f-9320b8a1da0a"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8a4cea93-961b-47ba-929d-1e2cfb08f819"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8af95d1e-52fe-4357-8a6c-6dd97913cff5"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8b32297e-e690-483c-aa62-b588ccaafd60"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8cfa1025-60af-4629-ad66-d635e6d57ae7"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9551d1-13be-4804-a8d6-62dc30d85a24"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8f9ed5c7-54fa-452b-9063-3308400bed7f"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8fd3ccb2-dd30-4efe-afb0-d253a85e8e19"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9125a26d-cb1e-495e-b244-0bd199db8c80"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("94aabd30-5ca1-430c-b00e-5b0be535cb8d"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9659908c-62f3-4d8d-af41-e98345f6f77f"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("97ca3857-d17b-4f01-9546-079c7de05fcf"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("9eeff0d4-eb63-416d-a8fe-0d9f7c3f354d"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("a7a129ef-57d3-488a-b881-f12ebc12a853"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ad6262e6-ec3c-4df6-8226-72fc9f09edaa"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b290ec57-0357-4836-8e6f-0de744db9db4"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b2b204c6-88a1-43f2-bee5-d45f2a717e96"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b8482374-60a0-48a0-b125-137e45010d4e"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("b928d322-7d6a-45af-a14e-d4d17cead7d7"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bda016ac-4c9e-42c9-81ca-38c8c900f9ec"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c19cf343-a208-46b3-b285-bdf8fbb13f26"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c8043beb-a90d-49db-a961-7250cc4f5dbe"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("c805c5be-78aa-4b06-ac02-4bb7afd9574f"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ca322b75-01ab-4c95-9c04-0ea6fd842790"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cb849a9a-d3b4-4afb-b90a-28ff51c54e58"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("cbaf9970-1111-44bd-a5ef-4fb0274f983f"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d0f2fbf5-79d4-44b8-a1a1-2c5f378758b0"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("d428bcc6-dd6c-4abb-97c3-ab79170938ed"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("da0ab1f3-a4e1-44a8-9ef4-0d85ac2e7769"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ddcb5c90-cdc0-4946-87f4-7ce7f84cdcae"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e06b10c5-8eae-442c-a407-01f029c4ac73"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e0a3b3ec-fec7-4c06-81ba-f7f4c44c84cb"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e15827b8-4957-48e8-83cc-64c2278c8446"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e31422e4-b5b0-4953-9a56-21afee581f61"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e5d3c6b9-b075-4723-aa5d-02189c5b302e"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("e622af83-3acb-4c05-941a-1315c3fe148d"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ed7e1529-76f9-4fac-a412-2022316ffc2d"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f5fe3b97-bbb6-4504-9e9b-d97b45c1a83b"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f6a7e74d-445f-415b-a8a5-e6959c88db4b"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f80875d8-1c95-430c-9271-b275ca5edb9b"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("f82002a9-e16b-4e09-a239-5366b15ee530"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fc8443ac-a73e-4dc2-a638-c12e785a7003"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("fe042ca0-d09d-42e8-b793-08f386d8e907"));

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YHM", new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ENA", new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BID", new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "BUF", new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "ANC", new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SBH", new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "IAG", new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YKF", new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "WST", new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "YCM", new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SAB", new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "GKT", new Guid("de17f842-2069-4ed0-9696-c3152926766d") });

            migrationBuilder.DeleteData(
                table: "RunwaysAirports",
                keyColumns: new[] { "AirportId", "RunwayId" },
                keyValues: new object[] { "SXM", new Guid("de17f842-2069-4ed0-9696-c3152926766d") });

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("01f5aeb6-703b-4a1a-859d-c71b6ec666f7"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("0a93f7cb-71ff-43c8-a8d5-db6aae6127f0"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("2b0d7c4c-0204-4317-b7c2-c11c0c8f6c45"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("5dbc0258-3480-47fb-b47d-95b1c240d0e4"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("812d9a71-3ed4-4061-9975-2ec6ba433125"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("87387d2d-38d5-4c4f-8eee-557fc432c5a0"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("890558cf-bfca-4c89-bc31-cd763a02ee75"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("8c707595-be2a-40ac-b7f7-32a3ff97c757"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("aa1ba7bb-5991-47e4-9f8b-3add8b60d075"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("ae8bc761-486f-4020-a0ea-739f0f131b45"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("bac84255-76a9-43a4-ac0c-4db1baa717cf"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: new Guid("de17f842-2069-4ed0-9696-c3152926766d"));

            migrationBuilder.AlterColumn<string>(
                name: "Occurrence",
                table: "HeraldPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "RunwaysAirports",
                columns: new[] { "AirportId", "RunwayId" },
                values: new object[,]
                {
                    { "ANC", "1bdefbbc-1ab7-478c-af84-052ac66235b8" },
                    { "WST", "1bdefbbc-1ab7-478c-af84-052ac66235b8" },
                    { "ENA", "2c509f31-28f2-4431-968c-53596d98116c" },
                    { "SAB", "2c509f31-28f2-4431-968c-53596d98116c" },
                    { "IAG", "6ba984d8-644c-4d42-9909-4c1e76f1bf67" },
                    { "BUF", "875682aa-ff3f-4f8e-8e06-3529b271895c" },
                    { "SXM", "a4247cd5-1475-4771-a703-e79fbb092108" },
                    { "YKF", "aa639864-465e-4d50-8baf-b55615bfa3f4" },
                    { "YCM", "aacabf09-804f-4c32-ba81-38db7c476134" },
                    { "BID", "b2a93364-116d-419c-999c-492596ecba6f" },
                    { "GKT", "b9eba418-353c-49fd-b69e-f0ffb38a4d81" },
                    { "YHM", "bc4a64f8-4bbf-4222-a11d-d938099c32a1" },
                    { "SBH", "f97199aa-7ddb-4e17-9e6f-24dfc488c3c7" }
                });
        }
    }
}
