using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxopark.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Drivers_DriverId",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "IdDriver",
                table: "Transports");

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Transports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 1,
                column: "DriverId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 2,
                column: "DriverId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 3,
                column: "DriverId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Drivers_DriverId",
                table: "Transports",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Drivers_DriverId",
                table: "Transports");

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Transports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdDriver",
                table: "Transports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DriverId", "IdDriver" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DriverId", "IdDriver" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Transports",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DriverId", "IdDriver" },
                values: new object[] { null, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Drivers_DriverId",
                table: "Transports",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id");
        }
    }
}
