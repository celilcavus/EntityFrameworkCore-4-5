using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore_4_5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Islems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    KitapId = table.Column<int>(type: "int", nullable: false),
                    KitapAlinmaTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KitapVerilisTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    YazarSoyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OgrenciSoyad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Sinif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IslemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Islems_IslemId",
                        column: x => x.IslemId,
                        principalTable: "Islems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kitaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemId = table.Column<int>(type: "int", nullable: false),
                    KitapAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TurId = table.Column<int>(type: "int", nullable: false),
                    SayfaSayisi = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Puan = table.Column<short>(type: "smallint", nullable: false),
                    YazarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitaps_Islems_IslemId",
                        column: x => x.IslemId,
                        principalTable: "Islems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaps_Yazars_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KitapId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turs_Kitaps_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_IslemId",
                table: "Kitaps",
                column: "IslemId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_YazarId",
                table: "Kitaps",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_IslemId",
                table: "Ogrencis",
                column: "IslemId");

            migrationBuilder.CreateIndex(
                name: "IX_Turs_KitapId",
                table: "Turs",
                column: "KitapId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Turs");

            migrationBuilder.DropTable(
                name: "Kitaps");

            migrationBuilder.DropTable(
                name: "Islems");

            migrationBuilder.DropTable(
                name: "Yazars");
        }
    }
}
