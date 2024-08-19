using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SpicyWorld.Migrations
{
    /// <inheritdoc />
    public partial class seedCategoriesChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A gentle touch of spice for those who prefer a subtle flavor.", "Mild" });

            migrationBuilder.UpdateData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A balanced level of spice that adds a bit of heat without overwhelming.", "Medium" });

            migrationBuilder.UpdateData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "For those who enjoy a strong kick of spice that packs a punch.", "Hot" });

            migrationBuilder.InsertData(
                table: "Categoiries",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 4, "Intense heat for spice lovers who crave a fiery experience.", 4, "Extra Hot" },
                    { 5, "A blazing level of spice that challenges even the bravest.", 5, "Super Spicy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "", "Green" });

            migrationBuilder.UpdateData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "", "Red" });

            migrationBuilder.UpdateData(
                table: "Categoiries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "", "Grey" });
        }
    }
}
