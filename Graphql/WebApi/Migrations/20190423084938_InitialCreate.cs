using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Company", "Email", "LongDescription", "Mobile", "Name", "ShortDescription" },
                values: new object[] { 1L, "Bangalore", "Siemens", "sonalisingh7639@gmail.com", "shutterstock_66842440.jpg", "8851490003", "Sonali singh", "Hi" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Company", "Email", "LongDescription", "Mobile", "Name", "ShortDescription" },
                values: new object[] { 2L, "Bangalore1", "Siemens1", "sonalisingh7639@gmail.com1", "shutterstock_66842440.jpg1", "88514900031", "Mountain Walkers", "Hi1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
