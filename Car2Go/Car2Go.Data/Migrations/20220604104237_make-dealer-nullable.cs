using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class makedealernullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c6bc831-9d58-4082-88e1-c76d2a06c63f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "faf8f564-4c55-4eea-93b2-cac390eada4c", 0, "1cf7011c-8adf-48b8-bc9f-17c0c038c2ed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEA9huOsqqmq5V8H9SBElWGvgtbT06GwmHvWOpCBTeZf0P0fl1OqpRyeYD01ZW8Hrg==", null, false, "71c9ecf4-46cd-4868-944f-7e03836427ab", false, "Admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 42, 37, 404, DateTimeKind.Utc).AddTicks(1280));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faf8f564-4c55-4eea-93b2-cac390eada4c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6c6bc831-9d58-4082-88e1-c76d2a06c63f", 0, "1e2a0250-d777-48b7-a60a-d9bc2c4c9fd4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEUPZqOZO7VvJlKn91CP2+DBmPLCIL5AqeoC4TIf3jY/ZnPWT+D/aaOQ4umdD+C6vA==", null, false, "b9f3d883-5702-46fe-aff6-6f6ac88a6683", false, "Admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 780, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 10, 29, 19, 779, DateTimeKind.Utc).AddTicks(6788));
        }
    }
}
