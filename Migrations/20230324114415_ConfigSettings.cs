using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore_4_5.Migrations
{
    /// <inheritdoc />
    public partial class ConfigSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KitapAdi",
                table: "Kitaps",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "Kitap Adi yok",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "KitapVerilisTarih",
                table: "Islems",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "DATEADD(DAY,7,getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KitapAlinmaTarih",
                table: "Islems",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KitapAdi",
                table: "Kitaps",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValue: "Kitap Adi yok");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KitapVerilisTarih",
                table: "Islems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "DATEADD(DAY,7,getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "KitapAlinmaTarih",
                table: "Islems",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");
        }
    }
}
