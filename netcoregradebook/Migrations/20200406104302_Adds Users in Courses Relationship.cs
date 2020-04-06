using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoregradebook.Migrations
{
    public partial class AddsUsersinCoursesRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersInCourses",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInCourses", x => new { x.UserID, x.CourseId });
                    table.ForeignKey(
                        name: "FK_UsersInCourses_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersInCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersInCourses_AppUserId",
                table: "UsersInCourses",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersInCourses_CourseId",
                table: "UsersInCourses",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersInCourses");
        }
    }
}
