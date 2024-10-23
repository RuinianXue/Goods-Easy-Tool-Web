using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodsWebApp.Migrations
{
    /// <inheritdoc />
    public partial class hhhhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BatchToType",
                table: "BatchToType");

            migrationBuilder.DropColumn(
                name: "BatchTypeRelationID",
                table: "BatchToType");

            migrationBuilder.AlterColumn<int>(
                name: "GoodsBatchID",
                table: "BatchToType",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatchToType",
                table: "BatchToType",
                column: "GoodsBatchID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BatchToType",
                table: "BatchToType");

            migrationBuilder.AlterColumn<int>(
                name: "GoodsBatchID",
                table: "BatchToType",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BatchTypeRelationID",
                table: "BatchToType",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatchToType",
                table: "BatchToType",
                column: "BatchTypeRelationID");
        }
    }
}
