using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class addeddealer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a3080f1-0324-498e-a59a-0f2448b15022");

            migrationBuilder.AddColumn<int>(
                name: "DealerId",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 1000, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DealerId",
                table: "Cars",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dealers_IsDeleted",
                table: "Dealers",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Dealers_DealerId",
                table: "Cars",
                column: "DealerId",
                principalTable: "Dealers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Dealers_DealerId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.DropIndex(
                name: "IX_Cars_DealerId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5c0a153-575a-423e-bcfc-f463ebcf8c99");

            migrationBuilder.DropColumn(
                name: "DealerId",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1a3080f1-0324-498e-a59a-0f2448b15022", 0, "ff8e0708-41ff-4b14-9d24-7cdc5d8305ed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC4RjnjMFvg645o7YYmrErMGKbvfiIZ2QqUwqy7UlWVpwY4MPx0HIAU1HtqUgqwbaQ==", null, false, "dfccda28-128d-45b8-8627-fc8e8b1f75a1", false, "Admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9350));
        }
    }
}
