using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodsWebApp.Migrations
{
    /// <inheritdoc />
    public partial class GoodsDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BatchToType",
                columns: table => new
                {
                    GoodsBatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchToType", x => x.GoodsBatchID);
                });

            migrationBuilder.CreateTable(
                name: "BlockList",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonePicURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockList", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    CharacterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HotPriority = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.CharacterID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterPriority",
                columns: table => new
                {
                    CharacterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PriorityGrade = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ForcePercent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterPriority", x => x.CharacterID);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryCheckList",
                columns: table => new
                {
                    deliveryUniqueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DeliveryRequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ListPicURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckDeliveryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCheckList", x => x.deliveryUniqueID);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    GoodsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsTypeID = table.Column<int>(type: "int", nullable: false),
                    GoodsCharacter = table.Column<int>(type: "int", nullable: false),
                    GoodsCountEqual = table.Column<int>(type: "int", nullable: false),
                    GoodsBoundEqual = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.GoodsID);
                });

            migrationBuilder.CreateTable(
                name: "GoodsBatch",
                columns: table => new
                {
                    GoodsBatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsBatchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoodsBeginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GoodsEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryStatus = table.Column<int>(type: "int", nullable: false),
                    SharedDiscount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsBatch", x => x.GoodsBatchID);
                });

            migrationBuilder.CreateTable(
                name: "GoodsType",
                columns: table => new
                {
                    GoodsTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceInTotal = table.Column<int>(type: "int", nullable: true),
                    LimitAmount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsType", x => x.GoodsTypeID);
                });

            migrationBuilder.CreateTable(
                name: "MoneyCheckList",
                columns: table => new
                {
                    moneyUniqueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    BatchID = table.Column<int>(type: "int", nullable: false),
                    PayPicURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckMoneyStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyCheckList", x => x.moneyUniqueID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    BatchID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    CharacterID = table.Column<int>(type: "int", nullable: false),
                    OrderAmount = table.Column<int>(type: "int", nullable: false),
                    SpecialStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "PromoteCheckList",
                columns: table => new
                {
                    promoteUniqueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    BatchID = table.Column<int>(type: "int", nullable: false),
                    SharePicURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckPromoteStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoteCheckList", x => x.promoteUniqueID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatchToType");

            migrationBuilder.DropTable(
                name: "BlockList");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "CharacterPriority");

            migrationBuilder.DropTable(
                name: "DeliveryCheckList");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "GoodsBatch");

            migrationBuilder.DropTable(
                name: "GoodsType");

            migrationBuilder.DropTable(
                name: "MoneyCheckList");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PromoteCheckList");
        }
    }
}
