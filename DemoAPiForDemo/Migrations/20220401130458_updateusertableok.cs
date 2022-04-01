using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoAPiForDemo.Migrations
{
    public partial class updateusertableok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamLeader_Name",
                table: "Tbl_Team_Leader_Master");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamLeader_Name",
                table: "Tbl_Team_Leader_Master",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
