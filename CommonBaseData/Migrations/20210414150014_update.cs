using Microsoft.EntityFrameworkCore.Migrations;

namespace CommonBaseData.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCommonBaseData",
                columns: table => new
                {
                    CommonBaseDataId = table.Column<int>(type: "int", nullable: false),
                    BaseCode = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    BaseValue = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true),
                    CommonBaseTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCommonBaseData", x => x.CommonBaseDataId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBaseCode",
                table: "tblCommonBaseData",
                columns: new[] { "BaseCode", "CommonBaseTypeId" },
                unique: true,
                filter: "[BaseCode] IS NOT NULL AND [CommonBaseTypeId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCommonBaseData");
        }
    }
}
