using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Web.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class Gorev10Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageContext",
                table: "Page",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "Page",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserSurname" },
                values: new object[] { "Teo@xyz.com", "Teoman", "Teo", "Yakupoğlu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageContext",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "Page");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserSurname" },
                values: new object[] { "oguzkagan@xyz.com", "Oğuzkağan", "Ogz", "Fındık" });
        }
    }
}
