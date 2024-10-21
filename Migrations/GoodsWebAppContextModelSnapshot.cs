﻿// <auto-generated />
using System;
using GoodsWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoodsWebApp.Migrations
{
    [DbContext(typeof(GoodsWebAppContext))]
    partial class GoodsWebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoodsWebApp.Models.BatchToType", b =>
                {
                    b.Property<int>("GoodsBatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodsBatchID"));

                    b.Property<int>("GoodsTypeID")
                        .HasColumnType("int");

                    b.HasKey("GoodsBatchID");

                    b.ToTable("BatchToType");
                });

            modelBuilder.Entity("GoodsWebApp.Models.BlockList", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("DonePicURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("BlockList");
                });

            modelBuilder.Entity("GoodsWebApp.Models.Character", b =>
                {
                    b.Property<string>("CharacterID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("HotPriority")
                        .HasColumnType("int");

                    b.HasKey("CharacterID");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("GoodsWebApp.Models.CharacterPriority", b =>
                {
                    b.Property<string>("CharacterID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ForcePercent")
                        .HasColumnType("int");

                    b.Property<int>("PriorityGrade")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CharacterID");

                    b.ToTable("CharacterPriority");
                });

            modelBuilder.Entity("GoodsWebApp.Models.DeliveryCheckList", b =>
                {
                    b.Property<int>("deliveryUniqueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("deliveryUniqueID"));

                    b.Property<int>("CheckDeliveryStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryRequestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListPicURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("deliveryUniqueID");

                    b.ToTable("DeliveryCheckList");
                });

            modelBuilder.Entity("GoodsWebApp.Models.Goods", b =>
                {
                    b.Property<int>("GoodsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodsID"));

                    b.Property<int>("GoodsBoundEqual")
                        .HasColumnType("int");

                    b.Property<int>("GoodsCharacter")
                        .HasColumnType("int");

                    b.Property<int>("GoodsCountEqual")
                        .HasColumnType("int");

                    b.Property<int>("GoodsTypeID")
                        .HasColumnType("int");

                    b.HasKey("GoodsID");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("GoodsWebApp.Models.GoodsBatch", b =>
                {
                    b.Property<int>("GoodsBatchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodsBatchID"));

                    b.Property<int>("DeliveryStatus")
                        .HasColumnType("int");

                    b.Property<string>("GoodsBatchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GoodsBeginTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GoodsEndTime")
                        .HasColumnType("datetime2");

                    b.Property<float>("SharedDiscount")
                        .HasColumnType("real");

                    b.HasKey("GoodsBatchID");

                    b.ToTable("GoodsBatch");
                });

            modelBuilder.Entity("GoodsWebApp.Models.GoodsType", b =>
                {
                    b.Property<int>("GoodsTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodsTypeID"));

                    b.Property<string>("GoodsTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LimitAmount")
                        .HasColumnType("int");

                    b.Property<int?>("PriceInTotal")
                        .HasColumnType("int");

                    b.HasKey("GoodsTypeID");

                    b.ToTable("GoodsType");
                });

            modelBuilder.Entity("GoodsWebApp.Models.MoneyCheckList", b =>
                {
                    b.Property<int>("moneyUniqueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("moneyUniqueID"));

                    b.Property<int>("BatchID")
                        .HasColumnType("int");

                    b.Property<int>("CheckMoneyStatus")
                        .HasColumnType("int");

                    b.Property<string>("PayPicURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("moneyUniqueID");

                    b.ToTable("MoneyCheckList");
                });

            modelBuilder.Entity("GoodsWebApp.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("BatchID")
                        .HasColumnType("int");

                    b.Property<int>("CharacterID")
                        .HasColumnType("int");

                    b.Property<int>("OrderAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SpecialStatus")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("GoodsWebApp.Models.PromoteCheckList", b =>
                {
                    b.Property<int>("promoteUniqueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("promoteUniqueID"));

                    b.Property<int>("BatchID")
                        .HasColumnType("int");

                    b.Property<int>("CheckPromoteStatus")
                        .HasColumnType("int");

                    b.Property<string>("SharePicURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("promoteUniqueID");

                    b.ToTable("PromoteCheckList");
                });

            modelBuilder.Entity("GoodsWebApp.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<int>("Authority")
                        .HasColumnType("int");

                    b.Property<string>("CN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QQ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
