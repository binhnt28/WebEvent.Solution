using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Innitial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_Eventid",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Eventid",
                table: "Tickets",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_Eventid",
                table: "Tickets",
                newName: "IX_Tickets_EventId");

            migrationBuilder.AlterColumn<Guid>(
                name: "EventId",
                table: "Tickets",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "website",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5c3b126f-b1e5-4e2b-a83b-34e27ff8ca46");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a855852d-7952-411d-bc1e-edb2cd4a1e60", "AQAAAAEAACcQAAAAEFyzCjUhjgghc5elvYNjHjucxu0NHz2xORkLGCZ51bGaK0sFJUluJWKP4XsM5QSpBg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Tickets",
                newName: "Eventid");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                newName: "IX_Tickets_Eventid");

            migrationBuilder.AlterColumn<Guid>(
                name: "Eventid",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "website",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "561fd4a0-6f3a-4b39-8a71-662a8edfd7c5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03ecdc98-068f-4f31-9dd1-6475eecd0fb8", "AQAAAAEAACcQAAAAENdgFwsNkwrkqy1zjXSZj5LcQTjVRcggRYc7q9el59NFQjcsH8npk1eYC+iHfLIqbQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_Eventid",
                table: "Tickets",
                column: "Eventid",
                principalTable: "Events",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
