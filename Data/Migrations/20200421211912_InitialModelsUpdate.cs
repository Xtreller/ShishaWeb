using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.net_Core_Project.Data.Migrations
{
    public partial class InitialModelsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bars_AspNetUsers_UserId",
                table: "Bars");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Bars_BarIdId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BarIdId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BarIdId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "BarId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Comments",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Bars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Bars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Bars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Bars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Bars",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Bars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BarId",
                table: "Comments",
                column: "BarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bars_AspNetUsers_UserId",
                table: "Bars",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Bars_BarId",
                table: "Comments",
                column: "BarId",
                principalTable: "Bars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bars_AspNetUsers_UserId",
                table: "Bars");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Bars_BarId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BarId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BarId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Bars");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Bars");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bars");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Bars");

            migrationBuilder.AddColumn<int>(
                name: "BarIdId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bars",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Bars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Bars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Bars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BarIdId",
                table: "Comments",
                column: "BarIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bars_AspNetUsers_UserId",
                table: "Bars",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Bars_BarIdId",
                table: "Comments",
                column: "BarIdId",
                principalTable: "Bars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
