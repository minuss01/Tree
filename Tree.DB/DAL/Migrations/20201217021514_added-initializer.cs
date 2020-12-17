using Microsoft.EntityFrameworkCore.Migrations;

namespace Tree.DB.Migrations
{
    public partial class addedinitializer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name", "NodeParentId" },
                values: new object[] { 1, "Node1", null });

            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name", "NodeParentId" },
                values: new object[] { 5, "Node5", null });

            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name", "NodeParentId" },
                values: new object[,]
                {
                    { 2, "Node2", 1 },
                    { 3, "Node3", 1 },
                    { 4, "Node4", 1 },
                    { 6, "Node6", 5 },
                    { 7, "Node7", 5 }
                });

            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name", "NodeParentId" },
                values: new object[] { 8, "Node8", 2 });

            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name", "NodeParentId" },
                values: new object[] { 10, "Node10", 6 });

            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name", "NodeParentId" },
                values: new object[] { 9, "Node9", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
