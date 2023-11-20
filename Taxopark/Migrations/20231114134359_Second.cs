using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taxopark.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientStatus",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "Phonenumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Поджог", "88005553535", "Сараев" },
                    { 2, "Рулон", "+7903412343", "Обоев" }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Базовый" },
                    { 2, "Комфорт" },
                    { 3, "Экспресс" },
                    { 4, "С детьми" }
                });

            //migrationBuilder.InsertData(
            //    table: "Transports",
            //    columns: new[] { "Id", "Color", "DriverId", "IsSelling", "Mark", "Platenumber" },
            //    values: new object[,]
            //    {
            //        { 1, "черний", null, true, "2106", "а228уе779" },
            //        { 2, "Серебрянный", null, false, "Mondeo", "в666ор779" },
            //        { 3, "Белый", null, false, "Solaris", "к234пе30" }
            //    });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientName", "ClientPhonenumber", "From", "OrderStatus", "OrderTypeId", "Price", "To", "TransportId" },
                values: new object[,]
                {
                    { 1, "Иванов Иван Иванович", "+78234921342", "ул. Пушкина", 2, 3, 450.0, "дом Колотушкина", 3 },
                    { 2, "Петров Петр Петрович", "+78249278344", "ул. Пушкина", 3, 2, 600.0, "дом Колотушкина", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TransportId",
                table: "Orders",
                column: "TransportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Transports_TransportId",
                table: "Orders",
                column: "TransportId",
                principalTable: "Transports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Transports_TransportId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TransportId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "ClientStatus",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
