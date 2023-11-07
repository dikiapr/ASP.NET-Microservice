using Microsoft.EntityFrameworkCore.Migrations;

namespace UserService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IntegrationEventOutbox",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegrationEventOutbox", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Mail", "Name", "OtherData", "Version" },
                values: new object[] { 1, "Hastings", "John", "John@pragimtech.com", 0 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Mail", "Name", "OtherData", "Version" },
                values: new object[] { 2, "Erron", "Roxy", "Roxy@pragimtech.com", 0 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Mail", "Name", "OtherData", "Version" },
                values: new object[] { 3, "Heios", "Firo", "firo@pragimtech.com", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntegrationEventOutbox");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
