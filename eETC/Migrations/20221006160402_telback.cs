﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace eETC.Migrations
{
    public partial class telback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NrTel",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NrTel",
                table: "Orders");
        }
    }
}
