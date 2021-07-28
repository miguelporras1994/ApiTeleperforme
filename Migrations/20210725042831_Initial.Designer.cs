﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teleperforme;

namespace Teleperforme.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20210725042831_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Teleperforme.Models.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E_mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_last")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Identification")
                        .HasColumnType("int");

                    b.Property<int>("Identification_number")
                        .HasColumnType("int");

                    b.Property<string>("Second_last")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Second_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Businnes");
                });
#pragma warning restore 612, 618
        }
    }
}
