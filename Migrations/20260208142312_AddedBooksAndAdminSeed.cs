using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodVeda_FullStack_Intern.Migrations
{
    /// <inheritdoc />
    public partial class AddedBooksAndAdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "IsHidden", "PublishDate", "Publisher", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, false, "2024", "CodVeda Press", "The comprehensive history of how the BookFlow library management system was developed during the internship.", "BookFlow History" },
                    { 2, false, "2023", "University Press", "Exploring the digital transformation of student connections and resource sharing in academic environments.", "UfsConnectBook History" },
                    { 3, false, "2025", "Tech Pioneers Publishing", "A deep dive into the journey of Lindele Nyambe, focusing on software engineering milestones and future visions.", "Lindele's History" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "Password" },
                values: new object[] { 1, "admin@gmail.com", "System Admin", "&0137Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
