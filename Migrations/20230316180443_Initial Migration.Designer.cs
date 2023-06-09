﻿// <auto-generated />
using System;
using MasterDetails.Models.DemoDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MasterDetails.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20230316180443_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MasterDetails.Models.Purchase", b =>
                {
                    b.Property<long>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PurchaseId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EntryBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("MasterDetails.Models.PurchaseDetails", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ItemCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("ItemQty")
                        .HasColumnType("real");

                    b.Property<float>("ItemRate")
                        .HasColumnType("real");

                    b.Property<float>("ItemUnitId")
                        .HasColumnType("real");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<long>("PurchaseId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseId1");

                    b.ToTable("PurchaseDetailss");
                });

            modelBuilder.Entity("MasterDetails.Models.PurchaseDetails", b =>
                {
                    b.HasOne("MasterDetails.Models.Purchase", "Purchase")
                        .WithMany("PurchaseDetails")
                        .HasForeignKey("PurchaseId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("MasterDetails.Models.Purchase", b =>
                {
                    b.Navigation("PurchaseDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
