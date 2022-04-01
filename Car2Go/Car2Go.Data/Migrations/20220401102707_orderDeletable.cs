using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class orderDeletable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Orders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 769, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 767, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 1, 10, 27, 6, 768, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IsDeleted",
                table: "Orders",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_IsDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 600, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(2428));
        }
    }
}
