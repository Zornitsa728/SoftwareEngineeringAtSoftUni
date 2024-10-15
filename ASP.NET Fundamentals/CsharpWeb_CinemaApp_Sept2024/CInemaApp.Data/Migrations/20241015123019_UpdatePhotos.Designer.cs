﻿// <auto-generated />
using System;
using CInemaApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CInemaApp.Data.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20241015123019_UpdatePhotos")]
    partial class UpdatePhotos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinemaApp.Data.Models.Cinema", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2d21ccde-dbfc-406d-a937-b72afae45fba"),
                            ImageUrl = "/images/cinema-ruse.jpg",
                            Location = "Ruse",
                            Name = "Cinema City"
                        },
                        new
                        {
                            Id = new Guid("34a43dec-7ee3-49e6-9a78-777e05e8a709"),
                            ImageUrl = "/images/cinema-plovdiv.jpg",
                            Location = "Plovdiv",
                            Name = "Cinema City"
                        },
                        new
                        {
                            Id = new Guid("11963540-aa26-47d7-bb3d-b781bf56940b"),
                            ImageUrl = "/images/cinema-varna.png",
                            Location = "Varna",
                            Name = "CinemaMax"
                        },
                        new
                        {
                            Id = new Guid("c97563d4-39e5-47f3-8e02-3fa18b2b95dd"),
                            ImageUrl = "/images/cinema-sofia.jpeg",
                            Location = "Sofia",
                            Name = "Cinema"
                        });
                });

            modelBuilder.Entity("CinemaApp.Data.Models.CinemaMovie", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CinemaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("MovieId", "CinemaId");

                    b.HasIndex("CinemaId");

                    b.ToTable("CinemasMovies");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("be880494-cdc1-4e17-9269-7e2dad6c844e"),
                            Description = "In his fourth year at Hogwarts, Harry must reluctantly compete in an ancient wizard tournament after someone mysteriously selects his name, while the Dark Lord secretly conspires something sinister.",
                            Director = "Mike Newel",
                            Duration = 157,
                            Genre = "Fantasy",
                            ReleaseDate = new DateTime(2005, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Harry Potter and the Goblet of Fire"
                        },
                        new
                        {
                            Id = new Guid("d4980ca2-737f-4697-bea0-3c91e2bbff26"),
                            Description = "Twilight is a 2008 American romantic fantasy film directed by Catherine Hardwicke from a screenplay by Melissa Rosenberg, based on the 2005 novel of the same name by Stephenie Meyer. It is the first installment in The Twilight Saga film series.",
                            Director = "Catherine Hardwicke",
                            Duration = 121,
                            Genre = "Fantasy",
                            ReleaseDate = new DateTime(2008, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Twilight"
                        });
                });

            modelBuilder.Entity("CinemaApp.Data.Models.CinemaMovie", b =>
                {
                    b.HasOne("CinemaApp.Data.Models.Cinema", "Cinema")
                        .WithMany("CinemaMovies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CinemaApp.Data.Models.Movie", "Movie")
                        .WithMany("CinemaMovies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Cinema", b =>
                {
                    b.Navigation("CinemaMovies");
                });

            modelBuilder.Entity("CinemaApp.Data.Models.Movie", b =>
                {
                    b.Navigation("CinemaMovies");
                });
#pragma warning restore 612, 618
        }
    }
}
