using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Data.Migrations
{
    public partial class Innitial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    TicketId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.id);
                    table.ForeignKey(
                        name: "FK_Participants_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a237f478-a709-4e71-858e-99096ec10b82");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e98ab06-ea52-4ea2-ba24-ff6ff6c9c63c", "AQAAAAEAACcQAAAAEAeqALVngmRFhJRtKwqGybrFkFwCrdv82tRh1euyg+KCrzHyCG6f0xq4TyvzSciWbQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_TicketId",
                table: "Participants",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_UserId",
                table: "Participants",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.AddColumn<Guid>(
                name: "TicketId",
                table: "AppUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3829b2df-1af6-4d83-9575-71e97ab42b3a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a788250-8c2a-4f6c-86d4-70a930c44eca", "AQAAAAEAACcQAAAAELmv1xjo0OQNA9vJJ6iO8jsrlzfGZpeA/+l/nO6YEjWlJWjwwL/1Z9c3PLQpZ0xwTQ==" });

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
    }
}
