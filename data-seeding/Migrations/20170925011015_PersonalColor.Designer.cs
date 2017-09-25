﻿// <auto-generated />
using data_seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace dataseeding.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20170925011015_PersonalColor")]
    partial class PersonalColor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-27122")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("data_seeding.BloggingContext+Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BlogUrl");

                    b.Property<int?>("ThemeId");

                    b.HasKey("BlogId");

                    b.HasIndex("ThemeId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("data_seeding.BloggingContext+Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("TitleColor");

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");

                    b.SeedData(new[]
                    {
                        new { ThemeId = 1, Name = "MSDN", TitleColor = -5658199 },
                        new { ThemeId = 2, Name = "TechNet", TitleColor = -16741493 },
                        new { ThemeId = 3, Name = "Personal", TitleColor = -5383962 }
                    });
                });

            modelBuilder.Entity("data_seeding.BloggingContext+Blog", b =>
                {
                    b.HasOne("data_seeding.BloggingContext+Theme", "Theme")
                        .WithMany()
                        .HasForeignKey("ThemeId");
                });
#pragma warning restore 612, 618
        }
    }
}
