using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjMVCCore23082021.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Venda_VendaId",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_VendaId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Venda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ClientId",
                table: "Venda",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Client_ClientId",
                table: "Venda",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Client_ClientId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ClientId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Venda");

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_VendaId",
                table: "Client",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Venda_VendaId",
                table: "Client",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
