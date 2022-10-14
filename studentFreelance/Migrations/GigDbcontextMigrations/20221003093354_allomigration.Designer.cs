﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using studentFreelance.Models;

#nullable disable

namespace studentFreelance.Migrations.GigDbcontextMigrations
{
    [DbContext(typeof(GigDbcontext))]
    [Migration("20221003093354_allomigration")]
    partial class allomigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("studentFreelance.Models.Allocate", b =>
                {
                    b.Property<Guid>("allId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FRemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("deadline")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("dealDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("prID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("allId");

                    b.ToTable("allo");
                });

            modelBuilder.Entity("studentFreelance.Models.Bids", b =>
                {
                    b.Property<Guid>("bid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FRemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("deadline")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("prID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("bid");

                    b.ToTable("bids");
                });

            modelBuilder.Entity("studentFreelance.Models.Gig", b =>
                {
                    b.Property<int>("gidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gidId"), 1L, 1);

                    b.Property<string>("amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("gidId");

                    b.ToTable("gig");
                });
#pragma warning restore 612, 618
        }
    }
}
