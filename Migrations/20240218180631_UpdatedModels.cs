using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsPaper.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Physicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Physicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Physicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Physicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Physicals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Juridicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Juridicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Juridicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Juridicals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Juridicals",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Physicals");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Physicals");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Physicals");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Physicals");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Physicals");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Juridicals");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Juridicals");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Juridicals");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Juridicals");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Juridicals");
        }
    }
}
