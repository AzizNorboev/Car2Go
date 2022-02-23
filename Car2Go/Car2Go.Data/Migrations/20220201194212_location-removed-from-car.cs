using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class locationremovedfromcar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_LocationId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Cars");

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
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6167), false });

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
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6260), false });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6275), false });

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
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6308), false });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6323), false });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6371), false });

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
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 2, 1, 19, 42, 12, 601, DateTimeKind.Utc).AddTicks(6406), false });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(8469), 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "InUse", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(69), true, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(150), 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "InUse", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(167), true, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "InUse", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(183), true, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(199), 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "InUse", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(213), true, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "InUse", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(228), true, 4 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "InUse", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(242), true, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(258), 6 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "InUse", "LocationId" },
                values: new object[] { new DateTime(2022, 1, 17, 11, 31, 46, 917, DateTimeKind.Utc).AddTicks(272), true, 7 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 915, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 17, 11, 31, 46, 916, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LocationId",
                table: "Cars",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_IsDeleted",
                table: "Settings",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Locations_LocationId",
                table: "Cars",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
