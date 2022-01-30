using Microsoft.EntityFrameworkCore.Migrations;

namespace RESTApi_EFCore.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LibelleQuestion = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "LibelleQuestion" },
                values: new object[] { 1, "Question1" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "LibelleQuestion" },
                values: new object[] { 2, "Question2" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "LibelleQuestion" },
                values: new object[] { 3, "Question3" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "LibelleQuestion" },
                values: new object[] { 4, "Question4" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "LibelleQuestion" },
                values: new object[] { 5, "Question5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
