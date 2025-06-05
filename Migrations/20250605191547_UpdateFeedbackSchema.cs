using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedBackService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFeedbackSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Feedbacks");

            migrationBuilder.RenameColumn(
                name: "EventTitle",
                table: "Feedbacks",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Feedbacks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Feedbacks");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Feedbacks",
                newName: "EventTitle");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Feedbacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
