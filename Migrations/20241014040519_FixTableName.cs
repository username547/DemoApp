using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApp.Migrations
{
    /// <inheritdoc />
    public partial class FixTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatuseUpdates_Services_ServiceId",
                table: "StatuseUpdates");

            migrationBuilder.DropForeignKey(
                name: "FK_StatuseUpdates_Statuses_StatusId",
                table: "StatuseUpdates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatuseUpdates",
                table: "StatuseUpdates");

            migrationBuilder.RenameTable(
                name: "StatuseUpdates",
                newName: "StatusUpdates");

            migrationBuilder.RenameIndex(
                name: "IX_StatuseUpdates_StatusId",
                table: "StatusUpdates",
                newName: "IX_StatusUpdates_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_StatuseUpdates_ServiceId",
                table: "StatusUpdates",
                newName: "IX_StatusUpdates_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusUpdates",
                table: "StatusUpdates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatusUpdates_Services_ServiceId",
                table: "StatusUpdates",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatusUpdates_Statuses_StatusId",
                table: "StatusUpdates",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatusUpdates_Services_ServiceId",
                table: "StatusUpdates");

            migrationBuilder.DropForeignKey(
                name: "FK_StatusUpdates_Statuses_StatusId",
                table: "StatusUpdates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusUpdates",
                table: "StatusUpdates");

            migrationBuilder.RenameTable(
                name: "StatusUpdates",
                newName: "StatuseUpdates");

            migrationBuilder.RenameIndex(
                name: "IX_StatusUpdates_StatusId",
                table: "StatuseUpdates",
                newName: "IX_StatuseUpdates_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_StatusUpdates_ServiceId",
                table: "StatuseUpdates",
                newName: "IX_StatuseUpdates_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatuseUpdates",
                table: "StatuseUpdates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatuseUpdates_Services_ServiceId",
                table: "StatuseUpdates",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StatuseUpdates_Statuses_StatusId",
                table: "StatuseUpdates",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
