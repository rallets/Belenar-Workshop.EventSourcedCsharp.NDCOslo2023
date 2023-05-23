﻿// <auto-generated />
using System;
using BeerSender.Web.ReadStore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeerSender.Web.Migrations.Read_contextMigrations
{
    [DbContext(typeof(Read_context))]
    [Migration("20230523113545_Add_checkpoints")]
    partial class Add_checkpoints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeerSender.Web.ReadStore.Box_bottle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("Box_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brewery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Percentage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Box_id");

                    b.ToTable("Bottles");
                });

            modelBuilder.Entity("BeerSender.Web.ReadStore.Box_status", b =>
                {
                    b.Property<Guid>("Aggregate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Carrier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tracking_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Aggregate_id");

                    b.ToTable("Boxes");
                });

            modelBuilder.Entity("BeerSender.Web.ReadStore.Checkpoint", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar");

                    b.Property<byte[]>("Last_timestamp")
                        .IsRequired()
                        .HasColumnType("binary(8)");

                    b.HasKey("Name");

                    b.ToTable("Checkpoints");
                });

            modelBuilder.Entity("BeerSender.Web.ReadStore.Box_bottle", b =>
                {
                    b.HasOne("BeerSender.Web.ReadStore.Box_status", "Box")
                        .WithMany("Bottles")
                        .HasForeignKey("Box_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Box");
                });

            modelBuilder.Entity("BeerSender.Web.ReadStore.Box_status", b =>
                {
                    b.Navigation("Bottles");
                });
#pragma warning restore 612, 618
        }
    }
}
