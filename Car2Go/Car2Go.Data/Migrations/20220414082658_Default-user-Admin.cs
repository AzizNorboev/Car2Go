using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class DefaultuserAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a20e2f-5ae2-4942-8bb3-b916b2aa6316");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "26470ddc-5e4b-4f58-b367-1338e4274ddf", 0, "97283e94-b504-4a14-b937-42dc69f7fd40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEmCbCwcJqU0aO3Y8TLvhRxDWS3+CfadygkyI1h2Yzd7svGh3iTqt1JXhQzW1TEYCA==", null, false, "1031d765-594c-4df2-b7b4-5c519959e4ea", false, "Admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(4885));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26470ddc-5e4b-4f58-b367-1338e4274ddf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7a20e2f-5ae2-4942-8bb3-b916b2aa6316", 0, "9d30bd1a-dd19-4ffc-8ea3-f46b71142bff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adm1n@gmail.com", false, false, false, null, null, "ADM1N@GMAIL.COM", "ADM1N@GMAIL.COM", "AQAAAAEAACcQAAAAEOC/yTHvpg7oUiu2/5/u1OjHmBPx278pJ9rjSQDjdG3JkW6v9e1h6v9jT840cvO8JQ==", null, false, "b5c85195-e9fd-4a76-bc0e-df58863bff5c", false, "Adm1n@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 81, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 14, 8, 16, 26, 82, DateTimeKind.Utc).AddTicks(789));
        }
    }
}
