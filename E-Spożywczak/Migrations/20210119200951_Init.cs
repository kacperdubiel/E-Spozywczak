using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Spożywczak.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypeOfPayment = table.Column<int>(type: "int", nullable: false),
                    IsOrderPaid = table.Column<bool>(type: "bit", nullable: false),
                    OrderPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    OrdersHistoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Delivery_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Delivery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_OrderHistory_OrdersHistoryId",
                        column: x => x.OrdersHistoryId,
                        principalTable: "OrderHistory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MeasureType = table.Column<int>(type: "int", nullable: false),
                    Availability = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductAmount = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    RatingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cart",
                column: "Id",
                values: new object[]
                {
                    1,
                    2,
                    3
                });

            migrationBuilder.InsertData(
                table: "Delivery",
                columns: new[] { "Id", "DeliveryTypeName", "Price" },
                values: new object[,]
                {
                    { 1, "Pocztex48", 8.5 },
                    { 2, "Kurier DPD", 10.9 },
                    { 3, "Kurier DHL", 12.9 }
                });

            migrationBuilder.InsertData(
                table: "OrderHistory",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Słodycze" },
                    { 2, "Owoce" },
                    { 3, "Pieczywo" },
                    { 4, "Nabiał" },
                    { 5, "Mięso" },
                    { 6, "Soki" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CartId", "DeliveryAddress", "DeliveryId", "IsOrderPaid", "OrderDate", "OrderPaymentDate", "OrdersHistoryId", "TypeOfPayment" },
                values: new object[,]
                {
                    { 1, 1, "Krynicka 14 50-555 Wrocław", 1, true, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, 1 },
                    { 2, 2, "Krynicka 14 50-555 Wrocław", 2, false, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 3, 3, "Krynicka 14 50-555 Wrocław", 3, false, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Availability", "Description", "ImagePath", "IsAvailable", "MeasureType", "Name", "Price", "ProductCategoryId" },
                values: new object[,]
                {
                    { 16, 46.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "bułka_kajzerka.jpg", true, 0, "Bułka kajzerka", 0.40m, 3 },
                    { 17, 46.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "bułka_paryska.jpg", true, 0, "Bułka paryska", 0.40m, 3 },
                    { 18, 46.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "bagietka_czosnkowa.jpg", true, 0, "Bagietka czosnkowa", 0.40m, 3 },
                    { 19, 32.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "mleko.jpg", true, 0, "Mleko", 3.40m, 4 },
                    { 20, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "ser_gouda.jpg", true, 1, "Ser gouda", 15.40m, 4 },
                    { 21, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "twaróg_chudy.jpg", true, 0, "Twaróg chudy", 4.40m, 4 },
                    { 22, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "jajko.jpg", true, 0, "Jajko", 0.80m, 4 },
                    { 23, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "camembert.jpg", true, 0, "Camembert", 15.40m, 4 },
                    { 24, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "kurczak_pierś.jpg", true, 1, "Pierś z kurczaka", 16.30m, 5 },
                    { 25, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "krakowska.jpg", true, 1, "Kiełbasa krakowska", 10.30m, 5 },
                    { 26, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "schab.jpg", true, 1, "Schab", 25.33m, 5 },
                    { 27, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "kurczak_caly.jpg", true, 0, "Kurczak cały", 25.60m, 5 },
                    { 15, 31.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "bułka_grahamka.jpg", true, 0, "Bułka grahamka", 0.90m, 3 },
                    { 14, 5.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "chleb_biały.jpg", true, 0, "Chleb biały", 2.40m, 3 },
                    { 13, 40.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "bananypremium.jpg", true, 1, "Banany premium", 3.62m, 2 },
                    { 12, 4.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "ananas.jpg", true, 0, "Ananas", 8.65m, 2 },
                    { 11, 4.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "cytryna.jpg", true, 1, "Cytryna", 9.70m, 2 },
                    { 10, 10.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "gruszka_konferencja.jpg", true, 1, "Gruszka konferencja", 4.62m, 2 },
                    { 9, 40.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "jablko.jpg", true, 1, "Jabłko Gala", 3.62m, 2 },
                    { 30, 11.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "ciastka_delicje.jpg", true, 0, "Ciastka delicje", 2.50m, 1 },
                    { 8, 49.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "pianki_haribo.jpg", true, 0, "Pianki Haribo", 6.50m, 1 },
                    { 7, 43.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "cukierki_skittles.jpg", true, 0, "Cukierki Skittles", 4.50m, 1 },
                    { 6, 1.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "czekolada_wedel.jpg", true, 0, "Czekolada Wedel", 3.90m, 1 },
                    { 5, 10.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "czekolada_milka.jpg", true, 0, "Czekolada Milka", 4.10m, 1 },
                    { 4, 120.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "zelki_haribo.jpg", true, 0, "Żelki haribo", 5.10m, 1 },
                    { 3, 70.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "baton_snickers.jpg", true, 0, "Baton Snickers", 2.10m, 1 },
                    { 2, 60.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "milky_way.jpg", true, 0, "Baton MilkyWay", 1.90m, 1 },
                    { 1, 50.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "baton_mars.jpg", true, 0, "Baton Mars", 2.30m, 1 },
                    { 28, 3.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "wolowina.jpg", true, 1, "Wołowina", 40.30m, 5 },
                    { 29, 20.0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam hendrerit sagittis vulputate. Pellentesque pretium ipsum augue, at fringilla elit tempus in. Ut sagittis neque elit, nec interdum erat consectetur eu. Sed sollicitudin gravida vehicula. Cras suscipit magna eu pulvinar consequat. Donec lectus nibh, tempus sed vehicula a, vulputate ut justo. Mauris laoreet lorem dignissim, semper leo id, aliquam dolor. Nam id ligula pulvinar, pharetra odio sed, facilisis nibh. Mauris vehicula rutrum dolor, ac hendrerit libero hendrerit id.", "sok_pomaranzowy.jpg", true, 2, "Sok pomarańczowy", 6.30m, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "Id", "CartId", "ProductAmount", "ProductId", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, 1.0, 1, 0m },
                    { 4, 2, 1.0, 9, 0m },
                    { 3, 2, 3.0, 17, 0m },
                    { 6, 3, 3.0, 19, 0m },
                    { 5, 3, 1.0, 21, 0m },
                    { 7, 3, 2.0, 25, 0m },
                    { 2, 1, 2.0, 29, 0m }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "Message", "ProductId", "Rate", "RatingDate" },
                values: new object[,]
                {
                    { 1, "Bardzo dobre!", 1, 4, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, "Baton przeterminowany.", 1, 1, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "Super szybka dostawa!", 1, 5, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, "Pyszne", 2, 5, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CartId",
                table: "Order",
                column: "CartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_DeliveryId",
                table: "Order",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrdersHistoryId",
                table: "Order",
                column: "OrdersHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_CartId",
                table: "ProductInCart",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_ProductId",
                table: "ProductInCart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ProductId",
                table: "Rating",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "OrderHistory");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductCategory");
        }
    }
}
