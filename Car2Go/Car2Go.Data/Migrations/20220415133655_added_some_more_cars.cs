using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class added_some_more_cars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26470ddc-5e4b-4f58-b367-1338e4274ddf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4ccbfe86-5b23-486f-aa50-775c93ac200c", 0, "12559aa2-bc8c-4d00-95b0-f23d5e649948", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC2j/AgRm1/yd236aHmVHG/shdVIS8hmOuUZItZDWB3uYjJf4WMIVK7eSRU78QxEIg==", null, false, "a0c680b7-25f6-4f14-b287-d4bcffcb8a28", false, "Admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(4496), false });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6288), false });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "GearType", "Image", "InUse", "IsDeleted", "Model", "ModifiedOn", "PricePerDay", "Speed", "Year" },
                values: new object[,]
                {
                    { 20, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6302), null, "", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQW3yA6kh0qsD_IP65A3K9Ibsbkm1k8x2gaEQ&usqp=CAU", false, false, "Chevrolet Impala", null, 280000m, 200, 2018 },
                    { 12, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(5947), null, "", 0, "https://tasinha-photos-kluz.kcdn.online/webp/79/79646cb0-2e11-49b9-ae7a-50454c50b56c/1-160x120.jpg", false, false, "Cobalt", null, 170000m, 200, 2019 },
                    { 13, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6039), null, "good", 0, "https://tasinha-photos-kluz.kcdn.online/webp/04/04f10e23-aff0-4388-86d0-62bd87f06ad5/1-160x120.jpg", true, false, "Nexia 3", null, 170000m, 200, 2020 },
                    { 21, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6331), null, "in good condition", 0, "https://uzautomotors.com/images/uploads/ca519572d01038ee51311f82f9384204.jpg", false, false, "CHEVROLET LACETTI", null, 180000m, 200, 2020 },
                    { 14, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6072), null, "", 0, "https://tasinha-photos-kluz.kcdn.online/webp/2f/2fcac581-4e12-4d0c-b062-84db5ecadf37/5-160x120.jpg", true, false, "Malibu", null, 280000m, 200, 2020 },
                    { 15, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6139), null, "", 0, "https://www.autostrada.uz/wp-content/uploads/2020/12/20210115_123901-001.jpg", true, false, "Chevrolet Tracker 2", null, 300000m, 200, 2020 },
                    { 16, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6170), null, "", 0, "https://auto.ironhorse.ru/wp-content/uploads/2017/06/Tracker-New.jpg", true, false, "Chevrolet Tracker", null, 350000m, 200, 2020 },
                    { 17, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6200), null, "", 0, "https://www.motortrend.com/uploads/sites/5/2018/10/2019-Kia-Optima-SX-front-three-quarter-in-motion-3.jpg", true, false, "Kia Optima", null, 260000m, 200, 2020 },
                    { 18, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6244), null, "", 0, "https://fichasmotor.com/images/chevrolet/chevrolet-traverse-i-3-6-v6-281-cv-awd-automatico.webp", true, false, "CHEVROLET TRAVERSE", null, 280000m, 200, 2020 },
                    { 19, new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(6273), null, "", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzsEfyLUAVg2o3cjhWRZ4el8z6T6dCU7SzmA&usqp=CAU", false, false, "CHEVROLET TRAILBLAZER", null, 390000m, 200, 2020 }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 4, 15, 13, 36, 54, 650, DateTimeKind.Utc).AddTicks(2971));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ccbfe86-5b23-486f-aa50-775c93ac200c");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "26470ddc-5e4b-4f58-b367-1338e4274ddf", 0, "97283e94-b504-4a14-b937-42dc69f7fd40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEmCbCwcJqU0aO3Y8TLvhRxDWS3+CfadygkyI1h2Yzd7svGh3iTqt1JXhQzW1TEYCA==", null, false, "1031d765-594c-4df2-b7b4-5c519959e4ea", false, "Admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(6379), true });

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
                columns: new[] { "CreatedOn", "InUse" },
                values: new object[] { new DateTime(2022, 4, 14, 8, 26, 58, 586, DateTimeKind.Utc).AddTicks(8177), true });

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
    }
}
