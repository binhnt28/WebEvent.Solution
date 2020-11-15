using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Innitial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AppUsers_nguoidatId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_nguoidatId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "nguoidatId",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "twitterhashtag",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sukien",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nhatochuc",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nguoiphutrach",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "muigio",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "eventprogram",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "diadiem",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "congty",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "chuyenmuc",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TicketId",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4bbdb00d-9e08-409a-919a-a4e308a4f4a4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "FullName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "191567ee-c70e-4e73-a99f-e3a3d1cd2ac4", "binhnt@gmail.com", "Bình", "Nguyễn Thanh Bình", "Nguyễn Thanh", "BINHNT@GMAIL.COM", "AQAAAAEAACcQAAAAEDFIORJ5WZgd1Q0U58fvjFU4eQZ8z29wiWtxzmOlPXpXkLVaXfGodilmhUox/Ql6Kg==" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_TicketId",
                table: "AppUsers",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Tickets_TicketId",
                table: "AppUsers",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Tickets_TicketId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_TicketId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "AppUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "nguoidatId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "twitterhashtag",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "sukien",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "nhatochuc",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "nguoiphutrach",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "muigio",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "eventprogram",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "diadiem",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "congty",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "chuyenmuc",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "abbadd63-865b-4ecd-a157-9da6fe86ec55");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "FullName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "48e922d5-4d50-4976-8e56-7279f835b37b", "quochieu@gmail.com", "Hiếu", "Hồ Quốc Hiếu", "Hồ Quốc", "QUOCHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEHZl3TaFyef7BANjZbCBMi+zRXBONqSc8K5uac1SS8yNv4oSZ4OiIDbFLEqgv768ew==" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_nguoidatId",
                table: "Tickets",
                column: "nguoidatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AppUsers_nguoidatId",
                table: "Tickets",
                column: "nguoidatId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
