using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpicyRazorTemp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoiries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categoiries",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, "A gentle touch of spice for those who prefer a subtle flavor.", 1, "Mild" },
                    { 2, "A balanced level of spice that adds a bit of heat without overwhelming.", 2, "Medium" },
                    { 3, "For those who enjoy a strong kick of spice that packs a punch.", 3, "Hot" },
                    { 4, "Intense heat for spice lovers who crave a fiery experience.", 4, "Extra Hot" },
                    { 5, "A blazing level of spice that challenges even the bravest.", 5, "Super Spicy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoiries");
        }
    }
}
