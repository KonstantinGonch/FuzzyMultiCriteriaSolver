using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuzzyMultiCriteriaSolver.Migrations
{
    /// <inheritdoc />
    public partial class VariableDescriptionRemoveValueAndMFuncReferenceMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Variables");

            migrationBuilder.AddColumn<long>(
                name: "VariableId",
                table: "MembershipFunctions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_MembershipFunctions_VariableId",
                table: "MembershipFunctions",
                column: "VariableId");

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipFunctions_Variables_VariableId",
                table: "MembershipFunctions",
                column: "VariableId",
                principalTable: "Variables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembershipFunctions_Variables_VariableId",
                table: "MembershipFunctions");

            migrationBuilder.DropIndex(
                name: "IX_MembershipFunctions_VariableId",
                table: "MembershipFunctions");

            migrationBuilder.DropColumn(
                name: "VariableId",
                table: "MembershipFunctions");

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Variables",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
