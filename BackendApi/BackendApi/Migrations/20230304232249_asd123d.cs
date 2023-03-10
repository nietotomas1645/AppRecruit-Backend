using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class asd123d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileDatas_jobs_JobId",
                table: "FileDatas");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "FileDatas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FileDatas_jobs_JobId",
                table: "FileDatas",
                column: "JobId",
                principalTable: "jobs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileDatas_jobs_JobId",
                table: "FileDatas");

            migrationBuilder.AlterColumn<int>(
                name: "JobId",
                table: "FileDatas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FileDatas_jobs_JobId",
                table: "FileDatas",
                column: "JobId",
                principalTable: "jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
