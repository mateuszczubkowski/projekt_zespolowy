﻿// <auto-generated />
using System;
using AppName.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppName.Migrations.Advertisement
{
    [DbContext(typeof(AdvertisementContext))]
    [Migration("20190417121913_Cos")]
    partial class Cos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppName.Models.AdvertisementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName");

                    b.Property<int?>("CityId");

                    b.Property<string>("CityName");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("PhoneNumber");

                    b.Property<float>("Price");

                    b.Property<int?>("ProvinceId");

                    b.Property<string>("ProvinceName");

                    b.Property<string>("Title");

                    b.Property<float>("Yardage");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Advertisment");
                });

            modelBuilder.Entity("AppName.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AppName.Models.CityModel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("CityName");

                    b.Property<int>("ProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AppName.Models.CommentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date");

                    b.Property<string>("Name");

                    b.Property<string>("opinion");

                    b.Property<int>("rating");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("AppName.Models.ProvinceModel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("ProvinceName");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("AppName.Models.AdvertisementModel", b =>
                {
                    b.HasOne("AppName.Models.CategoryModel", "Category")
                        .WithMany("Advertisements")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppName.Models.CityModel", "City")
                        .WithMany("Advertisements")
                        .HasForeignKey("CityId");

                    b.HasOne("AppName.Models.ProvinceModel", "Province")
                        .WithMany("Advertisements")
                        .HasForeignKey("ProvinceId");
                });

            modelBuilder.Entity("AppName.Models.CityModel", b =>
                {
                    b.HasOne("AppName.Models.ProvinceModel", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
