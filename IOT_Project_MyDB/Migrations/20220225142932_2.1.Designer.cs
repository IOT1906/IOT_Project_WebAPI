﻿// <auto-generated />
using System;
using IOT_Project_MyDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IOT_Project_MyDB.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220225142932_2.1")]
    partial class _21
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IOT_Priject_Domin.Model.Annual_plan", b =>
                {
                    b.Property<int>("Annualid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Particular_year")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tabulation_Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tabulation_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tabulator")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Annualid");

                    b.ToTable("Annual_plan");
                });

            modelBuilder.Entity("IOT_Priject_Domin.Model.Expected_increase_this_year", b =>
                {
                    b.Property<int>("YearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("April")
                        .HasColumnType("int");

                    b.Property<int>("August")
                        .HasColumnType("int");

                    b.Property<int>("December")
                        .HasColumnType("int");

                    b.Property<int>("February")
                        .HasColumnType("int");

                    b.Property<int>("January")
                        .HasColumnType("int");

                    b.Property<int>("July")
                        .HasColumnType("int");

                    b.Property<int>("June")
                        .HasColumnType("int");

                    b.Property<string>("Last_year")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("March")
                        .HasColumnType("int");

                    b.Property<int>("May")
                        .HasColumnType("int");

                    b.Property<int>("November")
                        .HasColumnType("int");

                    b.Property<int>("October")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("September")
                        .HasColumnType("int");

                    b.Property<int>("Station")
                        .HasColumnType("int");

                    b.HasKey("YearId");

                    b.ToTable("Expected_increase_this_year");
                });
#pragma warning restore 612, 618
        }
    }
}