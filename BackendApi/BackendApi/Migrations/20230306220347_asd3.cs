using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class asd3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileDatas_jobs_JobId",
                table: "FileDatas");

            migrationBuilder.DropIndex(
                name: "IX_FileDatas_JobId",
                table: "FileDatas");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "FileDatas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "FileDatas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileDatas_JobId",
                table: "FileDatas",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileDatas_jobs_JobId",
                table: "FileDatas",
                column: "JobId",
                principalTable: "jobs",
                principalColumn: "Id");
        }
    }
}
