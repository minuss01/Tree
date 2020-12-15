using Microsoft.EntityFrameworkCore.Migrations;

namespace Tree.DB.Migrations
{
    public partial class addedNodeTypeEnumtocompositeandleafentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Leaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Composities",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Composities");
        }
    }
}
