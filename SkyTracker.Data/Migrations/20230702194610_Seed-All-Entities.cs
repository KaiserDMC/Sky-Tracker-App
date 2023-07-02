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
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("03b6174f-0d3e-4d06-b9e8-0b9e8c8407d1"), "HiSky A21N near Manchester on May 11th 2023, pilot incapacitated", "Sunday May 14th 2023", "Incident" },
                    { new Guid("03dd4faf-2d19-4bf4-b651-39f56b0f7538"), "Delta B752 at New York on Mar 15th 2023, slat disagree", "Sunday Mar 19th 2023", "Incident" },
                    { new Guid("04085577-8c4e-4d03-8583-0138a687bc53"), "American B772 at Barcelona on Mar 20th 2022, flap fairing detached in flight", "Tuesday Feb 14th 2023", "Incident" },
                    { new Guid("07413df7-aa3e-420d-b714-bf1f696b588e"), "Lufthansa Cityline A319 near Munich on Jan 15th 2023, failure of weather radar", "Monday Jan 16th 2023", "Incident" },
                    { new Guid("080a36c7-7a91-4be3-a978-d1daa2ae0bb6"), "Iceland B39M at Toronto on Mar 4th 2023, tail strike on balked landing", "Monday Mar 13th 2023", "Incident" },
                    { new Guid("0844e747-2837-4376-96e2-1106b65c3bd2"), "Transavia B737 at Rotterdam on Apr 24th 2021, we think we are 6500 feet, military radar tells FL110, unreliable speed and altitude on both left and right pitot systems", "Thursday Mar 23rd 2023", "Incident" },
                    { new Guid("0895c54e-d438-469c-b4c1-9c888448f906"), "Wideroe DH8A at Svolvaer on Dec 22nd 2022, GPWS saves the day", "Saturday Jan 28th 2023", "Incident" },
                    { new Guid("09857b40-4d75-467e-92c1-da66ac27df37"), "Qatar B773 at Brisbane on Dec 31st 2022, flaps problem", "Sunday Jan  1st 2023", "Incident" },
                    { new Guid("0c4057a5-81e1-4e3e-a723-2a373c68bea5"), "Hawaiian A332 at Kahului on Apr 30th 2023, smell of smoke", "Wednesday May  3rd 2023", "Incident" },
                    { new Guid("0d1b6cb7-1412-4a1c-af19-60daf8aba4df"), "Key Lime SW4 and private aircraft at Denver on May 12th 2021, midair collision", "Tuesday Apr  4th 2023", "Accident" },
                    { new Guid("0dfb6746-8487-4b6b-a797-e4f25a3bc7a1"), "Volotea A319 near Bordeaux on Jun 2nd 2023, loss of cabin pressure", "Thursday Jun  8th 2023", "Incident" },
                    { new Guid("0f14ef08-ef61-436a-b332-17be61fc3be2"), "Avianca A320 at San Andres on Apr 25th 2023, bird strike", "Wednesday Apr 26th 2023", "Incident" },
                    { new Guid("10a2ae53-4976-4417-81bc-d1a17478b9de"), "Delta B763 near New York on Jun 10th 2023, engine problem", "Tuesday Jun 13th 2023", "Incident" },
                    { new Guid("10ea6608-987c-492c-9332-4e9b91412a99"), "Longtail B744 at Maastricht on Feb 20th 2021, rain of engine parts", "Wednesday Apr 19th 2023", "Accident" },
                    { new Guid("125a82e2-081e-41fc-a311-0aa9cf43e96f"), "Perimeter DH8C at Gods Lake Narrows on Jun 3rd 2023, hydraulic leak", "Saturday Jun 10th 2023", "Incident" },
                    { new Guid("134ecca9-77c9-4d77-b253-17dc695c94e1"), "Fedex B763 and Southwest B737 at Austin on Feb 4th 2023, loss of separation on runway resolved by go around", "Friday Mar  3rd 2023", "Incident" },
                    { new Guid("1386e865-6927-4b2a-85ee-4454775c9777"), "Indigo A20N at Surat on Feb 26th 2023, bird strike", "Monday Feb 27th 2023", "Incident" },
                    { new Guid("16ce9df8-b8b3-47a2-bdd5-931c69c1f9bc"), "Bluebird B734 at Paris on Feb 10th 2023, huge bangs on descent", "Thursday Feb 23rd 2023", "Incident" },
                    { new Guid("172ce39d-d67c-4ffa-b02b-c9c4d8b51123"), "Asiana A333 at Tokyo on Feb 12th 2023, oil leak", "Sunday Feb 12th 2023", "Incident" },
                    { new Guid("17344fe1-09d5-4752-be88-0f9dbd87662a"), "Algerie B738 near Marseille on Jun 8th 2023, loss of cabin pressure", "Friday Jun  9th 2023", "Incident" },
                    { new Guid("174d9457-41dc-4afd-935a-c76ad74b2f18"), "Cargolux B744 at Luxembourg on May 14th 2023, could not retract landing gear, on return right center gear bogey separated", "Monday May 15th 2023", "Accident" },
                    { new Guid("1786f2ef-e3e6-4f55-ae35-014a8c03ee91"), "British Airways A320 near Zurich on Mar 29th 2023, unusual odour on board", "Friday Mar 31st 2023", "Incident" },
                    { new Guid("17a32d45-881b-446c-aee6-c5524fdc84dc"), "United B763 at Houston on Mar 28th 2023, engine shut down in flight", "Wednesday Mar 29th 2023", "Incident" },
                    { new Guid("17ed9c16-f586-420c-9790-a99bb6755797"), "Cathay B773 at Hong Kong on Jun 24th 2023, rejected takeoff", "Saturday Jun 24th 2023", "Accident" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("207618ad-6fee-47f0-9fef-b9250c8d25b2"), "El Al B772 over Germany and Austria on Apr 10th 2023, losscomm", "Tuesday Apr 11th 2023", "Incident" },
                    { new Guid("24398c28-06f4-4555-97f9-698501e9489a"), "Edelweiss A320 at Zurich on Jun 18th 2023, gear problems on departure", "Thursday Jun 22nd 2023", "Incident" },
                    { new Guid("24a92392-e52c-4f90-9899-3ea8b9f8e358"), "United B772 near Lincoln on Feb 4th 2023, engine shut down in flight", "Sunday Feb  5th 2023", "Incident" },
                    { new Guid("26a914de-0202-495e-b093-869868fbdb5d"), "Indigo A21N at Delhi on Jun 10th 2023, engine failure", "Sunday Jun 11th 2023", "Incident" },
                    { new Guid("286877e5-b6f3-4484-8936-d933e5dc0f2e"), "United B788 near Dublin on May 4th 2023, cracked windshield", "Tuesday May  9th 2023", "Incident" },
                    { new Guid("2a721de5-e0eb-46c2-816b-1eb649da7bee"), "TAROM B738 near Bucharest on Mar 25th 2023, captain incapacitated", "Monday Mar 27th 2023", "Incident" },
                    { new Guid("2b554fd2-1d3f-46cf-839f-ae552f5080c0"), "India B773 near Stockholm on Feb 22nd 2023, engine shut down in flight", "Wednesday Feb 22nd 2023", "Incident" },
                    { new Guid("2da6c8af-abb4-4b59-bc78-04cefd0f4bb1"), "Server harddisk crashed, we are back up in full service after about 6 hours", "Saturday Mar 25th 2023", "News" },
                    { new Guid("2ef5c91f-3087-48da-8bfc-509f24bef2a4"), "Easyjet A320 at Geneva on May 18th 2023, fire in overhead locker", "Friday May 19th 2023", "Incident" },
                    { new Guid("3062c395-588d-49b4-8ebd-09b074cb6e39"), "ANZ B789 enroute on Jun 19th 2023, cracked windshield", "Monday Jun 19th 2023", "Incident" },
                    { new Guid("322cdb07-0c2d-4ae1-8d23-bb9604d025e1"), "British Airways A320 near Manchester on Jan 27th 2023, fumes in cockpit", "Friday Jan 27th 2023", "Incident" },
                    { new Guid("3348ede5-1a2c-48da-8f5d-49f0ba0b067d"), "United B753 over Pacific on May 24th 2023, rudder issues", "Thursday May 25th 2023", "Incident" },
                    { new Guid("34ec71f9-12dd-447f-b04e-8cfa949f21d0"), "Delta BCS1 near Kansas City on Jan 31st 2023, cracked passenger window", "Wednesday Feb  1st 2023", "Incident" },
                    { new Guid("3536da5a-5ae7-49d8-b6d4-09107b3e9ce7"), "India Express B738 at Kozhikode on Feb 24th 2023, technical problem", "Friday Feb 24th 2023", "Incident" },
                    { new Guid("3687c432-526d-4508-8512-b66f649b80f5"), "Singapore B744 at Nairobi on Apr 17th 2023, rejected takeoff due to bird strike", "Monday Apr 17th 2023", "Incident" },
                    { new Guid("373851f2-ae94-4a4f-82e7-ba214d2277c2"), "El Al B789 at Tel Aviv on Apr 4th 2023, engine shut down in flight", "Wednesday Apr  5th 2023", "Incident" },
                    { new Guid("37ac503c-f49b-4d09-955c-aca7db551205"), "Aeromexico B38M at Mexico City on May 10th 2023, rejected takeoff after operational error", "Thursday May 18th 2023", "Incident" },
                    { new Guid("39671437-2415-4e49-8d34-2cf04e7a6767"), "Flydubai B39M at Male on Mar 28th 2023, burst tyres on landing", "Tuesday Mar 28th 2023", "Incident" },
                    { new Guid("3aa2b7a1-27fa-42f7-872a-2db39a91ba07"), "KLM B772 over Mediterranean on Feb 9th 2023, cabin problems - electrical fire in oven", "Thursday Jun  1st 2023", "Incident" },
                    { new Guid("3ce3a81f-9f08-48fd-81fb-b5a02f33efb9"), "Mahan A346 near Almaty on Mar 5th 2023, engine fire indication", "Thursday Mar 16th 2023", "Incident" },
                    { new Guid("3d483d4a-36ae-476e-8c10-cb16e4706db7"), "Spicejet B738 near Patna on Nov 17th 2021, loss of cabin pressure causes momentary incapacitation of captain", "Friday Jun 30th 2023", "Report" },
                    { new Guid("3d812850-4cfd-42a8-9533-433f0115b2bf"), "Easyjet Europe A319 near Naples on Jan 5th 2023, flight management computer failure", "Saturday Jan  7th 2023", "Incident" },
                    { new Guid("3dcf1a65-b680-43c6-9913-85e8c6ffa8c2"), "Easyjet Europe A320 at Bordeaux on Dec 31th 2022, cleared to land on occupied runway", "Friday Jan 13th 2023", "Incident" },
                    { new Guid("402e1a8e-cbd8-45a6-ae2d-6160a10c5ed5"), "Kasai AN26 at Lisala on Apr 11th 2023, runway excursion on landing", "Wednesday Apr 12th 2023", "Accident" },
                    { new Guid("409efa08-5558-4050-beae-31131509c635"), "Norwegian Sweden B738 at Gothenburg on Feb 2nd 2023, balls", "Saturday Feb  4th 2023", "Incident" },
                    { new Guid("4197ea45-7897-4e04-b22d-4051bf250cd3"), "Flair B38M over Gulf of Mexico on Feb 7th 2023, loss of cabin pressure", "Friday Feb 10th 2023", "Incident" },
                    { new Guid("42c2a47b-3942-457b-a670-2063ecd0f152"), "VARA A320 near Adelaide on Mar 3rd 2023, first officer incapacitated", "Wednesday Mar  8th 2023", "Incident" },
                    { new Guid("44c64a08-edef-410a-a62f-0243d51f5fdb"), "India Express B738 at Abu Dhabi on Feb 3rd 2023, engine fire", "Friday Feb  3rd 2023", "Incident" },
                    { new Guid("45143a8b-a1ea-409f-8add-44202603fa39"), "France A359 near Osaka on May 28th 2023, weather radar and airspeed malfunction", "Friday Jun 16th 2023", "Incident" },
                    { new Guid("469eec68-5c3d-42a6-a442-8b473a87f700"), "Airwork B733 at Darwin on Nov 4th 2021, cabin did not pressurize", "Tuesday May 16th 2023", "Incident" },
                    { new Guid("48078e47-541a-4c5c-9df3-f0f819e639f9"), "Delta A320 at Omaha on Nov 19th 2022, bird strike", "Friday Mar 10th 2023", "Accident" },
                    { new Guid("50f09d72-1754-488e-9083-d5afbe541d96"), "Skywest CRJ2 near Pierre on Apr 12th 2023, engine failure", "Friday Apr 14th 2023", "Incident" },
                    { new Guid("52fd28e6-c0b0-4e08-8be8-1361a93f6920"), "Shree DH8D near Kathmandu on Mar 9th 2023, engine fire indication", "Thursday Mar  9th 2023", "Incident" },
                    { new Guid("549e58be-16d2-4894-95b7-42bb0f704263"), "Network Australia F100 at Paraburdoo on Nov 22nd 2021, descent below minimum without visual reference", "Friday Mar 24th 2023", "Incident" },
                    { new Guid("54fb2e0b-dae1-4407-9731-dde097678781"), "Skywest CRJ2 at Houston on May 11th 2022, runway excursion on landing", "Thursday Jan 26th 2023", "Incident" },
                    { new Guid("550f66f9-f8be-4913-83c6-fb1ec3eaad03"), "Delta B738 at New York on Apr 23rd 2023, lightning strike", "Friday Apr 28th 2023", "Incident" },
                    { new Guid("561b9301-9ec4-4f10-bf43-f4d828ef681f"), "Delta B763 over Atlantic on Jul 7th 2022, flooding on board, autopilots disconnected", "Friday Apr 21st 2023", "Incident" },
                    { new Guid("5795a442-a9fd-4acd-a599-cbc26a56fb03"), "Canada B772 over Atlantic Ocean on Dec 18th 2022, one flight crew and two cabin crew incapacitated", "Thursday Jan  5th 2023", "Incident" },
                    { new Guid("5884fd75-09fa-4e2b-9af6-ee9fbf97fed9"), "TUI B738 enroute on May 4th 2023, one flight crew incapacitated", "Friday May  5th 2023", "Incident" },
                    { new Guid("5b3a48a1-2dae-4d4e-9b27-e88963e9f702"), "Indigo A20N near Hyderabad on Mar 18th 2023, hail strike", "Sunday Mar 19th 2023", "Incident" },
                    { new Guid("5c9e3735-e61b-46da-b139-f845c41a7c5f"), "ANZ B789 near Auckland on Jun 23rd 2023, fuel issues", "Tuesday Jun 27th 2023", "Incident" },
                    { new Guid("5d5c40b5-0f63-45c4-b9a1-a0766a9aec9c"), "United Nigeria E145 at Lagos on May 31st 2023, runway excursion", "Friday Jun  2nd 2023", "Accident" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("5d78320f-0a61-4c3d-9ea1-0383d9ee77c0"), "Indigo A21N at Delhi on Jan 3rd 2023, hydraulic failure", "Tuesday Jan  3rd 2023", "Incident" },
                    { new Guid("5e66a241-0455-4e0b-8d2a-065bebe93335"), "Delta B763 at Edinburgh on Feb 10th 2023, engine shut down in flight", "Friday Feb 10th 2023", "Incident" },
                    { new Guid("5e8be9b0-5f7a-44b6-8bf5-fb0dd7786822"), "British Airways B773 near Singapore on Jun 16th 2023, turbulence causes injuries", "Sunday Jun 18th 2023", "Accident" },
                    { new Guid("5e943734-d5d4-4692-b1aa-abeed7bcf0ed"), "Sunwing B738 at Santa Clara on Apr 26th 2023, could not retract left main gear", "Thursday Apr 27th 2023", "Incident" },
                    { new Guid("5fa191f8-52ea-4ffe-b0fd-8a56a41a548f"), "Aeroregional B735 near Quito on May 5th 2023, loss of cabin pressure", "Thursday May 11th 2023", "Incident" },
                    { new Guid("6055436f-f224-4a74-bafc-bfef85274bfb"), "India Express B738 at Trivandrum on Feb 19th 2023, nose tyre damage on landing", "Sunday Feb 19th 2023", "Incident" },
                    { new Guid("605b2055-e572-4ecc-a804-7a51c6639454"), "Azul AT72 at Valadares on Jun 3rd 2023, engine fire indication", "Sunday Jun  4th 2023", "Incident" },
                    { new Guid("60bd1d2d-f285-427f-a909-526da04cda6e"), "Edelweiss A343 at Phuket on Mar 2nd 2023, dropped slat panel", "Saturday Mar  4th 2023", "Accident" },
                    { new Guid("614f90a8-9bad-4e97-ac7f-0e2a6e94396d"), "KLM B773 at Paramaribo on Mar 6th 2023, damaged a number of tyres on landing", "Monday Mar  6th 2023", "Incident" },
                    { new Guid("64484794-fde7-4914-aa07-079b0b65fa39"), "Easyjet Europe A320 at Milan on Dec 28th 2022, rejected takeoff due to cargo door warning", "Wednesday Jan  4th 2023", "Incident" },
                    { new Guid("648e6692-7152-4674-8136-7445bc89baf9"), "Lufthansa B748 at Buenos Aires on Apr 29th 2023, could not retract landing gear", "Sunday Apr 30th 2023", "Incident" },
                    { new Guid("65979de5-9dc1-4503-8ab6-db5ad6cf2354"), "Transat A332 near Nassau on Mar 4th 2023, overheating cabin floor and burning odour", "Wednesday Mar 15th 2023", "Incident" },
                    { new Guid("65b3b4d3-125f-4325-aa3e-239ded144a32"), "Oman B739 at Shiraz on May 15th 2023, foreign object on runway at landing", "Wednesday May 17th 2023", "Incident" },
                    { new Guid("65ba7625-993b-43db-800d-d56f9bcc6c29"), "Canada A333 at Madrid on Jul 13th 2022, TCAS RA on final approach", "Friday Feb 17th 2023", "Incident" },
                    { new Guid("686f1806-eac2-4da3-a1ef-74e8b056e55a"), "Malta Air B738 at Milan on May 27th 2023, nose tyre damage on departure", "Sunday May 28th 2023", "Incident" },
                    { new Guid("6a04aa74-1dd0-4884-a537-f0052042a8a4"), "Virgin Australia B738 at Coolangatta on Jan 24th 2023, long landing", "Thursday Apr 13th 2023", "Incident" },
                    { new Guid("6a42a294-abf6-4c93-b10a-383bc11d833b"), "TAP A20N at Bissau on Feb 25th 2023, bird strike", "Sunday Feb 26th 2023", "Incident" },
                    { new Guid("6b2671ec-8129-4c33-bf6a-a0918ad564dd"), "Hawaiian A332 near Honolulu on Dec 18th 2022, turbulence injures 42", "Saturday Jan 14th 2023", "Accident" },
                    { new Guid("6b553cf9-0076-44a5-8418-e998a8560d3b"), "Wideroe DH8D near Sandefjord on Mar 17th 2023, departed without being refueled", "Monday Mar 20th 2023", "Incident" },
                    { new Guid("6b5720b5-4c57-45d1-972c-69b455009ce2"), "Jetblue A320 at Jacksonvill on Feb 22nd 2023, engine failure", "Saturday Feb 25th 2023", "Incident" },
                    { new Guid("6ba3f5d5-d28c-48e3-8c8e-883b82ff0e27"), "Brussels A333 near Paris on May 22nd 2023, engine vibrations", "Monday May 22nd 2023", "Incident" },
                    { new Guid("6c222eaa-cf21-472e-b90c-dba298946cda"), "United B772 at Honolulu on Jan 23rd 2023, runway incursion", "Thursday Feb 16th 2023", "Incident" },
                    { new Guid("6c86ec85-ce09-40a3-8ee5-453645b05e75"), "Buddha AT72 at Kathmandu on Mar 18th 2023, unreliable airspeed", "Saturday Mar 18th 2023", "Incident" },
                    { new Guid("6cc491e1-ff71-4f4f-a4b6-f575370520fa"), "Canada B773 near Toronto on Apr 30th 2023, something glowing on wing", "Wednesday May 10th 2023", "Incident" },
                    { new Guid("6d223d5a-817e-41fa-bd83-f2c844096bbd"), "Scoot B789 near Adelaide on Apr 29th 2023, engine shut down in flight", "Monday May  1st 2023", "Incident" },
                    { new Guid("712a0cb8-f042-4867-8b3d-0647bafc6c88"), "Qatar B788 at Doha on Jan 10th 2023, steep descent after takeoff", "Wednesday Feb  8th 2023", "Incident" },
                    { new Guid("71c7bc2d-473b-47e4-a0bf-b03ffc696b08"), "Easyjet A319 near Manchester on May 19th 2023, burning odour on board", "Saturday May 20th 2023", "Incident" },
                    { new Guid("72cf902e-58f1-4d38-adaf-fd579b81b32e"), "LATAM Cargo at Frankfurt on Jun 20th 2023, stalled during go around, overflew parallel runway and stalled again", "Sunday Jun 25th 2023", "Incident" },
                    { new Guid("74703a73-a224-4698-942c-4926af8ef9d2"), "Wideroe DH8A at Tromso on Jun 2nd 2023, engine shut down in flight", "Saturday Jun  3rd 2023", "Incident" },
                    { new Guid("769124cf-47b3-4f0d-944e-2b2d78e72c55"), "Smartwings Poland B738 at Warsaw and Prague on Jan 9th 2023, right hand airspeed and altitude indications faulty", "Tuesday Jan 17th 2023", "Incident" },
                    { new Guid("7a08a874-fd8c-416c-97af-5a9c7bef9f27"), "Ryanair B738 at Dublin on Apr 9th 2023, temporary runway excursion and nose gear damage on landing", "Sunday Apr  9th 2023", "Accident" },
                    { new Guid("7a1bca9d-a161-4667-a573-8c2e10e342b8"), "Vietjet A21N near Laoag on Jun 28th 2023, engine vibration indications", "Wednesday Jun 28th 2023", "Incident" },
                    { new Guid("7ee622a1-dfe4-4c97-9775-f03e2ad1490e"), "PIA A320 at Karachi on May 24th 2023, bird strike", "Wednesday May 24th 2023", "Incident" },
                    { new Guid("7f4b5cba-9304-474e-92df-372d4e29f38a"), "United A320 near Kansas City on Jun 11th 2023, fumes in cockpit", "Monday Jun 12th 2023", "Incident" },
                    { new Guid("80a20125-bfad-40bf-a963-589bc111bd07"), "LOT B788 at Warsaw on Mar 12th 2023, could not retract nose gear", "Sunday Mar 12th 2023", "Incident" },
                    { new Guid("81724e59-8760-45e6-9dd8-8acd8aae11c9"), "Easyjet A320 at London on May 28th 2023, engine failure", "Monday May 29th 2023", "Incident" },
                    { new Guid("8272c05a-d558-45ae-8cfe-9a5c48631f25"), "Aeromexico E190 near Oaxaca on May 3rd 2023, loss of cabin pressure", "Thursday May  4th 2023", "Incident" },
                    { new Guid("843c98f5-2780-447f-ba1b-e35440c85cb0"), "Ethiopian B772 at Shanghai on Jul 22nd 2020, aircraft burned down on apron", "Monday Jun  5th 2023", "Accident" },
                    { new Guid("846e5d83-8d11-4a1d-9832-cbaaeae0748d"), "Spicejet B738 at Delhi on Apr 18th 2023, cargo smoke indication", "Tuesday Apr 18th 2023", "Incident" },
                    { new Guid("85b0541c-4558-497c-bf4e-5283eedcf2c0"), "Pel SF34 near Cobar on Apr 23rd 2023, fire on board", "Monday Apr 24th 2023", "Accident" },
                    { new Guid("8666a88b-cce5-4682-a680-2ded0dc4c194"), "Swiss A320 at Zurich on Jan 6th 2023, smoke in cockpit and cabin", "Friday Jan  6th 2023", "Incident" },
                    { new Guid("86e2026f-5c38-4481-ab92-408883f2f1ba"), "American B38M at Miami on Jan 20th 2023, failure of stabilizer trim", "Saturday Jan 21st 2023", "Incident" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("873d0b57-9b51-4210-be35-271cd3aa8851"), "Qantas A332 near Adelaide on Feb 4th 2021, loss of cabin pressure", "Tuesday Mar 21st 2023", "Incident" },
                    { new Guid("8b73e1b6-3580-4e24-9d58-d759ded9b1c3"), "Westjet Encore DH8D at Calgary on May 31st 2023, engine fire", "Thursday Jun  1st 2023", "Incident" },
                    { new Guid("8cf69831-527d-407b-b4c2-74828e912cea"), "Ariana A313 at Jeddah on Feb 24th 2023, rejected takeoff due to sliding window", "Thursday Apr  6th 2023", "Incident" },
                    { new Guid("8feca9d0-39c9-4a6b-8f15-4dde8ddb7dbb"), "Fedex MD11 at Toronto on Jun 21st 2023, thrust reverser deployed in flight", "Monday Jun 26th 2023", "Incident" },
                    { new Guid("90b28ca4-8ce7-477e-b9e9-dc0210f4bba5"), "China Express CRJ9 near Guiyang on Jan 6th 2023, loss of communication", "Monday Jan  9th 2023", "Incident" },
                    { new Guid("91a9751b-7ad5-4ced-b4d3-a21e24b3ea16"), "American B738 at Merida on Apr 1st 2023, flaps problems on approach", "Monday Apr  3rd 2023", "Incident" },
                    { new Guid("91b3cf39-e873-43c5-ae4e-b4edaaaece9f"), "Pionair B462 at Rockhampton on Jan 5th 2023, descended below safe height", "Thursday Jan 12th 2023", "Incident" },
                    { new Guid("9346b8d0-ee01-4a96-9bb5-d490b7ffc746"), "Chair A320 at Zurich on Mar 1st 2023, cargo door open indication", "Wednesday Mar  1st 2023", "Incident" },
                    { new Guid("93985f7f-d401-4500-b954-aaa7c77497de"), "India Express B738 at Kochi on Jan 29th 2023, hydraulic failure", "Monday Jan 30th 2023", "Incident" },
                    { new Guid("9550ac8f-1af6-4de4-9249-09a808a5503b"), "Transavia B738 at Rotterdam on May 4th 2023, bird strike", "Saturday May  6th 2023", "Incident" },
                    { new Guid("976b3fd5-3759-45f8-8739-4aa731fbdfc6"), "Sunstate DH8D at Brisbane on Feb 1st 2023, turbulence injures two people", "Thursday Feb  2nd 2023", "Accident" },
                    { new Guid("9bf02cc3-e312-4d29-a7f9-52e83533df95"), "Yeti AT72 at Pokhara on Jan 15th 2023, lost height on final approach, both propellers went into feather", "Wednesday Feb 15th 2023", "Crash" },
                    { new Guid("9d0cd875-071e-4b78-b9ee-688e42391446"), "SAS A320 at Haugesund on Jan 17th 2023, could not retract the landing gear", "Tuesday Jan 17th 2023", "Incident" },
                    { new Guid("9ec36ae4-0970-4b26-9bd3-cdc4136a740a"), "British Airways A320 near Glasgow on Apr 10th 2023, fuel transfer problem", "Monday Apr 10th 2023", "Incident" },
                    { new Guid("a5ba8552-740d-4436-a072-16266102817e"), "Lufthansa B744 enroute on Apr 15th 2023, hydraulic problem", "Sunday Apr 16th 2023", "Incident" },
                    { new Guid("a5e6cf3a-ae5c-4de8-90fb-430473f07253"), "Link SF34 at Canberra on Nov 10th 2022, propeller strap penetrates cabin in flight", "Wednesday May 17th 2023", "Accident" },
                    { new Guid("aaa3b066-a04c-4322-87f5-d5da52ec929f"), "Porter DH8D at Boston on Mar 30th 2023, engine shut down in flight", "Thursday Apr 20th 2023", "Incident" },
                    { new Guid("ad5604da-e62f-4830-9af7-b7febe532ed2"), "Central Mountain DH8A at Ft. McMurray on Dec 21st 2022, nose gear stuck in half retracted/extended position", "Monday Jan  2nd 2023", "Incident" },
                    { new Guid("b20c32c2-094f-4c09-b112-88c707353a9b"), "Edelweiss A320 at Zurich on Aug 17th 2021, rejected takeoff", "Wednesday Jan 25th 2023", "Incident" },
                    { new Guid("b36be1a2-ce03-483a-a9d0-e88a498e2cde"), "Lufthansa A320 at Munich on Jan 17th 2023, slat problem", "Wednesday Jan 18th 2023", "Incident" },
                    { new Guid("b46b04eb-d0c6-4611-bdf9-b6123d022adc"), "THY B739 at Kayseri on Apr 7th 2023, bird strike", "Saturday Apr  8th 2023", "Incident" },
                    { new Guid("b7d0289f-32c6-4e8d-ac94-8b9fb4d26c9d"), "Trigana B735 at Yahukimo on Mar 11th 2023, aircraft being shot at", "Saturday Mar 11th 2023", "Accident" },
                    { new Guid("b7d93eea-6acd-4eac-ad4f-b3b258f618fe"), "India Express B738 at Trivandrum on Jan 23rd 2023, FMS trouble", "Monday Jan 23rd 2023", "Incident" },
                    { new Guid("b8619a82-bb4d-40ce-a734-61d0d2c1efc3"), "TAG SF34 at Flores on Apr 16th 2023, gear problem on approach, runway excursion", "Monday Apr 17th 2023", "Accident" },
                    { new Guid("b9fc4254-a4c8-44b1-90bd-fd557264e694"), "Swiss A320 at Zurich on Feb 14th 2023, took off with vehicle on runway", "Saturday Apr  1st 2023", "Incident" },
                    { new Guid("ba18c568-cd73-4055-96b0-694dea28574c"), "United B739 at Fort Myers on Apr 11th 2019, galley oven refused to slow down on landing", "Tuesday Jan 24th 2023", "Report" },
                    { new Guid("bbd7e8e2-fdd7-40e9-90d4-f749dcf53752"), "Challenge B744 at Atlanta on Feb 20th 2023, flaps problems on departure", "Tuesday Feb 21st 2023", "Incident" },
                    { new Guid("bbf11303-dde2-4a3d-96d9-e9fd5fb7c4da"), "Qantas B738 near Nadi on Jan 22nd 2023, fumes in cabin", "Sunday Jan 22nd 2023", "Incident" },
                    { new Guid("bce193da-3e68-4747-85f3-ef94d6b3449f"), "ICE B752 enroute on Feb 27th 2023, engine issue", "Tuesday Feb 28th 2023", "Incident" },
                    { new Guid("c3100e0e-21dc-4e33-9cb7-0bb3a0361e4b"), "LOT B788 at Warsaw on Feb 4th 2023, backup ADI failed", "Monday Feb  6th 2023", "Incident" },
                    { new Guid("c52c7c3a-9f71-480f-ad5d-3f8214a87aa6"), "Eastern Airways AT72 near Exeter on Jan 7th 2023, cracked windshield", "Sunday Jan  8th 2023", "Incident" },
                    { new Guid("c7e2376f-8a30-4d8e-afc4-35812213458a"), "El Al B788 at Tel Aviv on Apr 22nd 2023, engine problem", "Sunday Apr 23rd 2023", "Incident" },
                    { new Guid("c98dcb81-0328-4c9b-b40d-b2426422ab40"), "Hawaiian A332 at San Diego on Jan 10th 2023, hydraulic failure", "Wednesday Jan 11th 2023", "Incident" },
                    { new Guid("ca032e5e-d8fe-428c-8fe5-e88fd283aa49"), "Lufthansa A333 near Washington on Mar 1st 2023, turbulence causes injuries", "Thursday Mar  2nd 2023", "Accident" },
                    { new Guid("cbd4830b-8d56-4917-8018-ad5c2c7f4316"), "Swiss RJ1H enroute on Sep 3rd 2016, fumes in cockpit and cabin", "Tuesday Mar 14th 2023", "Incident" },
                    { new Guid("cc77ef15-898a-4d00-b2de-cd6746ee2983"), "KLM B772 near Dubai on May 26th 2023, engine shut down in flight", "Tuesday May 30th 2023", "Incident" },
                    { new Guid("cfdbc919-1929-45da-84cd-ae65f82a84d0"), "Baltic BCS3 at Brussels on Apr 19th 2023, started final descent too early", "Saturday May 13th 2023", "Incident" },
                    { new Guid("d0ecb141-6ba1-46d0-b4ba-d98beacc89f0"), "TAP A320 at Copenhagen on Apr 8th 2022, reverser opened on TOGA, overflew buildings at very low height on go around", "Wednesday Jun 14th 2023", "Incident" },
                    { new Guid("d2e25924-132d-4e96-86fe-5cfaa6982f32"), "CAA A320 at Mbuji Mayi on Jan 29th 2023, dropped part of elevator on departure", "Tuesday Feb  7th 2023", "Accident" },
                    { new Guid("d52e2ae7-ee5a-4eb0-af40-20463b9dc0ab"), "Argentina B738 at Buenos Aires on Jan 2nd 2023, bird strike", "Thursday Jan  5th 2023", "Incident" },
                    { new Guid("d530553a-138f-4668-ae8e-d36abba6b854"), "Lufthansa CRJ9 at Frankfurt on Jun 15th 2023, smell of smoke in cabin", "Thursday Jun 15th 2023", "Incident" },
                    { new Guid("d6640270-1004-479d-a606-afedaa2059da"), "Delta A321 at New Orleans on Mar 31st 2023, rejected takeoff on ATC instruction", "Sunday Apr  2nd 2023", "Incident" }
                });

            migrationBuilder.InsertData(
                table: "HeraldPosts",
                columns: new[] { "Id", "Details", "Occurrence", "TypeOccurence" },
                values: new object[,]
                {
                    { new Guid("d9ee07e1-578d-4961-9417-1030ce1a6315"), "Qantas B738 over Tasman Sea on Jan 18th 2023, engine shut down in flight", "Thursday Jan 19th 2023", "Incident" },
                    { new Guid("da595e21-9284-49bd-b9b0-4517f0ba967f"), "Lufthansa A21N at Frankfurt on Mar 31st 2023, lightning strike", "Saturday Apr  1st 2023", "Incident" },
                    { new Guid("dbd6cf6c-8cf2-453e-97a0-1395da97d41e"), "Flynas A20N at Dubai on Feb 9th 2023, engine failure", "Thursday Feb  9th 2023", "Incident" },
                    { new Guid("dce29d64-40f1-4c87-b595-3673ff3942b7"), "ANZ B773 at Auckland on Jan 27th 2023, runway excursion on landing", "Sunday Jan 29th 2023", "Incident" },
                    { new Guid("de439c05-6b16-4def-b798-adc6b72b4013"), "Argentinas B738 near Posadas on Jun 19th 2023, burning odour on board", "Tuesday Jun 20th 2023", "Incident" },
                    { new Guid("e0ff402d-eb99-4c30-8529-cdcba070232f"), "Sun Country B738 at Las Vegas on Feb 4th 2022, gear malfunction on departure", "Wednesday Mar 22nd 2023", "Accident" },
                    { new Guid("e32ea08b-cfc9-4e28-8cd1-0005dfc52b31"), "Fedex A306 near Indianapolis on May 7th 2023, hydraulic problems", "Monday May  8th 2023", "Incident" },
                    { new Guid("e412404e-5c1a-47b7-99e7-f2400719265b"), "Qantas B738 at Melbourne on Jan 20th 2023, engine problem", "Friday Jan 20th 2023", "Incident" },
                    { new Guid("e4e4d68d-7e8e-4122-8339-888e4d16550b"), "Virgin Australia B738 at Sydney on Oct 19th 2022, verbal slip in clearance", "Tuesday Jun  6th 2023", "Report" },
                    { new Guid("e7022602-1fe1-4f63-9249-19ffa1cb6eb5"), "Condor A339 near Mauritius on Mar 2nd 2023, turbulence injures 20", "Wednesday Jun 21st 2023", "Accident" },
                    { new Guid("e70c83ca-01da-4c8d-b5bc-e367f011c895"), "THY B739 at Kayseri on Jan 30th 2023, burst tyre on landing", "Tuesday Jan 31st 2023", "Incident" },
                    { new Guid("e9165122-a7ba-4c4f-aeeb-00111195eac3"), "Ibex CRJ7 near Fukuoka on Apr 18th 2022, loss of left and right airspeed indications", "Thursday Mar 30th 2023", "Incident" },
                    { new Guid("e97d3545-042f-4ac3-bcf8-e0beb7c6639d"), "Nolinor B738 at Toronto on Apr 15th 2023, flaps failure", "Tuesday May  2nd 2023", "Incident" },
                    { new Guid("eaecdd66-18ce-4332-8aac-86ce19555705"), "United A319 at Miami on Mar 6th 2023, engine compressor stall", "Tuesday Mar  7th 2023", "Incident" },
                    { new Guid("eb5ab929-9853-4d3c-b92a-f9136ebe2c24"), "Delta B738 at Burlington on Jun 12th 2023, engine failure", "Thursday Jun 15th 2023", "Incident" },
                    { new Guid("ec76f2eb-51b9-4d94-b5cc-0fb732fc8f47"), "Key Lime J328 at Phoenix on Feb 16th 2023, engine rolled back", "Monday Feb 20th 2023", "Incident" },
                    { new Guid("ec8cad63-144f-4d36-8cda-c43ef10d3fa3"), "SAS A20N at Tromso on Feb 12th 2023, rejected takeoff due to difficulties with directional control", "Monday Feb 13th 2023", "Incident" },
                    { new Guid("f4c64af0-636b-4466-b653-a614106d0ed4"), "Swiss BCS3 at Zurich on Jan 9th 2023, lightning strike", "Tuesday Jan 10th 2023", "Incident" },
                    { new Guid("f63ea4b8-417a-4bf6-9f81-b06637684375"), "Flydubai B738 at Kathmandu on Apr 24th 2023, bird strike on departure", "Tuesday Apr 25th 2023", "Incident" },
                    { new Guid("f6519bfe-7ffd-44bc-9e65-d1c7c516524a"), "Batik A333 at Madinah on Jun 12th 2023, hydraulic leak", "Friday Jun 23rd 2023", "Incident" },
                    { new Guid("f88aa06f-4e69-475e-ba66-c135f510bba3"), "Jetblue A320 near New York on May 22nd 2023, loss of cabin pressure", "Tuesday May 23rd 2023", "Incident" },
                    { new Guid("f92f8360-88de-4012-8edf-0a65944b48fb"), "Ryanair B738 at Eindhoven on Mar 5th 2023, tyre damage on landing", "Sunday Mar  5th 2023", "Incident" },
                    { new Guid("f92fa5f6-8874-4193-b2b4-3a343969fa88"), "Garuda B738 at Manado on May 31st 2023, engine problems", "Wednesday May 31st 2023", "Incident" },
                    { new Guid("fc46ddff-430a-46cb-ba78-1279a817dacb"), "Asiana A321 at Daegu on May 26th 2023, emergency exit opened in flight", "Friday May 26th 2023", "Accident" },
                    { new Guid("fd1711a2-2cad-4127-9428-06ec6498599a"), "Precision AT42 at Bukoba on Nov 6th 2022, touched down short of  runway and ended up in Lake Victoria", "Friday Mar 17th 2023", "Accident" },
                    { new Guid("ff1fa196-cc1b-4c56-a578-343b32ce7293"), "Qantas E190 at Darwin on Feb 10th 2023, could not fully retract gear", "Saturday Feb 11th 2023", "Incident" }
                });

            migrationBuilder.InsertData(
                table: "Runways",
                columns: new[] { "Id", "Length", "RunwayDesignatorOne", "RunwayDesignatorTwo", "SurfaceType", "Width" },
                values: new object[,]
                {
                    { "00361045-5b8e-4699-adf6-9545aa4a8dfc", 3400, "13L", "31R", "Sand", 480 },
                    { "0265bc77-964b-456e-9c06-262c373085b9", 4450, "03L", "21R", "Gravel", 150 },
                    { "04127b5c-6c26-4de1-a416-d877d1a8dffa", 4250, "20", "02", "Gravel", 120 },
                    { "051c2486-9432-4fcf-b847-7ef0ce43a029", 4000, "28L", "10R", "Asphalt", 90 },
                    { "0b283f7a-21ac-402f-abcb-00a5807440ee", 4200, "22", "04", "Sand", 270 },
                    { "1134d51e-713f-492d-99cf-67a658297d2c", 2750, "07", "25", "Asphalt", 60 },
                    { "15398653-8f59-48b8-ac12-007b276571bd", 3300, "08L", "26R", "Sand", 540 },
                    { "170788df-5f5b-4414-b9ed-e4e085c62b9a", 1400, "18", "36", "Sand", 270 },
                    { "1c6c450a-c0d7-4563-8780-fa88c7d4fca8", 3700, "27L", "09R", "Sand", 390 },
                    { "1d00d7b6-515d-4b1e-8fa8-23898fa4b7a7", 3450, "29", "11", "Sand", 150 },
                    { "1feb7474-19e3-4854-9e4e-434cfb53de3f", 1900, "20R", "02L", "Concrete", 360 },
                    { "21a9584a-6ac1-4202-ab9b-017c47d5e2af", 4900, "34L", "16R", "Sand", 450 },
                    { "2228b111-a4b2-43b4-98ab-cb2a678c146c", 4550, "25L", "07R", "Sand", 210 },
                    { "24600f77-8b11-4e26-8923-0565dbf94089", 3100, "25", "07", "Concrete", 300 },
                    { "26462bcf-19a4-44e3-a40e-8eb824345b6c", 4900, "29L", "11R", "Sand", 90 },
                    { "2ef12ccc-1b31-426d-b6ce-38ee51268b15", 2750, "34", "16", "Gravel", 480 }
                });

            migrationBuilder.InsertData(
                table: "Runways",
                columns: new[] { "Id", "Length", "RunwayDesignatorOne", "RunwayDesignatorTwo", "SurfaceType", "Width" },
                values: new object[,]
                {
                    { "2f5b35c3-75cc-4a35-9d08-5253fe2ac711", 1150, "14R", "32L", "Gravel", 330 },
                    { "30229d07-953b-4b1a-9d8d-fd9bbdfc755c", 4050, "19", "01", "Grass", 240 },
                    { "3043d715-fd9a-40d0-abf3-9fa8af697a7c", 3950, "30L", "12R", "Asphalt", 570 },
                    { "3319415a-4b3d-40b5-a106-00f9844dde14", 2450, "20L", "02R", "Asphalt", 150 },
                    { "34524645-a1a6-4d0c-be70-8efcf98332fd", 1950, "14L", "32R", "Grass", 60 },
                    { "36e319f8-2832-48c2-af12-3e1f355c6506", 3950, "10L", "28R", "Sand", 420 },
                    { "373eec25-819d-4aa0-a73b-3e6ff240a043", 3550, "28R", "10L", "Sand", 210 },
                    { "3a07d9ad-2769-407d-acf9-64c59ab44b2f", 3650, "21", "03", "Asphalt", 450 },
                    { "3d9e30c8-44b7-4589-a65a-42937b29282a", 3550, "30R", "12L", "Dirt", 120 },
                    { "3e3226c3-a564-480b-a223-83d0c2c9f0fe", 2050, "26R", "08L", "Concrete", 300 },
                    { "481774b6-ac95-41ed-b969-6f9e39775e2b", 4400, "14", "32", "Sand", 540 },
                    { "49a98c7e-41d9-4fe5-aa57-ff987582e83e", 3850, "02R", "20L", "Grass", 210 },
                    { "4d143142-e617-4d1f-9cc0-7cb6a23d56d6", 4750, "01", "19", "Asphalt", 300 },
                    { "4eba5a8d-6dcb-49e1-8626-067cce22681d", 4000, "10", "28", "Grass", 120 },
                    { "51ec4127-b26b-49d3-863e-fae6d7b113db", 4550, "11R", "29L", "Concrete", 570 },
                    { "528602b0-b40b-45c7-953c-dd80f8a8cbc1", 1700, "05R", "23L", "Gravel", 360 },
                    { "53556fdb-3324-4174-a932-659df194cd8a", 2800, "04L", "22R", "Asphalt", 120 },
                    { "54a12528-2947-49d2-bf2f-87dc2058b24e", 2400, "17L", "35R", "Dirt", 240 },
                    { "5699c6a8-7113-45bf-a65d-e74f8858b3b5", 4550, "16", "34", "Dirt", 390 },
                    { "58322036-66d9-469a-bf8e-1b8ebeaf6cf7", 3450, "06", "24", "Gravel", 450 },
                    { "5943bea6-d792-4cee-98e3-92c2c8808c01", 2250, "19R", "01L", "Asphalt", 510 },
                    { "5969c7c5-73c5-4d36-ba70-7a513b3bc9ea", 4350, "18L", "36R", "Asphalt", 210 },
                    { "599d3d4f-e6e2-4f4c-9cfa-2f354464517c", 3450, "12", "30", "Asphalt", 480 },
                    { "5d0aada8-41d9-4a6f-9d57-c96604ea22f2", 3100, "03", "21", "Asphalt", 480 },
                    { "5daef6bc-fd31-4a64-942f-34a42ade501d", 4950, "27", "09", "Asphalt", 450 },
                    { "60f48de6-3eab-463a-a296-fccba6fb9ae4", 2550, "04R", "22L", "Concrete", 90 },
                    { "643138ab-ff7c-4272-82c2-d677254bb31f", 1100, "23L", "05R", "Concrete", 510 },
                    { "646f3bbe-29c6-4b6a-8668-0ed1a6b57a00", 3300, "31R", "13L", "Gravel", 420 },
                    { "647cf498-2ff0-4ecc-bbbc-5ba2dee39c86", 2450, "07L", "25R", "Grass", 510 },
                    { "658c3bb4-d0f5-40b2-84e0-d3196654038f", 2900, "17", "35", "Gravel", 60 },
                    { "6d01b1a9-8c6a-4304-83f4-cd130348e6bc", 1150, "31L", "13R", "Grass", 510 },
                    { "6d4e2d4e-b2d5-4f86-923b-f953c5beefbc", 2800, "33R", "15L", "Gravel", 120 },
                    { "6d83383b-4aac-430d-9562-b7b0ef9a0a81", 2550, "15L", "33R", "Asphalt", 330 },
                    { "6e17704d-f1d5-4250-b69c-4fb8867b31ac", 1850, "35L", "17R", "Concrete", 300 },
                    { "72d0faaa-4ee6-4329-af89-6567610811e9", 4700, "32R", "14L", "Gravel", 60 },
                    { "73cb7e24-98c7-4ffd-8fcf-c9e34dca9800", 1600, "11", "29", "Concrete", 150 },
                    { "766a85b1-5ce7-4bbf-ab86-ec2abccf9d39", 3150, "35", "17", "Grass", 270 },
                    { "77083c65-606b-4e76-9642-3ef25a1e5fdf", 3350, "26L", "08R", "Concrete", 390 },
                    { "7aa57a7a-8ee4-4488-b862-9352a9d4d7e5", 2450, "22L", "04R", "Sand", 210 },
                    { "7b8779f4-18f0-4248-a1b8-ef330f4de963", 2950, "29R", "11L", "Asphalt", 120 },
                    { "7bfd8bcf-30d7-45c8-ae28-0d9c5745cc6c", 3950, "28", "10", "Concrete", 150 },
                    { "7dba455f-4d74-4cf4-ad3a-4debf73312e5", 2450, "02", "20", "Grass", 480 }
                });

            migrationBuilder.InsertData(
                table: "Runways",
                columns: new[] { "Id", "Length", "RunwayDesignatorOne", "RunwayDesignatorTwo", "SurfaceType", "Width" },
                values: new object[,]
                {
                    { "7dffc988-f699-4318-8a1c-3a9ee475e3aa", 2700, "09", "27", "Gravel", 330 },
                    { "7efb0ed3-aa70-43bc-80a6-e19ea6098992", 4600, "13", "31", "Dirt", 180 },
                    { "850e1cc0-1ae8-4be2-b7c4-2d7c93fd743d", 2800, "23", "05", "Asphalt", 180 },
                    { "886e3b2f-bd80-4eed-9225-4f0aba1cd8e1", 3050, "08R", "26L", "Sand", 150 },
                    { "89d85c74-60d7-4284-8df0-ef2d1cb96ed6", 4700, "23R", "05L", "Asphalt", 420 },
                    { "8d033d42-d08f-4067-bdb9-a08a5d7a9a41", 1000, "04", "22", "Gravel", 60 },
                    { "8f47b7b2-4836-473d-b664-0db6844b78e0", 4150, "26", "08", "Sand", 480 },
                    { "91b966c5-ba9a-4439-a018-3129101f4467", 4750, "07R", "25L", "Dirt", 420 },
                    { "93d99dd4-fbb0-436e-a7b6-53ea0c2079d9", 3750, "33", "15", "Asphalt", 540 },
                    { "94cced5d-85e6-4343-a0c3-73669862be99", 2600, "36R", "18L", "Grass", 420 },
                    { "96323253-51e6-4c3f-810c-802669279fb6", 3750, "30", "12", "Dirt", 300 },
                    { "98dc3c93-68dd-477b-b5ea-a63fe53ea6fe", 1000, "21R", "03L", "Asphalt", 540 },
                    { "9fd12300-8366-4457-9589-c014049413e9", 1650, "10R", "28L", "Grass", 510 },
                    { "a1568348-e0b1-462b-9539-d30964fa6519", 1850, "06L", "24R", "Dirt", 210 },
                    { "a21ab9eb-248d-4aac-8bce-2f188002aa0e", 2950, "32", "14", "Dirt", 570 },
                    { "a3ecea43-3a34-4d2b-8ad2-351bda97bc38", 3750, "01R", "19L", "Gravel", 180 },
                    { "a5ba4c60-2873-4f7b-9f13-e2cf663703e3", 1500, "33L", "15R", "Concrete", 150 },
                    { "aacb7e85-a7ef-415a-8c3b-ae966984e934", 4950, "11L", "29R", "Concrete", 450 },
                    { "ac264515-1f1b-4463-ae07-b4617a544780", 1250, "36L", "18R", "Grass", 540 },
                    { "acf1f846-19dc-4968-a0b1-a23f74fe2127", 3100, "13R", "31L", "Gravel", 540 },
                    { "ae0c23ce-a818-4d14-be6a-039a0dbfea43", 2050, "19L", "01R", "Asphalt", 210 },
                    { "b055ac85-c8df-4937-ae92-fb6e5fc2ba10", 4550, "15", "33", "Dirt", 540 },
                    { "b143dd16-45a6-441a-977f-49af6229306f", 4700, "12R", "30L", "Sand", 240 },
                    { "b40044d1-6055-4931-97dd-eaedb6cfa73a", 3350, "32L", "14R", "Concrete", 450 },
                    { "b5234b3b-4b5a-4b98-81d2-fae73b6d5550", 4550, "27R", "09L", "Dirt", 420 },
                    { "b6ed060a-e449-460b-a668-d8084e7021ba", 1900, "18R", "36L", "Sand", 510 },
                    { "b9c6b3fc-1500-4f25-b14b-e8a79c9710ea", 1150, "15R", "33L", "Concrete", 180 },
                    { "bbe7b357-8319-47fd-97b6-efd188b49a7f", 3250, "09R", "27L", "Asphalt", 240 },
                    { "bc851907-b0f9-4f10-a47a-8a148bce7839", 1200, "01L", "19R", "Grass", 390 },
                    { "bd0b9ab5-51e6-4609-a5e6-f1e70f760088", 1150, "31", "13", "Asphalt", 270 },
                    { "c3601e3b-8b3a-414e-8cd6-3b98b8527a62", 4400, "25R", "07L", "Sand", 570 },
                    { "c4390809-b967-4d58-a29e-46089c6fc752", 3250, "05", "23", "Concrete", 480 },
                    { "c4c4ba59-7b1d-44bf-8eb6-f27903c07c04", 2350, "02L", "20R", "Dirt", 270 },
                    { "ca58aeec-6bdc-47de-875c-81ec0c74a800", 2850, "05L", "23R", "Asphalt", 300 },
                    { "cc0cd5f4-19ea-4976-bcb6-6860ff35c00b", 3600, "17R", "35L", "Dirt", 450 },
                    { "ced841f3-0c1f-4911-a640-8e8d1fc20428", 4050, "09L", "27R", "Gravel", 240 },
                    { "d1f80e78-b1e9-4f2b-bfc0-9e19fbf11ada", 2450, "08", "26", "Sand", 150 },
                    { "d2fe1317-7746-4eec-a2f7-6804c02f12f8", 2600, "21L", "03R", "Grass", 210 },
                    { "d96ae4ce-2453-41a1-a29f-f958a6531149", 2700, "06R", "24L", "Asphalt", 180 },
                    { "d973d458-024c-460c-b980-488e748bf392", 3950, "16L", "34R", "Concrete", 450 },
                    { "d977c3da-2977-46b0-98d7-a208b642b7ab", 3300, "35R", "17L", "Gravel", 120 },
                    { "e004a4a8-e236-466d-b5e0-921a520063b2", 1800, "12L", "30R", "Sand", 120 }
                });

            migrationBuilder.InsertData(
                table: "Runways",
                columns: new[] { "Id", "Length", "RunwayDesignatorOne", "RunwayDesignatorTwo", "SurfaceType", "Width" },
                values: new object[,]
                {
                    { "ef5d04b3-10a1-4148-86eb-59dee4bc1e9d", 2800, "16R", "34L", "Sand", 150 },
                    { "f2f17a75-c1e3-4e29-a0db-734322082266", 4950, "22R", "04L", "Concrete", 570 },
                    { "f4a6ae19-a116-481f-90c0-7196d5735279", 4200, "24L", "06R", "Asphalt", 510 },
                    { "f4c18de8-e4d8-4509-9141-fc0a9871f87a", 3450, "24", "06", "Sand", 90 },
                    { "f51a5e83-df78-471f-9469-3faeba6c308f", 2750, "36", "18", "Sand", 420 },
                    { "f684a508-1177-4868-8858-651fe9160f75", 2450, "03R", "21L", "Grass", 390 },
                    { "fba182a1-e1f3-49ac-836c-36c3c02c6371", 4150, "24R", "06L", "Gravel", 330 },
                    { "fed04b65-2777-4d3f-93c6-3593a87b9fe4", 1950, "34R", "16L", "Concrete", 180 }
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
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("03b6174f-0d3e-4d06-b9e8-0b9e8c8407d1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("03dd4faf-2d19-4bf4-b651-39f56b0f7538"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("04085577-8c4e-4d03-8583-0138a687bc53"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("07413df7-aa3e-420d-b714-bf1f696b588e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("080a36c7-7a91-4be3-a978-d1daa2ae0bb6"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0844e747-2837-4376-96e2-1106b65c3bd2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0895c54e-d438-469c-b4c1-9c888448f906"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("09857b40-4d75-467e-92c1-da66ac27df37"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0c4057a5-81e1-4e3e-a723-2a373c68bea5"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0d1b6cb7-1412-4a1c-af19-60daf8aba4df"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0dfb6746-8487-4b6b-a797-e4f25a3bc7a1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("0f14ef08-ef61-436a-b332-17be61fc3be2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("10a2ae53-4976-4417-81bc-d1a17478b9de"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("10ea6608-987c-492c-9332-4e9b91412a99"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("125a82e2-081e-41fc-a311-0aa9cf43e96f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("134ecca9-77c9-4d77-b253-17dc695c94e1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1386e865-6927-4b2a-85ee-4454775c9777"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("16ce9df8-b8b3-47a2-bdd5-931c69c1f9bc"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("172ce39d-d67c-4ffa-b02b-c9c4d8b51123"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("17344fe1-09d5-4752-be88-0f9dbd87662a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("174d9457-41dc-4afd-935a-c76ad74b2f18"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("1786f2ef-e3e6-4f55-ae35-014a8c03ee91"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("17a32d45-881b-446c-aee6-c5524fdc84dc"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("17ed9c16-f586-420c-9790-a99bb6755797"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("207618ad-6fee-47f0-9fef-b9250c8d25b2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("24398c28-06f4-4555-97f9-698501e9489a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("24a92392-e52c-4f90-9899-3ea8b9f8e358"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("26a914de-0202-495e-b093-869868fbdb5d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("286877e5-b6f3-4484-8936-d933e5dc0f2e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2a721de5-e0eb-46c2-816b-1eb649da7bee"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2b554fd2-1d3f-46cf-839f-ae552f5080c0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2da6c8af-abb4-4b59-bc78-04cefd0f4bb1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("2ef5c91f-3087-48da-8bfc-509f24bef2a4"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3062c395-588d-49b4-8ebd-09b074cb6e39"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("322cdb07-0c2d-4ae1-8d23-bb9604d025e1"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3348ede5-1a2c-48da-8f5d-49f0ba0b067d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("34ec71f9-12dd-447f-b04e-8cfa949f21d0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3536da5a-5ae7-49d8-b6d4-09107b3e9ce7"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3687c432-526d-4508-8512-b66f649b80f5"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("373851f2-ae94-4a4f-82e7-ba214d2277c2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("37ac503c-f49b-4d09-955c-aca7db551205"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("39671437-2415-4e49-8d34-2cf04e7a6767"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3aa2b7a1-27fa-42f7-872a-2db39a91ba07"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3ce3a81f-9f08-48fd-81fb-b5a02f33efb9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3d483d4a-36ae-476e-8c10-cb16e4706db7"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3d812850-4cfd-42a8-9533-433f0115b2bf"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("3dcf1a65-b680-43c6-9913-85e8c6ffa8c2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("402e1a8e-cbd8-45a6-ae2d-6160a10c5ed5"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("409efa08-5558-4050-beae-31131509c635"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("4197ea45-7897-4e04-b22d-4051bf250cd3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("42c2a47b-3942-457b-a670-2063ecd0f152"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("44c64a08-edef-410a-a62f-0243d51f5fdb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("45143a8b-a1ea-409f-8add-44202603fa39"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("469eec68-5c3d-42a6-a442-8b473a87f700"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("48078e47-541a-4c5c-9df3-f0f819e639f9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("50f09d72-1754-488e-9083-d5afbe541d96"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("52fd28e6-c0b0-4e08-8be8-1361a93f6920"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("549e58be-16d2-4894-95b7-42bb0f704263"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("54fb2e0b-dae1-4407-9731-dde097678781"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("550f66f9-f8be-4913-83c6-fb1ec3eaad03"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("561b9301-9ec4-4f10-bf43-f4d828ef681f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5795a442-a9fd-4acd-a599-cbc26a56fb03"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5884fd75-09fa-4e2b-9af6-ee9fbf97fed9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5b3a48a1-2dae-4d4e-9b27-e88963e9f702"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5c9e3735-e61b-46da-b139-f845c41a7c5f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5d5c40b5-0f63-45c4-b9a1-a0766a9aec9c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5d78320f-0a61-4c3d-9ea1-0383d9ee77c0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5e66a241-0455-4e0b-8d2a-065bebe93335"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5e8be9b0-5f7a-44b6-8bf5-fb0dd7786822"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5e943734-d5d4-4692-b1aa-abeed7bcf0ed"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("5fa191f8-52ea-4ffe-b0fd-8a56a41a548f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6055436f-f224-4a74-bafc-bfef85274bfb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("605b2055-e572-4ecc-a804-7a51c6639454"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("60bd1d2d-f285-427f-a909-526da04cda6e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("614f90a8-9bad-4e97-ac7f-0e2a6e94396d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("64484794-fde7-4914-aa07-079b0b65fa39"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("648e6692-7152-4674-8136-7445bc89baf9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("65979de5-9dc1-4503-8ab6-db5ad6cf2354"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("65b3b4d3-125f-4325-aa3e-239ded144a32"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("65ba7625-993b-43db-800d-d56f9bcc6c29"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("686f1806-eac2-4da3-a1ef-74e8b056e55a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6a04aa74-1dd0-4884-a537-f0052042a8a4"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6a42a294-abf6-4c93-b10a-383bc11d833b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6b2671ec-8129-4c33-bf6a-a0918ad564dd"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6b553cf9-0076-44a5-8418-e998a8560d3b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6b5720b5-4c57-45d1-972c-69b455009ce2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6ba3f5d5-d28c-48e3-8c8e-883b82ff0e27"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6c222eaa-cf21-472e-b90c-dba298946cda"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6c86ec85-ce09-40a3-8ee5-453645b05e75"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6cc491e1-ff71-4f4f-a4b6-f575370520fa"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("6d223d5a-817e-41fa-bd83-f2c844096bbd"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("712a0cb8-f042-4867-8b3d-0647bafc6c88"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("71c7bc2d-473b-47e4-a0bf-b03ffc696b08"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("72cf902e-58f1-4d38-adaf-fd579b81b32e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("74703a73-a224-4698-942c-4926af8ef9d2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("769124cf-47b3-4f0d-944e-2b2d78e72c55"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("7a08a874-fd8c-416c-97af-5a9c7bef9f27"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("7a1bca9d-a161-4667-a573-8c2e10e342b8"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("7ee622a1-dfe4-4c97-9775-f03e2ad1490e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("7f4b5cba-9304-474e-92df-372d4e29f38a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("80a20125-bfad-40bf-a963-589bc111bd07"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("81724e59-8760-45e6-9dd8-8acd8aae11c9"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8272c05a-d558-45ae-8cfe-9a5c48631f25"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("843c98f5-2780-447f-ba1b-e35440c85cb0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("846e5d83-8d11-4a1d-9832-cbaaeae0748d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("85b0541c-4558-497c-bf4e-5283eedcf2c0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8666a88b-cce5-4682-a680-2ded0dc4c194"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("86e2026f-5c38-4481-ab92-408883f2f1ba"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("873d0b57-9b51-4210-be35-271cd3aa8851"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8b73e1b6-3580-4e24-9d58-d759ded9b1c3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8cf69831-527d-407b-b4c2-74828e912cea"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("8feca9d0-39c9-4a6b-8f15-4dde8ddb7dbb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("90b28ca4-8ce7-477e-b9e9-dc0210f4bba5"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("91a9751b-7ad5-4ced-b4d3-a21e24b3ea16"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("91b3cf39-e873-43c5-ae4e-b4edaaaece9f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9346b8d0-ee01-4a96-9bb5-d490b7ffc746"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("93985f7f-d401-4500-b954-aaa7c77497de"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9550ac8f-1af6-4de4-9249-09a808a5503b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("976b3fd5-3759-45f8-8739-4aa731fbdfc6"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9bf02cc3-e312-4d29-a7f9-52e83533df95"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9d0cd875-071e-4b78-b9ee-688e42391446"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("9ec36ae4-0970-4b26-9bd3-cdc4136a740a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("a5ba8552-740d-4436-a072-16266102817e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("a5e6cf3a-ae5c-4de8-90fb-430473f07253"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("aaa3b066-a04c-4322-87f5-d5da52ec929f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ad5604da-e62f-4830-9af7-b7febe532ed2"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b20c32c2-094f-4c09-b112-88c707353a9b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b36be1a2-ce03-483a-a9d0-e88a498e2cde"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b46b04eb-d0c6-4611-bdf9-b6123d022adc"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b7d0289f-32c6-4e8d-ac94-8b9fb4d26c9d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b7d93eea-6acd-4eac-ad4f-b3b258f618fe"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b8619a82-bb4d-40ce-a734-61d0d2c1efc3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("b9fc4254-a4c8-44b1-90bd-fd557264e694"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ba18c568-cd73-4055-96b0-694dea28574c"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bbd7e8e2-fdd7-40e9-90d4-f749dcf53752"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bbf11303-dde2-4a3d-96d9-e9fd5fb7c4da"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("bce193da-3e68-4747-85f3-ef94d6b3449f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c3100e0e-21dc-4e33-9cb7-0bb3a0361e4b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c52c7c3a-9f71-480f-ad5d-3f8214a87aa6"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c7e2376f-8a30-4d8e-afc4-35812213458a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("c98dcb81-0328-4c9b-b40d-b2426422ab40"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ca032e5e-d8fe-428c-8fe5-e88fd283aa49"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("cbd4830b-8d56-4917-8018-ad5c2c7f4316"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("cc77ef15-898a-4d00-b2de-cd6746ee2983"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("cfdbc919-1929-45da-84cd-ae65f82a84d0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d0ecb141-6ba1-46d0-b4ba-d98beacc89f0"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d2e25924-132d-4e96-86fe-5cfaa6982f32"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d52e2ae7-ee5a-4eb0-af40-20463b9dc0ab"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d530553a-138f-4668-ae8e-d36abba6b854"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d6640270-1004-479d-a606-afedaa2059da"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("d9ee07e1-578d-4961-9417-1030ce1a6315"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("da595e21-9284-49bd-b9b0-4517f0ba967f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("dbd6cf6c-8cf2-453e-97a0-1395da97d41e"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("dce29d64-40f1-4c87-b595-3673ff3942b7"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("de439c05-6b16-4def-b798-adc6b72b4013"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e0ff402d-eb99-4c30-8529-cdcba070232f"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e32ea08b-cfc9-4e28-8cd1-0005dfc52b31"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e412404e-5c1a-47b7-99e7-f2400719265b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e4e4d68d-7e8e-4122-8339-888e4d16550b"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e7022602-1fe1-4f63-9249-19ffa1cb6eb5"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e70c83ca-01da-4c8d-b5bc-e367f011c895"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e9165122-a7ba-4c4f-aeeb-00111195eac3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("e97d3545-042f-4ac3-bcf8-e0beb7c6639d"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("eaecdd66-18ce-4332-8aac-86ce19555705"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("eb5ab929-9853-4d3c-b92a-f9136ebe2c24"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ec76f2eb-51b9-4d94-b5cc-0fb732fc8f47"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ec8cad63-144f-4d36-8cda-c43ef10d3fa3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f4c64af0-636b-4466-b653-a614106d0ed4"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f63ea4b8-417a-4bf6-9f81-b06637684375"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f6519bfe-7ffd-44bc-9e65-d1c7c516524a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f88aa06f-4e69-475e-ba66-c135f510bba3"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f92f8360-88de-4012-8edf-0a65944b48fb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("f92fa5f6-8874-4193-b2b4-3a343969fa88"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("fc46ddff-430a-46cb-ba78-1279a817dacb"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("fd1711a2-2cad-4127-9428-06ec6498599a"));

            migrationBuilder.DeleteData(
                table: "HeraldPosts",
                keyColumn: "Id",
                keyValue: new Guid("ff1fa196-cc1b-4c56-a578-343b32ce7293"));

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "00361045-5b8e-4699-adf6-9545aa4a8dfc");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "0265bc77-964b-456e-9c06-262c373085b9");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "04127b5c-6c26-4de1-a416-d877d1a8dffa");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "051c2486-9432-4fcf-b847-7ef0ce43a029");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "0b283f7a-21ac-402f-abcb-00a5807440ee");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "1134d51e-713f-492d-99cf-67a658297d2c");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "15398653-8f59-48b8-ac12-007b276571bd");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "170788df-5f5b-4414-b9ed-e4e085c62b9a");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "1c6c450a-c0d7-4563-8780-fa88c7d4fca8");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "1d00d7b6-515d-4b1e-8fa8-23898fa4b7a7");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "1feb7474-19e3-4854-9e4e-434cfb53de3f");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "21a9584a-6ac1-4202-ab9b-017c47d5e2af");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "2228b111-a4b2-43b4-98ab-cb2a678c146c");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "24600f77-8b11-4e26-8923-0565dbf94089");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "26462bcf-19a4-44e3-a40e-8eb824345b6c");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "2ef12ccc-1b31-426d-b6ce-38ee51268b15");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "2f5b35c3-75cc-4a35-9d08-5253fe2ac711");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "30229d07-953b-4b1a-9d8d-fd9bbdfc755c");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "3043d715-fd9a-40d0-abf3-9fa8af697a7c");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "3319415a-4b3d-40b5-a106-00f9844dde14");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "34524645-a1a6-4d0c-be70-8efcf98332fd");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "36e319f8-2832-48c2-af12-3e1f355c6506");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "373eec25-819d-4aa0-a73b-3e6ff240a043");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "3a07d9ad-2769-407d-acf9-64c59ab44b2f");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "3d9e30c8-44b7-4589-a65a-42937b29282a");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "3e3226c3-a564-480b-a223-83d0c2c9f0fe");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "481774b6-ac95-41ed-b969-6f9e39775e2b");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "49a98c7e-41d9-4fe5-aa57-ff987582e83e");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "4d143142-e617-4d1f-9cc0-7cb6a23d56d6");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "4eba5a8d-6dcb-49e1-8626-067cce22681d");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "51ec4127-b26b-49d3-863e-fae6d7b113db");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "528602b0-b40b-45c7-953c-dd80f8a8cbc1");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "53556fdb-3324-4174-a932-659df194cd8a");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "54a12528-2947-49d2-bf2f-87dc2058b24e");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "5699c6a8-7113-45bf-a65d-e74f8858b3b5");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "58322036-66d9-469a-bf8e-1b8ebeaf6cf7");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "5943bea6-d792-4cee-98e3-92c2c8808c01");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "5969c7c5-73c5-4d36-ba70-7a513b3bc9ea");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "599d3d4f-e6e2-4f4c-9cfa-2f354464517c");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "5d0aada8-41d9-4a6f-9d57-c96604ea22f2");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "5daef6bc-fd31-4a64-942f-34a42ade501d");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "60f48de6-3eab-463a-a296-fccba6fb9ae4");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "643138ab-ff7c-4272-82c2-d677254bb31f");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "646f3bbe-29c6-4b6a-8668-0ed1a6b57a00");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "647cf498-2ff0-4ecc-bbbc-5ba2dee39c86");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "658c3bb4-d0f5-40b2-84e0-d3196654038f");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "6d01b1a9-8c6a-4304-83f4-cd130348e6bc");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "6d4e2d4e-b2d5-4f86-923b-f953c5beefbc");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "6d83383b-4aac-430d-9562-b7b0ef9a0a81");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "6e17704d-f1d5-4250-b69c-4fb8867b31ac");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "72d0faaa-4ee6-4329-af89-6567610811e9");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "73cb7e24-98c7-4ffd-8fcf-c9e34dca9800");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "766a85b1-5ce7-4bbf-ab86-ec2abccf9d39");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "77083c65-606b-4e76-9642-3ef25a1e5fdf");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "7aa57a7a-8ee4-4488-b862-9352a9d4d7e5");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "7b8779f4-18f0-4248-a1b8-ef330f4de963");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "7bfd8bcf-30d7-45c8-ae28-0d9c5745cc6c");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "7dba455f-4d74-4cf4-ad3a-4debf73312e5");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "7dffc988-f699-4318-8a1c-3a9ee475e3aa");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "7efb0ed3-aa70-43bc-80a6-e19ea6098992");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "850e1cc0-1ae8-4be2-b7c4-2d7c93fd743d");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "886e3b2f-bd80-4eed-9225-4f0aba1cd8e1");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "89d85c74-60d7-4284-8df0-ef2d1cb96ed6");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "8d033d42-d08f-4067-bdb9-a08a5d7a9a41");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "8f47b7b2-4836-473d-b664-0db6844b78e0");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "91b966c5-ba9a-4439-a018-3129101f4467");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "93d99dd4-fbb0-436e-a7b6-53ea0c2079d9");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "94cced5d-85e6-4343-a0c3-73669862be99");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "96323253-51e6-4c3f-810c-802669279fb6");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "98dc3c93-68dd-477b-b5ea-a63fe53ea6fe");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "9fd12300-8366-4457-9589-c014049413e9");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "a1568348-e0b1-462b-9539-d30964fa6519");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "a21ab9eb-248d-4aac-8bce-2f188002aa0e");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "a3ecea43-3a34-4d2b-8ad2-351bda97bc38");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "a5ba4c60-2873-4f7b-9f13-e2cf663703e3");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "aacb7e85-a7ef-415a-8c3b-ae966984e934");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "ac264515-1f1b-4463-ae07-b4617a544780");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "acf1f846-19dc-4968-a0b1-a23f74fe2127");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "ae0c23ce-a818-4d14-be6a-039a0dbfea43");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "b055ac85-c8df-4937-ae92-fb6e5fc2ba10");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "b143dd16-45a6-441a-977f-49af6229306f");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "b40044d1-6055-4931-97dd-eaedb6cfa73a");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "b5234b3b-4b5a-4b98-81d2-fae73b6d5550");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "b6ed060a-e449-460b-a668-d8084e7021ba");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "b9c6b3fc-1500-4f25-b14b-e8a79c9710ea");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "bbe7b357-8319-47fd-97b6-efd188b49a7f");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "bc851907-b0f9-4f10-a47a-8a148bce7839");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "bd0b9ab5-51e6-4609-a5e6-f1e70f760088");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "c3601e3b-8b3a-414e-8cd6-3b98b8527a62");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "c4390809-b967-4d58-a29e-46089c6fc752");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "c4c4ba59-7b1d-44bf-8eb6-f27903c07c04");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "ca58aeec-6bdc-47de-875c-81ec0c74a800");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "cc0cd5f4-19ea-4976-bcb6-6860ff35c00b");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "ced841f3-0c1f-4911-a640-8e8d1fc20428");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "d1f80e78-b1e9-4f2b-bfc0-9e19fbf11ada");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "d2fe1317-7746-4eec-a2f7-6804c02f12f8");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "d96ae4ce-2453-41a1-a29f-f958a6531149");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "d973d458-024c-460c-b980-488e748bf392");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "d977c3da-2977-46b0-98d7-a208b642b7ab");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "e004a4a8-e236-466d-b5e0-921a520063b2");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "ef5d04b3-10a1-4148-86eb-59dee4bc1e9d");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "f2f17a75-c1e3-4e29-a0db-734322082266");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "f4a6ae19-a116-481f-90c0-7196d5735279");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "f4c18de8-e4d8-4509-9141-fc0a9871f87a");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "f51a5e83-df78-471f-9469-3faeba6c308f");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "f684a508-1177-4868-8858-651fe9160f75");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "fba182a1-e1f3-49ac-836c-36c3c02c6371");

            migrationBuilder.DeleteData(
                table: "Runways",
                keyColumn: "Id",
                keyValue: "fed04b65-2777-4d3f-93c6-3593a87b9fe4");

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
