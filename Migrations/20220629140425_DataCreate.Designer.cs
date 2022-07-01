﻿// <auto-generated />
using System;
using KariyerClone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KariyerClone.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220629140425_DataCreate")]
    partial class DataCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KariyerClone.Models.ApplicantCriterias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DrivingLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MilitaryStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicantCriterias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DrivingLicense = "B",
                            EducationLevel = "Bachelor",
                            MilitaryStatus = "Done"
                        },
                        new
                        {
                            Id = 2,
                            DrivingLicense = "B",
                            EducationLevel = "Master"
                        },
                        new
                        {
                            Id = 3,
                            DrivingLicense = "B",
                            EducationLevel = "PHD",
                            MilitaryStatus = "Done"
                        },
                        new
                        {
                            Id = 4,
                            EducationLevel = "Master"
                        },
                        new
                        {
                            Id = 5,
                            MilitaryStatus = "Done"
                        });
                });

            modelBuilder.Entity("KariyerClone.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoundationYear")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "California",
                            Description = "Google LLC is an American multinational technology company that focuses on artificial intelligence, search engine technology, online advertising, cloud computing, computer software, quantum computing, e-commerce, and consumer electronics.",
                            FoundationYear = 1998,
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Google_%22G%22_Logo.svg/800px-Google_%22G%22_Logo.svg.png",
                            Name = "Google",
                            NumberOfEmployees = 300000,
                            Sector = "IT",
                            Website = "https://www.google.com/"
                        },
                        new
                        {
                            Id = 2,
                            Address = "California",
                            Description = "The Walt Disney Company, commonly known as Disney, is an American multinational mass media and entertainment conglomerate headquartered at the Walt Disney Studios complex in Burbank, California.",
                            FoundationYear = 1923,
                            Logo = "https://frpnet.net/wp-content/uploads/2018/11/Disney-logo-1.jpg",
                            Name = "Disney",
                            NumberOfEmployees = 200000,
                            Sector = "Media",
                            Website = "https://thewaltdisneycompany.com/"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Leiden",
                            Description = "Airbus SE is a European multinational aerospace corporation. Airbus designs, manufactures and sells civil and military aerospace products worldwide and manufactures aircraft in Europe and various countries outside Europe.",
                            FoundationYear = 1970,
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Logo_Airbus_2014.svg/2560px-Logo_Airbus_2014.svg.png",
                            Name = "AIRBUS",
                            NumberOfEmployees = 100000,
                            Sector = "Aerospace",
                            Website = "https://www.airbus.com/en"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Tokyo",
                            Description = "FromSoftware, Inc. is a Japanese video game development company founded in November 1986 and a subsidiary of Kadokawa Corporation. The company is best known for their Armored Core and Souls series, including the related games Bloodborne, Sekiro, and Elden Ring.",
                            FoundationYear = 1986,
                            Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/012011/from_soft.png?itok=EA5zFilD",
                            Name = "From Software",
                            NumberOfEmployees = 9877,
                            Sector = "IT",
                            Website = "https://www.fromsoftware.jp/ww/"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Istanbul",
                            Description = "Peak Games is a mobile gaming company based in Istanbul, Turkey. The privately-held company was acquired by Zynga in June 2020 for $1.8 billion. The company launched the games Toy Blast in 2015 and Toon Blast in 2017, both collectively have more than 12 million average mobile daily active users as of June 2020.",
                            FoundationYear = 2010,
                            Logo = "https://peakweb.global.ssl.fastly.net/static/assets/icons/logo-header-180-90.b348ab1a.png",
                            Name = "Peak",
                            NumberOfEmployees = 3213,
                            Sector = "IT",
                            Website = "https://peak.com/"
                        });
                });

            modelBuilder.Entity("KariyerClone.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ApplicantCriteriasId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfWork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantCriteriasId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicantCriteriasId = 1,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 8, 3, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1662),
                            CompanyId = 2,
                            Department = "Human Resources",
                            Description = "Job Description1",
                            PositionLevel = "Junior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1653),
                            Title = "Human Resource Specialist",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 2,
                            ApplicantCriteriasId = 4,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 7, 13, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1696),
                            CompanyId = 4,
                            Department = "Human Resources",
                            Description = "Job Description2",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1695),
                            Title = "Human Resource Specialist",
                            TypeOfWork = "Full-time"
                        },
                        new
                        {
                            Id = 3,
                            ApplicantCriteriasId = 2,
                            City = "Tokyo",
                            ClosingDate = new DateTime(2022, 7, 16, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1699),
                            CompanyId = 1,
                            Department = "IT",
                            Description = "Job Description3",
                            PositionLevel = "Manager",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1699),
                            Title = "Developer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 4,
                            ApplicantCriteriasId = 3,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 7, 8, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1702),
                            CompanyId = 4,
                            Department = "Marketing",
                            Description = "Job Description4",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1702),
                            Title = "Marketer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 5,
                            ApplicantCriteriasId = 1,
                            City = "Adana",
                            ClosingDate = new DateTime(2022, 8, 14, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1705),
                            CompanyId = 4,
                            Department = "Sales",
                            Description = "Job Description5",
                            PositionLevel = "Manager",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1704),
                            Title = "Salesman",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 6,
                            ApplicantCriteriasId = 3,
                            City = "Istanbul",
                            ClosingDate = new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1708),
                            CompanyId = 4,
                            Department = "Human Resources",
                            Description = "Job Description6",
                            PositionLevel = "Junior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1708),
                            Title = "Human Resource Specialist",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 7,
                            ApplicantCriteriasId = 2,
                            City = "Wuhan",
                            ClosingDate = new DateTime(2022, 8, 8, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1711),
                            CompanyId = 4,
                            Department = "Human Resources",
                            Description = "Job Description7",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1711),
                            Title = "Human Resource Specialist",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 8,
                            ApplicantCriteriasId = 4,
                            City = "Wuhan",
                            ClosingDate = new DateTime(2022, 8, 15, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1714),
                            CompanyId = 2,
                            Department = "IT",
                            Description = "Job Description8",
                            PositionLevel = "Manager",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1714),
                            Title = "Developer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 9,
                            ApplicantCriteriasId = 3,
                            City = "Los Angeles",
                            ClosingDate = new DateTime(2022, 8, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1717),
                            CompanyId = 5,
                            Department = "Marketing",
                            Description = "Job Description9",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1717),
                            Title = "Marketer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 10,
                            ApplicantCriteriasId = 1,
                            City = "Los Angeles",
                            ClosingDate = new DateTime(2022, 7, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1721),
                            CompanyId = 1,
                            Department = "Finance",
                            Description = "Job Description10",
                            PositionLevel = "Junior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1721),
                            Title = "Finance Specialist",
                            TypeOfWork = "Full-time"
                        },
                        new
                        {
                            Id = 11,
                            ApplicantCriteriasId = 3,
                            City = "Wuhan",
                            ClosingDate = new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1724),
                            CompanyId = 3,
                            Department = "Marketing",
                            Description = "Job Description11",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1724),
                            Title = "Marketer",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 12,
                            ApplicantCriteriasId = 4,
                            City = "Los Angeles",
                            ClosingDate = new DateTime(2022, 7, 17, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1727),
                            CompanyId = 3,
                            Department = "IT",
                            Description = "Job Description12",
                            PositionLevel = "Junior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1727),
                            Title = "Developer",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 13,
                            ApplicantCriteriasId = 3,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 8, 7, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1730),
                            CompanyId = 2,
                            Department = "Marketing",
                            Description = "Job Description13",
                            PositionLevel = "Junior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1729),
                            Title = "Marketer",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 14,
                            ApplicantCriteriasId = 4,
                            City = "Wuhan",
                            ClosingDate = new DateTime(2022, 7, 26, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1732),
                            CompanyId = 1,
                            Department = "Sales",
                            Description = "Job Description14",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1732),
                            Title = "Salesman",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 15,
                            ApplicantCriteriasId = 4,
                            City = "Bangkok",
                            ClosingDate = new DateTime(2022, 7, 24, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1735),
                            CompanyId = 5,
                            Department = "IT",
                            Description = "Job Description15",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1735),
                            Title = "Developer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 16,
                            ApplicantCriteriasId = 1,
                            City = "Adana",
                            ClosingDate = new DateTime(2022, 8, 9, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1738),
                            CompanyId = 2,
                            Department = "Sales",
                            Description = "Job Description16",
                            PositionLevel = "Manager",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1737),
                            Title = "Salesman",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 17,
                            ApplicantCriteriasId = 2,
                            City = "Istanbul",
                            ClosingDate = new DateTime(2022, 8, 16, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1740),
                            CompanyId = 3,
                            Department = "Sales",
                            Description = "Job Description17",
                            PositionLevel = "Manager",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1740),
                            Title = "Salesman",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 18,
                            ApplicantCriteriasId = 1,
                            City = "Tokyo",
                            ClosingDate = new DateTime(2022, 7, 25, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1744),
                            CompanyId = 4,
                            Department = "Marketing",
                            Description = "Job Description18",
                            PositionLevel = "Manager",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1744),
                            Title = "Marketer",
                            TypeOfWork = "Full-time"
                        },
                        new
                        {
                            Id = 19,
                            ApplicantCriteriasId = 1,
                            City = "Istanbul",
                            ClosingDate = new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1747),
                            CompanyId = 4,
                            Department = "Marketing",
                            Description = "Job Description19",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1747),
                            Title = "Marketer",
                            TypeOfWork = "Full-time"
                        },
                        new
                        {
                            Id = 20,
                            ApplicantCriteriasId = 1,
                            City = "Bangkok",
                            ClosingDate = new DateTime(2022, 8, 13, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1750),
                            CompanyId = 3,
                            Department = "Human Resources",
                            Description = "Job Description20",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1749),
                            Title = "Human Resource Specialist",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 21,
                            ApplicantCriteriasId = 4,
                            City = "Wuhan",
                            ClosingDate = new DateTime(2022, 7, 25, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1752),
                            CompanyId = 5,
                            Department = "Finance",
                            Description = "Job Description21",
                            PositionLevel = "Manager",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1752),
                            Title = "Finance Specialist",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 22,
                            ApplicantCriteriasId = 1,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 8, 2, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1755),
                            CompanyId = 2,
                            Department = "Sales",
                            Description = "Job Description22",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1755),
                            Title = "Salesman",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 23,
                            ApplicantCriteriasId = 1,
                            City = "Bangkok",
                            ClosingDate = new DateTime(2022, 8, 17, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1786),
                            CompanyId = 5,
                            Department = "Human Resources",
                            Description = "Job Description23",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1786),
                            Title = "Human Resource Specialist",
                            TypeOfWork = "Full-time"
                        },
                        new
                        {
                            Id = 24,
                            ApplicantCriteriasId = 3,
                            City = "Los Angeles",
                            ClosingDate = new DateTime(2022, 8, 5, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1789),
                            CompanyId = 1,
                            Department = "Finance",
                            Description = "Job Description24",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1789),
                            Title = "Finance Specialist",
                            TypeOfWork = "Full-time"
                        },
                        new
                        {
                            Id = 25,
                            ApplicantCriteriasId = 4,
                            City = "Istanbul",
                            ClosingDate = new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1792),
                            CompanyId = 4,
                            Department = "Marketing",
                            Description = "Job Description25",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1791),
                            Title = "Marketer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 26,
                            ApplicantCriteriasId = 4,
                            City = "Tokyo",
                            ClosingDate = new DateTime(2022, 7, 26, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1795),
                            CompanyId = 5,
                            Department = "Human Resources",
                            Description = "Job Description26",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1794),
                            Title = "Human Resource Specialist",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 27,
                            ApplicantCriteriasId = 1,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 8, 11, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1798),
                            CompanyId = 1,
                            Department = "Finance",
                            Description = "Job Description27",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1797),
                            Title = "Finance Specialist",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 28,
                            ApplicantCriteriasId = 4,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 7, 4, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1800),
                            CompanyId = 5,
                            Department = "Finance",
                            Description = "Job Description28",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1800),
                            Title = "Finance Specialist",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 29,
                            ApplicantCriteriasId = 1,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 7, 9, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1837),
                            CompanyId = 1,
                            Department = "Sales",
                            Description = "Job Description29",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1836),
                            Title = "Salesman",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 30,
                            ApplicantCriteriasId = 4,
                            City = "Adana",
                            ClosingDate = new DateTime(2022, 8, 1, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1840),
                            CompanyId = 4,
                            Department = "Finance",
                            Description = "Job Description30",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1839),
                            Title = "Finance Specialist",
                            TypeOfWork = "Full-time"
                        },
                        new
                        {
                            Id = 31,
                            ApplicantCriteriasId = 1,
                            City = "Bangkok",
                            ClosingDate = new DateTime(2022, 7, 20, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1842),
                            CompanyId = 1,
                            Department = "Finance",
                            Description = "Job Description31",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1842),
                            Title = "Finance Specialist",
                            TypeOfWork = "Part-time"
                        },
                        new
                        {
                            Id = 32,
                            ApplicantCriteriasId = 1,
                            City = "Wuhan",
                            ClosingDate = new DateTime(2022, 8, 21, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1845),
                            CompanyId = 4,
                            Department = "Marketing",
                            Description = "Job Description32",
                            PositionLevel = "Senior",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1845),
                            Title = "Marketer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 33,
                            ApplicantCriteriasId = 2,
                            City = "Wuhan",
                            ClosingDate = new DateTime(2022, 7, 21, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1847),
                            CompanyId = 3,
                            Department = "IT",
                            Description = "Job Description33",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1847),
                            Title = "Developer",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 34,
                            ApplicantCriteriasId = 1,
                            City = "Dubai",
                            ClosingDate = new DateTime(2022, 8, 3, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1851),
                            CompanyId = 5,
                            Department = "Sales",
                            Description = "Job Description34",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1851),
                            Title = "Salesman",
                            TypeOfWork = "Contract-Based"
                        },
                        new
                        {
                            Id = 35,
                            ApplicantCriteriasId = 2,
                            City = "Bangkok",
                            ClosingDate = new DateTime(2022, 7, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1855),
                            CompanyId = 4,
                            Department = "IT",
                            Description = "Job Description35",
                            PositionLevel = "Principal",
                            PostingDate = new DateTime(2022, 6, 29, 17, 4, 25, 646, DateTimeKind.Local).AddTicks(1854),
                            Title = "Developer",
                            TypeOfWork = "Full-time"
                        });
                });

            modelBuilder.Entity("KariyerClone.Models.Job", b =>
                {
                    b.HasOne("KariyerClone.Models.ApplicantCriterias", "ApplicantCriterias")
                        .WithMany("Jobs")
                        .HasForeignKey("ApplicantCriteriasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KariyerClone.Models.Company", "Company")
                        .WithMany("Jobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicantCriterias");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("KariyerClone.Models.ApplicantCriterias", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("KariyerClone.Models.Company", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}