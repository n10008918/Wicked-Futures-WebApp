﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wicked_Futures_WebApp.Data;

#nullable disable

namespace Wicked_Futures_WebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220409151828_updatestudent1")]
    partial class updatestudent1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Wicked_Futures_WebApp.Models.LessonPage", b =>
                {
                    b.Property<int>("LessonPageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LessonMediaType")
                        .HasColumnType("int");

                    b.Property<string>("LessonPageDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LessonPageMediaEmbed")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LessonPageTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LessonPageId");

                    b.ToTable("LessonPages");
                });

            modelBuilder.Entity("Wicked_Futures_WebApp.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
