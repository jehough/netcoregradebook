using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoregradebook.Migrations
{
    public partial class AddsUserAssignmentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignmentsForStudents",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    AssignmentId = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentsForStudents", x => new { x.UserId, x.AssignmentId });
                    table.ForeignKey(
                        name: "FK_AssignmentsForStudents_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignmentsForStudents_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentsForStudents_AppUserId",
                table: "AssignmentsForStudents",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentsForStudents_AssignmentId",
                table: "AssignmentsForStudents",
                column: "AssignmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentsForStudents");
        }
    }
}
