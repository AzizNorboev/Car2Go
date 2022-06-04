using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class addeddealeruserrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5c0a153-575a-423e-bcfc-f463ebcf8c99");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Dealers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dealers_AspNetUsers_UserId",
                table: "Dealers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealers_AspNetUsers_UserId",
                table: "Dealers");

            migrationBuilder.DropIndex(
                name: "IX_Dealers_UserId",
                table: "Dealers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c6bc831-9d58-4082-88e1-c76d2a06c63f");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Dealers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b5c0a153-575a-423e-bcfc-f463ebcf8c99", 0, "ad36d70d-b84a-4eb8-aa9d-a33c71d1ccee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBgR9nXPZs6euU3fSHsL6rCRUnNYQU+oQRZBA8GxR67bYDc4k8NMqN4Uuazz0Jz8kA==", null, false, "6b8f8afd-ec4b-4ae7-ab6e-1adc7a69a44b", false, "Admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 4, 9, 48, 44, 475, DateTimeKind.Utc).AddTicks(2860));
        }
    }
}
