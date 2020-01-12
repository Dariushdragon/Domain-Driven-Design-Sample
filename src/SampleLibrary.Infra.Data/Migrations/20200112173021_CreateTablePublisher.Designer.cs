﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleLibrary.Infra.Data.Context;

namespace SampleLibrary.Infra.Data.Migrations
{
    [DbContext(typeof(SampleLibraryContext))]
    [Migration("20200112173021_CreateTablePublisher")]
    partial class CreateTablePublisher
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleLibrary.Domain.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("SampleLibrary.Domain.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });
#pragma warning restore 612, 618
        }
    }
}
