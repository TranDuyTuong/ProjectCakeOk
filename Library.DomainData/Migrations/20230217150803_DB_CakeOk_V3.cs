using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.DomainData.Migrations
{
    public partial class DB_CakeOk_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ContentFile",
                table: "T_Staffs",
                type: "BLOB",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(30000)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ContentFile",
                table: "T_Staffs",
                type: "varbinary(30000)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "BLOB");
        }
    }
}
