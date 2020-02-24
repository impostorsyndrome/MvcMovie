﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using MvcMovie.Data;

namespace MvcMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "3.1.1")
                        .HasAnnotation("Relational:MaxIdentifierLength", 128)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcMovie.Models.Movie", builder =>
                {
                    builder.Property<int>("Id")
                           .ValueGeneratedOnAdd()
                           .HasColumnType("int")
                           .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    builder.Property<string>("Genre")
                           .HasColumnType("nvarchar(max)");

                    builder.Property<decimal>("Price")
                           .HasColumnType("decimal(18, 2)");

                    builder.Property<string>("Rating")
                           .HasColumnType("nvarchar(max)");

                    builder.Property<DateTime>("ReleaseDate")
                           .HasColumnType("datetime2");

                    builder.Property<string>("Title")
                           .HasColumnType("nvarchar(max)");

                    builder.HasKey("Id");

                    builder.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
