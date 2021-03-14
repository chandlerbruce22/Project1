using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourGroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TourName = table.Column<string>(nullable: false),
                    TourSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourGroupId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
