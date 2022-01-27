using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4_Higbee.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieSubmissionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_to = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieSubmissionId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieSubmissionId", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Family", "Chris Buck and Jennifer Lee", false, "", "", "PG", "Frozen", 2013 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieSubmissionId", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Joe and Anthony Russo", false, "", "", "PG-13", "Captain America: The Winter Soldier", 2014 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieSubmissionId", "Category", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Haruo Sotozaki", false, "", "", "R", "Demon Slayer: Mugen Train", 2020 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
