﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using studentFreelance.Models;

#nullable disable

namespace studentFreelance.Migrations.ClientDBcontextMigrations
{
    [DbContext(typeof(ClientDBcontext))]
    [Migration("20220916062015_thirdMigration")]
    partial class thirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("studentFreelance.Models.Client", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("phno")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("email");

                    b.ToTable("client");
                });
#pragma warning restore 612, 618
        }
    }
}