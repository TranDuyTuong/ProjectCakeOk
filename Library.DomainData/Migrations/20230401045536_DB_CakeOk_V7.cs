using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Library.DomainData.Migrations
{
    public partial class DB_CakeOk_V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_CheckLoginLogouts",
                columns: table => new
                {
                    WorkingStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDStaff = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    DateStart = table.Column<string>(type: "text", nullable: false),
                    TimeStart = table.Column<string>(type: "text", nullable: false),
                    WorkingEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateEnd = table.Column<string>(type: "text", nullable: true),
                    TimeEnd = table.Column<string>(type: "text", nullable: true),
                    HourWoking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CheckLoginLogouts", x => x.WorkingStart);
                });

            migrationBuilder.CreateTable(
                name: "T_TokenLogins",
                columns: table => new
                {
                    IDToken = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TokenString = table.Column<string>(type: "text", nullable: false),
                    EmailLogin = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TokenLogins", x => x.IDToken);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_CheckLoginLogouts");

            migrationBuilder.DropTable(
                name: "T_TokenLogins");
        }
    }
}
