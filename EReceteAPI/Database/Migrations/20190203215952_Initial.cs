using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EReceteAPI.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Skrs");

            migrationBuilder.EnsureSchema(
                name: "Muayene");

            migrationBuilder.EnsureSchema(
                name: "Yetkilendirme");

            migrationBuilder.CreateTable(
                name: "Recete",
                schema: "Muayene",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedKurumKodu = table.Column<int>(nullable: true),
                    UpdatedKurumKodu = table.Column<int>(nullable: true),
                    RowGuid = table.Column<string>(maxLength: 36, nullable: true),
                    CreatedRoleId = table.Column<long>(nullable: true),
                    UpdatedRoleId = table.Column<long>(nullable: true),
                    ReceteTarih = table.Column<DateTime>(nullable: true),
                    ReceteNo = table.Column<string>(nullable: true),
                    ReceteTuru = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recete", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Yetkilendirme",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 255, nullable: true),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    TCKimlikNo = table.Column<long>(nullable: false),
                    Ad = table.Column<string>(maxLength: 255, nullable: true),
                    Soyad = table.Column<string>(maxLength: 255, nullable: true),
                    DiplomaNo = table.Column<string>(maxLength: 255, nullable: true),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    ESaglikPassword = table.Column<string>(maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 255, nullable: true),
                    SGKSifresi = table.Column<string>(maxLength: 255, nullable: true),
                    MernisSifresi = table.Column<string>(maxLength: 255, nullable: true),
                    CepTelefonu = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ilac",
                schema: "Skrs",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(maxLength: 255, nullable: true),
                    Barkod = table.Column<long>(nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    GeriOdeme = table.Column<int>(nullable: true),
                    ReceteTuru = table.Column<int>(nullable: true),
                    FirmaAd = table.Column<string>(maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    AtcKod = table.Column<string>(maxLength: 255, nullable: true),
                    AtcAd = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedKurumKodu = table.Column<int>(nullable: true),
                    UpdatedKurumKodu = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SessionId = table.Column<string>(maxLength: 36, nullable: true),
                    AdArama = table.Column<string>(maxLength: 500, nullable: true),
                    RowGuid = table.Column<string>(maxLength: 36, nullable: true),
                    UpdatedSessionId = table.Column<string>(maxLength: 36, nullable: true),
                    CreatedRoleId = table.Column<long>(nullable: true),
                    UpdatedRoleId = table.Column<long>(nullable: true),
                    IlacReceteRengi = table.Column<int>(nullable: true),
                    ReceteID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilac", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ilac_Recete_ReceteID",
                        column: x => x.ReceteID,
                        principalSchema: "Muayene",
                        principalTable: "Recete",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilac_ReceteID",
                schema: "Skrs",
                table: "Ilac",
                column: "ReceteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ilac",
                schema: "Skrs");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Yetkilendirme");

            migrationBuilder.DropTable(
                name: "Recete",
                schema: "Muayene");
        }
    }
}
