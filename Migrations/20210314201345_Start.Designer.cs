﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Models;

namespace Project1.Migrations
{
    [DbContext(typeof(TourDbContext))]
    [Migration("20210314201345_Start")]
    partial class Start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12");

            modelBuilder.Entity("Project1.Models.TourGroup", b =>
                {
                    b.Property<int>("TourGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("TourName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TourSize")
                        .HasColumnType("INTEGER");

                    b.HasKey("TourGroupId");

                    b.ToTable("Tours");
                });
#pragma warning restore 612, 618
        }
    }
}
