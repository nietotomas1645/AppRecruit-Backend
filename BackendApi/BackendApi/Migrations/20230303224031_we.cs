using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class we : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileRecord");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "FileRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileFormat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileRecord_jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "jobs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileRecord_JobId",
                table: "FileRecord",
                column: "JobId");
        }
    }
}
