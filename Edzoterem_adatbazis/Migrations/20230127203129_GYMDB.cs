using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Edzoteremadatbazis.Migrations
{
    /// <inheritdoc />
    public partial class GYMDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maganedzok",
                columns: table => new
                {
                    MaganedzoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaganedzoNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaganedzoTagokSzama = table.Column<int>(name: "MaganedzoTagok_Szama", type: "int", nullable: false),
                    MaganedzoEdzesProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maganedzok", x => x.MaganedzoID);
                });

            migrationBuilder.CreateTable(
                name: "Recepciosok",
                columns: table => new
                {
                    RecepciosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecepciosNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecepciosNorma = table.Column<int>(type: "int", nullable: false),
                    RecepciosProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepciosok", x => x.RecepciosID);
                });

            migrationBuilder.CreateTable(
                name: "Tagsagok",
                columns: table => new
                {
                    TagsagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagsagTipus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tagsagok", x => x.TagsagID);
                });

            migrationBuilder.CreateTable(
                name: "Takaritok",
                columns: table => new
                {
                    TakaritoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakaritoNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TakaritoNorma = table.Column<int>(type: "int", nullable: false),
                    TakaritoProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takaritok", x => x.TakaritoID);
                });

            migrationBuilder.CreateTable(
                name: "Tagok",
                columns: table => new
                {
                    TagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TagMagassag = table.Column<int>(type: "int", nullable: false),
                    TagsagID = table.Column<int>(type: "int", nullable: false),
                    MagandedzoID = table.Column<int>(type: "int", nullable: false),
                    TagSzekrenySzam = table.Column<int>(name: "Tag_SzekrenySzam", type: "int", nullable: false),
                    Taglejaratidatum = table.Column<DateTime>(name: "Tag_lejarati_datum", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tagok", x => x.TagID);
                    table.ForeignKey(
                        name: "FK_Tagok_Tagsagok_TagsagID",
                        column: x => x.TagsagID,
                        principalTable: "Tagsagok",
                        principalColumn: "TagsagID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tagok_TagsagID",
                table: "Tagok",
                column: "TagsagID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maganedzok");

            migrationBuilder.DropTable(
                name: "Recepciosok");

            migrationBuilder.DropTable(
                name: "Tagok");

            migrationBuilder.DropTable(
                name: "Takaritok");

            migrationBuilder.DropTable(
                name: "Tagsagok");
        }
    }
}
