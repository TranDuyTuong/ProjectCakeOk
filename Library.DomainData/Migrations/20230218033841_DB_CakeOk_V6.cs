using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.DomainData.Migrations
{
    public partial class DB_CakeOk_V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ContentFile",
                table: "T_Staffs",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "binary",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ContentFile",
                table: "T_Staffs",
                type: "binary",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);
        }
    }
}
