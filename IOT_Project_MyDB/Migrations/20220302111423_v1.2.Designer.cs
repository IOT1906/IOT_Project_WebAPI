﻿// <auto-generated />
using IOT_Project_MyDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IOT_Project_MyDB.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220302111423_v1.2")]
    partial class v12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IOT_Priject_Domin.Model.Engrave_chapter", b =>
                {
                    b.Property<int>("AnnounId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Applicant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imprint_mark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seal_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("AnnounId");

                    b.ToTable("Engrave_chapter");
                });

            modelBuilder.Entity("IOT_Priject_Domin.Model.Management", b =>
                {
                    b.Property<int>("ManId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manarchiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manattachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mancontent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mandocuments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mannumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("ManId");

                    b.ToTable("Management");
                });

            modelBuilder.Entity("IOT_Priject_Domin.Model.Notice", b =>
                {
                    b.Property<int>("AnnounId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Release_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typing")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnnounId");

                    b.ToTable("Notice");
                });

            modelBuilder.Entity("IOT_Priject_Domin.Model.Use_seal", b =>
                {
                    b.Property<int>("AnnounId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Applicant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Entourage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lend_out")
                        .HasColumnType("int");

                    b.Property<string>("Out_of_office_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Printing_matters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Return_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seal_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("AnnounId");

                    b.ToTable("Use_seal");
                });
#pragma warning restore 612, 618
        }
    }
}
