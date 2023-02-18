using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.DomainData.Migrations
{
    public partial class DB_CakeOk_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ContentFile",
                table: "T_Staffs",
                type: "binary",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContentFile",
                table: "T_Staffs",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte[]),
                oldType: "binary",
                oldNullable: true);
        }
    }
}
