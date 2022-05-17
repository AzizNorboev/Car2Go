﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car2Go.Data.Migrations
{
    public partial class initialmigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    InUse = table.Column<bool>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    GearType = table.Column<int>(nullable: false),
                    PricePerDay = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarRentDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    RentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRentDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarRentDays_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    RentStart = table.Column<DateTime>(nullable: false),
                    RentEnd = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PickUpLocationId = table.Column<int>(nullable: false),
                    ReturnLocationId = table.Column<int>(nullable: false),
                    ReviewId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Locations_PickUpLocationId",
                        column: x => x.PickUpLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Locations_ReturnLocationId",
                        column: x => x.ReturnLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1a3080f1-0324-498e-a59a-0f2448b15022", 0, "ff8e0708-41ff-4b14-9d24-7cdc5d8305ed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin@gmail.com", false, false, false, null, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC4RjnjMFvg645o7YYmrErMGKbvfiIZ2QqUwqy7UlWVpwY4MPx0HIAU1HtqUgqwbaQ==", null, false, "dfccda28-128d-45b8-8627-fc8e8b1f75a1", false, "Admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Description", "GearType", "Image", "InUse", "IsDeleted", "Model", "ModifiedOn", "PricePerDay", "Speed", "Year" },
                values: new object[,]
                {
                    { 21, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3148), null, "in good condition", 0, "https://uzautomotors.com/images/uploads/ca519572d01038ee51311f82f9384204.jpg", false, false, "CHEVROLET LACETTI", null, 180000m, 200, 2020 },
                    { 11, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3134), null, "If appearance is important, then Lacetti is for you. Correct proportions, streamlined shapes, relief lines harmoniously combined in this car, which has a respectable interior and exterior. Lacetti comfortably accommodates five people in a modern laconic salon. The instrument panel features a sense of proportion and variety of options. The arrangement of the instruments with chrome elements is carefully thought out. Its driving qualities are thoroughly tested and perfected.", 2, "https://uzautomotors.com/images/uploads/8c8ad114c16e10db77c7953a2afc5b62.jpg", false, false, "CHEVROLET LACETTI", null, 200000m, 280, 2020 },
                    { 20, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3120), null, "", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQW3yA6kh0qsD_IP65A3K9Ibsbkm1k8x2gaEQ&usqp=CAU", false, false, "Chevrolet Impala", null, 280000m, 200, 2018 },
                    { 10, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3106), null, "The Impala continues to reign as the leading large sedan. Slide behind the wheel and you can see why. Roomy, supportive seats put you in the perfect position to access the intuitive controls. Despite its prodigious size, the Impala’s handling is responsive and secure.", 2, "https://banner2.cleanpng.com/20180410/xrw/kisspng-2017-chevrolet-impala-2018-chevrolet-impala-chevro-chevrolet-5accd70885ac83.6020416415233738325475.jpg", false, false, "Chevrolet Impala", null, 300000m, 200, 2020 },
                    { 19, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3091), null, "", 0, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzsEfyLUAVg2o3cjhWRZ4el8z6T6dCU7SzmA&usqp=CAU", false, false, "CHEVROLET TRAILBLAZER", null, 390000m, 200, 2020 },
                    { 9, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3076), null, "A full-size SUV that combines technology, performance, design and safety is all about it - the Chevrolet Trailblazer. If you need a car with a powerful engine for both travel and everyday life, then Trailblazer is a great choice", 1, "https://uzautomotors.com/images/uploads/6be5fb769c9b8ef6509eb3f3a1fc497a.jpg", false, false, "CHEVROLET TRAILBLAZER", null, 300000m, 200, 2020 },
                    { 8, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3048), null, "The new Chevrolet Traverse has everything to make every kilometer special for you and your family. Up to 8 passenger seats and the most spacious luggage space in the class, the function of choosing a driving mode and an advanced all-wheel drive system, a solid appearance and a well-designed interior - this car is able to adapt to any task. Add to this the latest security technology, as well as additional features for your comfort, and you will understand why Traverse is worthy of your choice.", 1, "https://blogmedia.dealerfire.com/wp-content/uploads/sites/1074/2019/12/2020-Honda-Ridgeline-exterior-side-shot-with-Obsidian-Blue-Pearl-paint-color-parked-on-a-beach-line-of-gravel-and-sand-next-to-the-ocean_o.jpg", false, false, "CHEVROLET TRAVERSE", null, 315000m, 220, 2020 },
                    { 7, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3034), null, "And the most interesting is the motor range. The two-liter car is equipped with a nine-speed automatic, and the other two with a six-speed automatic. Drive - front or full. The fuel tank has a volume of 55 l, a 2.0 Turbo engine, consumption starts from 8.2 l / 100 km in the urban cycle. Acceleration time of the Chevrolet Equinox is 7.8 s to 100 km / h.", 1, "https://uzautomotors.com/images/uploads/2c2252e409368d0d3549beaa3e0651a4.jpg", false, false, "CHEVROLET EQUINOX", null, 320000m, 230, 2020 },
                    { 17, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3019), null, "", 0, "https://www.motortrend.com/uploads/sites/5/2018/10/2019-Kia-Optima-SX-front-three-quarter-in-motion-3.jpg", true, false, "Kia Optima", null, 260000m, 200, 2020 },
                    { 6, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3003), null, "The Optima is a vehicle that delivers all of these virtues in a stylish, value-laden package that’s filled with features usually found on pricier cars. With outstanding reliability and extensive warranty coverage, savvy sedan shoppers should take this recently redesigned car for a test drive.", 2, "https://i.dir-i.net/CMS/2019/12/28/k/5f_kzmt31.jpg", true, false, "Kia Optima", null, 350000m, 200, 2020 },
                    { 18, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(3062), null, "", 0, "https://fichasmotor.com/images/chevrolet/chevrolet-traverse-i-3-6-v6-281-cv-awd-automatico.webp", true, false, "CHEVROLET TRAVERSE", null, 280000m, 200, 2020 },
                    { 5, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2937), null, "The Chevrolet Tracker is an automotive nameplate that has been used by Chevrolet for two different vehicle lines. Chevrolet Tracker (Americas): since 1988 for the 1989 model year, spanning two generations, Chevrolet has rebadged a version of the Suzuki Escudo as the Tracker.", 2, "https://uzautomotors.com/images/uploads/c892a6c45990f70c4531efb3b1c95a68.jpg", false, false, "Chevrolet Tracker", null, 310000m, 220, 2020 },
                    { 16, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2985), null, "", 0, "https://auto.ironhorse.ru/wp-content/uploads/2017/06/Tracker-New.jpg", true, false, "Chevrolet Tracker", null, 350000m, 200, 2020 },
                    { 12, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2768), null, "", 0, "https://tasinha-photos-kluz.kcdn.online/webp/79/79646cb0-2e11-49b9-ae7a-50454c50b56c/1-160x120.jpg", false, false, "Cobalt", null, 170000m, 200, 2019 },
                    { 2, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2836), null, "The Nexia is one of the most compact, stylish and popular cars in the world, combining a sporty look and a spacious, comfortable interior. It is easy to operate and has a high-tech security system. Quality interior decoration materials are carefully thought out to the smallest detail. The large luggage allows you to take everything you need with you on the trip without sacrificing anything.", 1, "https://uzautomotors.com/images/uploads/e2d6a236bd002eb0ce3b4b7613f009c7.jpg", false, false, "Nexia 3", null, 150000m, 180, 2020 },
                    { 13, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2861), null, "good", 0, "https://tasinha-photos-kluz.kcdn.online/webp/04/04f10e23-aff0-4388-86d0-62bd87f06ad5/1-160x120.jpg", true, false, "Nexia 3", null, 170000m, 200, 2020 },
                    { 1, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(1141), null, "Chevrolet Cobalt is a family sedan created by the designers of the Brazilian division of the GM Corporation using standard GM global development processes. Cobalt was developed by GM's global team to become the world benchmark in its segment and the leader in sales in growing markets. Chevrolet Cobalt combines comfort, sophistication and high dynamic qualities, as well as timeless traditional classic design. To ensure better safety, the Chevrolet Cobalt, manufactured from high-strength steel, is equipped with ABS (anti-lock braking system) and driver and front passenger airbags", 2, "https://uzautomotors.com/images/uploads/ca519572d01038ee51311f82f9384204.jpg", false, false, "Cobalt", null, 180000m, 200, 2020 },
                    { 14, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2894), null, "", 0, "https://tasinha-photos-kluz.kcdn.online/webp/2f/2fcac581-4e12-4d0c-b062-84db5ecadf37/5-160x120.jpg", true, false, "Malibu", null, 280000m, 200, 2020 },
                    { 4, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2909), null, "The Chevrolet Tracker is an automotive nameplate that has been used by Chevrolet for two different vehicle lines. Chevrolet Tracker (Americas): since 1988 for the 1989 model year, spanning two generations, Chevrolet has rebadged a version of the Suzuki Escudo as the Tracker.", 2, "https://i.ibb.co/PF4pxf1/52.jpg", false, false, "Chevrolet Tracker 2", null, 310000m, 245, 2019 },
                    { 15, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2923), null, "", 0, "https://www.autostrada.uz/wp-content/uploads/2020/12/20210115_123901-001.jpg", true, false, "Chevrolet Tracker 2", null, 300000m, 200, 2020 },
                    { 3, new DateTime(2022, 5, 17, 14, 3, 15, 660, DateTimeKind.Utc).AddTicks(2876), null, "Designers, working on a new generation of Chevrolet Malibu, tried to give the model more aggressiveness in the exterior. The novelty, unlike the previous generation, has a completely different exterior design. The presence of broken lines and bends gives the sedan a dynamic and makes it particularly attractive. The dual easy-to-recognize branded Malibu radiator grille is now equipped with a narrower head LED optics. The relief impressions on the sides of the body together with the rear part are similar in many respects to the Impala sedan, but in general the majority of the body elements are similar to the legendary Camaro, but it is only externally. At the same time, due to careful study of individual body parts, it was possible to achieve excellent aerodynamic performance. In the Uzbek market the car will be presented in 4 colors (pearl white, white-smoky, dark gray and black).", 2, "https://uzautomotors.com/images/uploads/60e102ca38452ea6ba25541824d9d045.jpg", true, false, "Malibu", null, 300000m, 220, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9336), null, false, null, "Park Amir Temur" },
                    { 1, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(8258), null, false, null, "Tashkent International Airport" },
                    { 2, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9201), null, false, null, "Chilanzar Subway Station" },
                    { 3, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9247), null, false, null, "Hilton Hotel" },
                    { 4, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9263), null, false, null, "Mega Planet" },
                    { 5, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9278), null, false, null, "North Train Station" },
                    { 6, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9296), null, false, null, "South Train Station" },
                    { 7, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9309), null, false, null, "Bunyodkor Stadium" },
                    { 8, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9323), null, false, null, "Oybek Subway Station" },
                    { 10, new DateTime(2022, 5, 17, 14, 3, 15, 659, DateTimeKind.Utc).AddTicks(9350), null, false, null, "Buyuk Ipak Yoli Subway Station" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_IsDeleted",
                table: "AspNetRoles",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IsDeleted",
                table: "AspNetUsers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarRentDays_CarId",
                table: "CarRentDays",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRentDays_IsDeleted",
                table: "CarRentDays",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_IsDeleted",
                table: "Cars",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_IsDeleted",
                table: "Locations",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CarId",
                table: "Orders",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IsDeleted",
                table: "Orders",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PickUpLocationId",
                table: "Orders",
                column: "PickUpLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ReturnLocationId",
                table: "Orders",
                column: "ReturnLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ReviewId",
                table: "Orders",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ApplicationUserId",
                table: "Reviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CarId",
                table: "Reviews",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_IsDeleted",
                table: "Reviews",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarRentDays");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}