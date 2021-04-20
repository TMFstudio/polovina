using Microsoft.EntityFrameworkCore.Migrations;

namespace CharityAccounts.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCharityAccounts",
                columns: table => new
                {
                    CharityAccountId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCharityAccounts", x => x.CharityAccountId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCharityAccounts",
                table: "tblCharityAccounts",
                column: "AccountNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCharityAccounts");
        }
    }
}
